using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class iPhone
	{
		public static iPhoneGeneration generation
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}
	}
}
