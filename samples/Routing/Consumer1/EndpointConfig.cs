using NServiceBus;
using NServiceBus.Unicast.Transport.RabbitMQ.Config;

namespace Consumer1
{
	public class EndpointConfig : IConfigureThisEndpoint, IWantCustomInitialization
	{
		public void Init()
		{
			Configure.With()
				.DefaultBuilder()
				.XmlSerializer()
				.RabbitMqTransport()
				.UnicastBus()
					.LoadMessageHandlers();
		}
	}
}