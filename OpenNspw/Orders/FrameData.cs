using System.Collections.Generic;
using System.Linq;

namespace OpenNspw.Orders
{
	// Code from: https://github.com/OpenRA/OpenRA/blob/23b3c237b7071fd308c4664b0b6c5d719c0f3c74/OpenRA.Game/Network/FrameData.cs#L17
	internal sealed class FrameData
	{
		private readonly Dictionary<ClientId, FrameId> _clientQuitTimes = new();
		private readonly Dictionary<FrameId, Dictionary<ClientId, IEnumerable<IOrder>>> _framePackets = new();

		private IEnumerable<ClientId> ClientsPlayingInFrame(FrameId frameId) => _clientQuitTimes
			.Where(x => x.Value >= frameId)
			.Select(x => x.Key)
			.OrderBy(x => x);

		private IEnumerable<ClientId> ClientsNotReadyForFrame(FrameId frameId)
		{
			var frameData = _framePackets.GetOrAdd(frameId);
			return ClientsPlayingInFrame(frameId).Where(c => !frameData.ContainsKey(c));
		}

		public bool IsReadyForFrame(FrameId frameId) => !ClientsNotReadyForFrame(frameId).Any();

		public void AddFrameOrders(ClientId clientId, FrameId frameId, IEnumerable<IOrder> orders)
		{
			var frameData = _framePackets.GetOrAdd(frameId);
			frameData.Add(clientId, orders);
		}

		public IEnumerable<IOrder> OrdersForFrame(FrameId frameId)
		{
			var frameData = _framePackets[frameId];
			var clientData = ClientsPlayingInFrame(frameId).ToDictionary(k => k, v => frameData[v]);
			return clientData.SelectMany(x => x.Value);
		}

		public void ClientQuit(ClientId clientId, FrameId frameId) => _clientQuitTimes[clientId] = frameId;
	}
}
