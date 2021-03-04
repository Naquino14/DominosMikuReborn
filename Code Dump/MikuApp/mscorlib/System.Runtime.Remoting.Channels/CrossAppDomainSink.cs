using System.Collections;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	[MonoTODO("Handle domain unloading?")]
	internal class CrossAppDomainSink : IMessageSink
	{
		private struct ProcessMessageRes
		{
			public byte[] arrResponse;

			public CADMethodReturnMessage cadMrm;
		}

		private static Hashtable s_sinks;

		private static MethodInfo processMessageMethod;

		private int _domainID;

		internal int TargetDomainId => (int)/*Error near IL_0001: Stack underflow*/;

		public virtual IMessage SyncProcessMessage(IMessage msgRequest)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}

		public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink)
		{
			return (IMessageCtrl)/*Error near IL_0001: Stack underflow*/;
		}

		public void SendAsyncMessage(object data)
		{
		}
	}
}
