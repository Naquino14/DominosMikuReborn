using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class AudioListener : Behaviour
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void GetSpectrumDataHelper(float[] samples, int channel, FFTWindow window);

		public static void GetSpectrumData(float[] samples, int channel, FFTWindow window)
		{
		}
	}
}
