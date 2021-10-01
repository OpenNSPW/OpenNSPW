using OpenNspw.Orders;

namespace OpenNspw.Messages;

internal sealed record FrameMessage(
	ClientId ClientId,
	FrameId FrameId,
	IEnumerable<IOrder> Orders
) : IMessage;
