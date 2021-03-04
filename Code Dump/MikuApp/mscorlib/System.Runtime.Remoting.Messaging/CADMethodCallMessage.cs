namespace System.Runtime.Remoting.Messaging
{
	internal class CADMethodCallMessage : CADMessageBase
	{
		private string _uri;

		internal RuntimeMethodHandle MethodHandle;

		internal string FullTypeName;

		internal CADMethodCallMessage(IMethodCallMessage callMsg)
		{
		}

		internal static CADMethodCallMessage Create(IMessage callMsg)
		{
			return (CADMethodCallMessage)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
