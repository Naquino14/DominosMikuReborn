using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Texture2D : Texture
	{
		public TextureFormat format
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Texture2D(int width, int height)
		{
		}

		public Texture2D(int width, int height, TextureFormat format, bool mipmap)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_Create([Writable] Texture2D mono, int width, int height, TextureFormat format, bool mipmap, bool linear);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern Color32[] GetPixels32(int miplevel);

		public Color32[] GetPixels32()
		{
			return (Color32[])/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Apply(bool updateMipmaps, bool makeNoLongerReadable);

		public void Apply()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool Resize(int width, int height, TextureFormat format, bool hasMipMap);

		public void ReadPixels(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
		}

		public void ReadPixels(Rect source, int destX, int destY)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_ReadPixels(Texture2D self, ref Rect source, int destX, int destY, bool recalculateMipMaps);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern byte[] EncodeToPNG();
	}
}
