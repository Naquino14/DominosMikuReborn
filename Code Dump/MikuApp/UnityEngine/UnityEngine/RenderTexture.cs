using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class RenderTexture : Texture
	{
		public override int width
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public override int height
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public int depth
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool isPowerOfTwo
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public RenderTextureFormat format
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static RenderTexture active
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public RenderTexture(int width, int height, int depth)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_CreateRenderTexture([Writable] RenderTexture rt);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite);

		public static RenderTexture GetTemporary(int width, int height)
		{
			return (RenderTexture)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void ReleaseTemporary(RenderTexture temp);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int Internal_GetWidth(RenderTexture mono);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_SetWidth(RenderTexture mono, int width);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int Internal_GetHeight(RenderTexture mono);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_SetHeight(RenderTexture mono, int width);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_SetSRGBReadWrite(RenderTexture mono, bool sRGB);
	}
}
