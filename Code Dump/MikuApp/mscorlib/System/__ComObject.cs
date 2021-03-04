using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	internal class __ComObject : MarshalByRefObject
	{
		private IntPtr iunknown;

		private IntPtr hash_table;

		internal unsafe IntPtr IUnknown => (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;

		internal unsafe IntPtr IDispatch => (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;

		internal static Guid IID_IUnknown => (Guid)/*Error near IL_0001: Stack underflow*/;

		internal static Guid IID_IDispatch => (Guid)/*Error near IL_0001: Stack underflow*/;

		public __ComObject()
		{
		}

		internal __ComObject(Type t)
		{
		}

		internal __ComObject(IntPtr pItf)
		{
		}

		[MethodImpl(4096)]
		internal static extern __ComObject CreateRCW(Type t);

		[MethodImpl(4096)]
		private extern void ReleaseInterfaces();

		~__ComObject()
		{
		}

		internal void Initialize(Type t)
		{
		}

		private static Guid GetCLSID(Type t)
		{
			return (Guid)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		internal extern IntPtr GetInterfaceInternal(Type t, bool throwException);

		internal unsafe IntPtr GetInterface(Type t, bool throwException)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		internal unsafe IntPtr GetInterface(Type t)
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}

		private void CheckIUnknown()
		{
		}

		public override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[DllImport("ole32.dll", CallingConvention = 3, ExactSpelling = true)]
		private static extern int CoCreateInstance([In][MarshalAs(43)] Guid rclsid, IntPtr pUnkOuter, uint dwClsContext, [In][MarshalAs(43)] Guid riid, out IntPtr pUnk);
	}
}
