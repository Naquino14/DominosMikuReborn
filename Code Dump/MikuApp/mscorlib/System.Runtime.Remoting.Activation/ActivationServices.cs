using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Activation
{
	internal class ActivationServices
	{
		private static IActivator _constructionActivator;

		private static IActivator ConstructionActivator => (IActivator)/*Error near IL_0001: Stack underflow*/;

		public static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}

		public static object CreateProxyFromAttributes(Type type, object[] activationAttributes)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes)
		{
			return (ConstructionCall)/*Error near IL_0001: Stack underflow*/;
		}

		public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		public static extern object AllocateUninitializedClassInstance(Type type);
	}
}
