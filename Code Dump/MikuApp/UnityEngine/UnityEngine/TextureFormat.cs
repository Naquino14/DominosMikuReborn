using System;

namespace UnityEngine
{
	public enum TextureFormat
	{
		Alpha8 = 1,
		ARGB4444 = 2,
		RGB24 = 3,
		RGBA32 = 4,
		ARGB32 = 5,
		RGB565 = 7,
		DXT1 = 10,
		DXT5 = 12,
		RGBA4444 = 13,
		[Obsolete("Use PVRTC_RGB2")]
		PVRTC_2BPP_RGB = 30,
		[Obsolete("Use PVRTC_RGBA2")]
		PVRTC_2BPP_RGBA = 0x1F,
		[Obsolete("Use PVRTC_RGB4")]
		PVRTC_4BPP_RGB = 0x20,
		[Obsolete("Use PVRTC_RGBA4")]
		PVRTC_4BPP_RGBA = 33,
		PVRTC_RGB2 = 30,
		PVRTC_RGBA2 = 0x1F,
		PVRTC_RGB4 = 0x20,
		PVRTC_RGBA4 = 33,
		ETC_RGB4 = 34,
		ATC_RGB4 = 35,
		ATC_RGBA8 = 36,
		BGRA32 = 37,
		ATF_RGB_DXT1 = 38,
		ATF_RGBA_JPG = 39,
		ATF_RGB_JPG = 40
	}
}
