using System.Runtime.Remoting.Contexts;

namespace System.Runtime.Remoting.Messaging
{
	internal class ClientContextTerminatorSink : IMessageSink
	{
		private Context _context;

		public ClientContextTerminatorSink(Context ctx)
		{
		}

		public IMessage SyncProcessMessage(IMessage msg)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}

		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return (IMessageCtrl)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
