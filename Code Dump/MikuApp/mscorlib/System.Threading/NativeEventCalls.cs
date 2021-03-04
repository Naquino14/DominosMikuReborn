using System.Runtime.CompilerServices;

namespace System.Threading
{
	internal sealed class NativeEventCalls
	{
		[MethodImpl(4096)]
		public static extern IntPtr CreateEvent_internal(bool manual, bool initial, string name, out bool created);

		[MethodImpl(4096)]
		public static extern bool SetEvent_internal(IntPtr handle);

		[MethodImpl(4096)]
		public static extern void CloseEvent_internal(IntPtr handle);
	}
}
