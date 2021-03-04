using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Caching
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool CleanCache();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool IsVersionCached(string url, int version);
	}
}
