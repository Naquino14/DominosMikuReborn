using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Display
	{
		internal IntPtr nativeDisplay;

		public static Display[] displays;

		private static Display _mainDisplay;

		public int renderingWidth => (int)/*Error near IL_0001: Stack underflow*/;

		public int renderingHeight => (int)/*Error near IL_0001: Stack underflow*/;

		public int systemWidth => (int)/*Error near IL_0001: Stack underflow*/;

		public int systemHeight => (int)/*Error near IL_0001: Stack underflow*/;

		public RenderBuffer colorBuffer => (RenderBuffer)/*Error near IL_0001: Stack underflow*/;

		public RenderBuffer depthBuffer => (RenderBuffer)/*Error near IL_0001: Stack underflow*/;

		public static Display main => (Display)/*Error near IL_0001: Stack underflow*/;

		internal Display(IntPtr nativeDisplay)
		{
		}

		public void SetRenderingResolution(int w, int h)
		{
		}

		private static void RecreateDisplays(IntPtr[] nativeDisplay)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void GetRenderingBuffersImpl(IntPtr nativeDisplay, out RenderBuffer color, out RenderBuffer depth);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h);
	}
}
