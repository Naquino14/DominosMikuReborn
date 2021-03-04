using System.Reflection;

namespace System.Runtime.Remoting.Messaging
{
	internal class ArgInfo
	{
		private int[] _paramMap;

		private int _inoutArgCount;

		private MethodBase _method;

		public ArgInfo(MethodBase method, ArgInfoType type)
		{
		}

		public int GetInOutArgIndex(int inoutArgNum)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public virtual string GetInOutArgName(int index)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public int GetInOutArgCount()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public object[] GetInOutArgs(object[] args)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
