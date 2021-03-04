using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
	internal class CADMessageBase
	{
		protected object[] _args;

		protected byte[] _serializedArgs;

		protected int _propertyCount;

		protected CADArgHolder _callContext;

		internal static int MarshalProperties(IDictionary dict, ref ArrayList args)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
		{
		}

		private static bool IsPossibleToIgnoreMarshal(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected object MarshalArgument(object arg, ref ArrayList args)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		protected object UnmarshalArgument(object arg, ArrayList args)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		internal object[] MarshalArguments(object[] arguments, ref ArrayList args)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		internal object[] UnmarshalArguments(object[] arguments, ArrayList args)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList)
		{
		}

		internal LogicalCallContext GetLogicalCallContext(ArrayList args)
		{
			return (LogicalCallContext)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
