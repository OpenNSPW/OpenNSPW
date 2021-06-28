using System;

namespace OpenNspw.Orders
{
	internal interface IConnection
	{
		ClientId LocalClientId { get; }

		void Send(IMessage message);

		void Receive(Action<IMessage> callback);
	}
}
