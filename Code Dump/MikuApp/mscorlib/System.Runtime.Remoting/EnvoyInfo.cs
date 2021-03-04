using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	[Serializable]
	internal class EnvoyInfo : IEnvoyInfo
	{
		private IMessageSink envoySinks;

		public IMessageSink EnvoySinks => (IMessageSink)/*Error near IL_0001: Stack underflow*/;

		public EnvoyInfo(IMessageSink sinks)
		{
		}
	}
}
