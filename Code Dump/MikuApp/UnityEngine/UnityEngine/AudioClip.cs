using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class AudioClip : Object
	{
		public delegate void PCMReaderCallback(float[] data);

		public delegate void PCMSetPositionCallback(int position);

		public float length
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int samples
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int channels
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int frequency
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public bool isReadyToPlay
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		private event PCMReaderCallback m_PCMReaderCallback
		{
			[MethodImpl(32)]
			add
			{
			}
			[MethodImpl(32)]
			remove
			{
			}
		}

		private event PCMSetPositionCallback m_PCMSetPositionCallback
		{
			[MethodImpl(32)]
			add
			{
			}
			[MethodImpl(32)]
			remove
			{
			}
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void GetData(float[] data, int offsetSamples);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SetData(float[] data, int offsetSamples);

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream)
		{
			return (AudioClip)/*Error near IL_0001: Stack underflow*/;
		}

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback)
		{
			return (AudioClip)/*Error near IL_0001: Stack underflow*/;
		}

		public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream, PCMReaderCallback pcmreadercallback, PCMSetPositionCallback pcmsetpositioncallback)
		{
			return (AudioClip)/*Error near IL_0001: Stack underflow*/;
		}

		private void InvokePCMReaderCallback_Internal(float[] data)
		{
		}

		private void InvokePCMSetPositionCallback_Internal(int position)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern AudioClip Construct_Internal();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Init_Internal(string name, int lengthSamples, int channels, int frequency, bool _3D, bool stream);
	}
}
