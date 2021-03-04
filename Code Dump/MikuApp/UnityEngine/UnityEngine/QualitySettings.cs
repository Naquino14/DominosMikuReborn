using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class QualitySettings : Object
	{
		public static int antiAliasing
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static ColorSpace activeColorSpace
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}
	}
}
