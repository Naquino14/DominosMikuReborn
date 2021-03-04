using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class SystemInfo
	{
		public static string deviceUniqueIdentifier
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}
	}
}
