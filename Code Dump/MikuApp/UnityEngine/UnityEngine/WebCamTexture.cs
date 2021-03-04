using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class WebCamTexture : Texture
	{
		public bool isPlaying
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public string deviceName
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public float requestedFPS
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int requestedWidth
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int requestedHeight
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static WebCamDevice[] devices
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public bool didUpdateThisFrame
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_CreateWebCamTexture([Writable] WebCamTexture self, string device, int requestedWidth, int requestedHeight, int maxFramerate);

		public void Play()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Play(WebCamTexture self);

		public void Stop()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Stop(WebCamTexture self);
	}
}
