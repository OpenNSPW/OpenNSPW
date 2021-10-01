namespace OpenNspw.Orders
{
	// Code from: https://github.com/OpenRA/OpenRA/blob/bacec2689d603800c403adccbbade68ec36b29d2/OpenRA.Game/Network/Connection.cs
	internal sealed class EchoConnection : IConnection
	{
		private readonly List<IMessage> _receivedMessages = new();

		public ClientId LocalClientId => new(1);

		private void AddMessage(IMessage message)
		{
			lock (_receivedMessages)
				_receivedMessages.Add(message);
		}

		public void Send(IMessage message)
		{
			AddMessage(message);
		}

		public void Receive(Action<IMessage> callback)
		{
			IMessage[] messages;
			lock (_receivedMessages)
			{
				messages = _receivedMessages.ToArray();
				_receivedMessages.Clear();
			}

			foreach (var m in messages)
				callback(m);
		}
	}
}
