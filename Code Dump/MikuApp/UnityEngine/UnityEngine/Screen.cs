using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Screen
	{
		public static int width
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static int height
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static int sleepTimeout
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}
	}
}
