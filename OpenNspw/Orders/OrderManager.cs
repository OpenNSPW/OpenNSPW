using OpenNspw.Messages;

namespace OpenNspw.Orders
{
	// Code from: https://github.com/OpenRA/OpenRA/blob/ab4a7e35581d40c2689ecae802f1c5a1eac3e044/OpenRA.Game/Network/OrderManager.cs
	internal sealed class OrderManager
	{
		public FrameData FrameData { get; } = new();

		public FrameId FrameId { get; private set; }
		private readonly int _framesAhead = 1;

		private readonly IConnection _connection;

		private readonly List<IOrder> _localOrders = new();

		public OrderManager(IConnection connection)
		{
			_connection = connection;

			// HACK
			FrameData.ClientQuit(_connection.LocalClientId, FrameId.MaxValue);
		}

		public bool GameStarted => FrameId != FrameId.Zero;

		public bool IsReadyForNextFrame => GameStarted && FrameData.IsReadyForFrame(FrameId);

		public void StartGame()
		{
			if (GameStarted)
				return;

			FrameId = new FrameId(1);

			for (var i = FrameId; i <= new FrameId(_framesAhead); i++)
				_connection.Send(new FrameMessage(_connection.LocalClientId, i, Enumerable.Empty<IOrder>()));
		}

		public void DispatchOrder(IOrder order) => _localOrders.Add(order);

		public void UpdateImmediate()
		{
			_connection.Receive(message =>
			{
				switch (message)
				{
					case FrameMessage m:
						FrameData.AddFrameOrders(m.ClientId, m.FrameId, m.Orders);
						break;
				}
			});
		}

		public void Update()
		{
			if (!IsReadyForNextFrame)
				return;

			_connection.Send(new FrameMessage(_connection.LocalClientId, FrameId + _framesAhead, _localOrders.ToArray()));

			_localOrders.Clear();

			FrameId++;
		}
	}
}
