using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Time
	{
		public static float time
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static float deltaTime
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static float timeScale
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static int frameCount
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static float realtimeSinceStartup
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}
	}
}
