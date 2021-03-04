using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Random
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern float Range(float min, float max);

		public static int Range(int min, int max)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int RandomRangeInt(int min, int max);
	}
}
