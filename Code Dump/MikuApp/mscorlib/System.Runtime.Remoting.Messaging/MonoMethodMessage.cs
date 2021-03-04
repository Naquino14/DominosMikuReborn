using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Runtime.Remoting.Messaging
{
	[Serializable]
	internal class MonoMethodMessage : IInternalMessage, IMessage, IMethodCallMessage, IMethodMessage, IMethodReturnMessage
	{
		private MonoMethod method;

		private object[] args;

		private string[] names;

		private byte[] arg_types;

		public LogicalCallContext ctx;

		public object rval;

		public Exception exc;

		private AsyncResult asyncResult;

		private CallType call_type;

		private string uri;

		private MethodCallDictionary properties;

		private Type[] methodSignature;

		private Identity identity;

		Identity IInternalMessage.TargetIdentity
		{
			get
			{
				return (Identity)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public IDictionary Properties => (IDictionary)/*Error near IL_0001: Stack underflow*/;

		public int ArgCount => (int)/*Error near IL_0001: Stack underflow*/;

		public object[] Args => (object[])/*Error near IL_0001: Stack underflow*/;

		public bool HasVarArgs => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public LogicalCallContext LogicalCallContext
		{
			get
			{
				return (LogicalCallContext)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public MethodBase MethodBase => (MethodBase)/*Error near IL_0001: Stack underflow*/;

		public string MethodName => (string)/*Error near IL_0001: Stack underflow*/;

		public object MethodSignature => (object)/*Error near IL_0001: Stack underflow*/;

		public string TypeName => (string)/*Error near IL_0001: Stack underflow*/;

		public string Uri
		{
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public int InArgCount => (int)/*Error near IL_0001: Stack underflow*/;

		public object[] InArgs => (object[])/*Error near IL_0001: Stack underflow*/;

		public Exception Exception => (Exception)/*Error near IL_0001: Stack underflow*/;

		public int OutArgCount => (int)/*Error near IL_0001: Stack underflow*/;

		public object[] OutArgs => (object[])/*Error near IL_0001: Stack underflow*/;

		public object ReturnValue => (object)/*Error near IL_0001: Stack underflow*/;

		public bool IsAsync => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public AsyncResult AsyncResult => (AsyncResult)/*Error near IL_0001: Stack underflow*/;

		internal CallType CallType => (CallType)/*Error near IL_0001: Stack underflow*/;

		public MonoMethodMessage(MethodBase method, object[] out_args)
		{
		}

		public MonoMethodMessage(Type type, string method_name, object[] in_args)
		{
		}

		[MethodImpl(4096)]
		internal extern void InitMessage(MonoMethod method, object[] out_args);

		public object GetArg(int arg_num)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public string GetArgName(int arg_num)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public object GetInArg(int arg_num)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public string GetInArgName(int arg_num)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public object GetOutArg(int arg_num)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public string GetOutArgName(int arg_num)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public bool NeedsOutProcessing(out int outCount)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
