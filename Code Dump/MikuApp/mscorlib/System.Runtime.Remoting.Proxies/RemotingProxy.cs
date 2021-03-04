using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Proxies
{
	internal class RemotingProxy : RealProxy, IRemotingTypeInfo
	{
		private static MethodInfo _cache_GetTypeMethod;

		private static MethodInfo _cache_GetHashCodeMethod;

		private IMessageSink _sink;

		private bool _hasEnvoySink;

		private ConstructionCall _ctorCall;

		public string TypeName
		{
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		internal RemotingProxy(Type type, ClientIdentity identity)
		{
		}

		internal RemotingProxy(Type type, string activationUrl, object[] activationAttributes)
		{
		}

		public override IMessage Invoke(IMessage request)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}

		public bool CanCastTo(Type fromType, object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		~RemotingProxy()
		{
		}
	}
}
