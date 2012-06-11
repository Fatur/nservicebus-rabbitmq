using System;
using System.Threading;
using MyMessages;
using NServiceBus;

namespace Consumer1
{
	public class SimpleMessageHandler : IHandleMessages<SimpleMessage>
	{
		public void Handle(SimpleMessage message)
		{
			Console.WriteLine("---- Simple Message Received ----");
			Console.WriteLine("---- Payload: ");
			Console.WriteLine(message.Message);
		}
	}
}