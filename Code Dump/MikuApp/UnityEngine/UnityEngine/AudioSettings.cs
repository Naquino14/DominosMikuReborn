using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class AudioSettings
	{
		public static int outputSampleRate
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}
	}
}
