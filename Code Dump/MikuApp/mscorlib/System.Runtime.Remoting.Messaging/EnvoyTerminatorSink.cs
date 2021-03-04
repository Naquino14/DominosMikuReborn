namespace System.Runtime.Remoting.Messaging
{
	[Serializable]
	internal class EnvoyTerminatorSink : IMessageSink
	{
		public static EnvoyTerminatorSink Instance;

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
