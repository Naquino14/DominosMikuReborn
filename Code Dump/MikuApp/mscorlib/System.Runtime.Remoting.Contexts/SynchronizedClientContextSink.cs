using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	internal class SynchronizedClientContextSink : IMessageSink
	{
		private IMessageSink _next;

		private SynchronizationAttribute _att;

		public SynchronizedClientContextSink(IMessageSink next, SynchronizationAttribute att)
		{
		}

		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return (IMessageCtrl)/*Error near IL_0001: Stack underflow*/;
		}

		public IMessage SyncProcessMessage(IMessage msg)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
