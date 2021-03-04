using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class AudioSource : Behaviour
	{
		public float volume
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float pitch
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float time
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int timeSamples
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public AudioClip clip
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool isPlaying
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public bool loop
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Play(ulong delay);

		public void Play()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Stop();

		public void Pause()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Pause(AudioSource self);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void PlayOneShot(AudioClip clip, float volumeScale);
	}
}
