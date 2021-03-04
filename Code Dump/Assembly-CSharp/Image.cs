using System;

// Token: 0x02000095 RID: 149
public abstract class Image
{
	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000405 RID: 1029
	// (set) Token: 0x06000406 RID: 1030
	public abstract int Width { get; set; }

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000407 RID: 1031
	// (set) Token: 0x06000408 RID: 1032
	public abstract int Height { get; set; }

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000409 RID: 1033
	// (set) Token: 0x0600040A RID: 1034
	public abstract int Stride { get; set; }

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x0600040B RID: 1035
	// (set) Token: 0x0600040C RID: 1036
	public abstract int BufferWidth { get; set; }

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x0600040D RID: 1037
	// (set) Token: 0x0600040E RID: 1038
	public abstract int BufferHeight { get; set; }

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600040F RID: 1039
	// (set) Token: 0x06000410 RID: 1040
	public abstract Image.PIXEL_FORMAT PixelFormat { get; set; }

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000411 RID: 1041
	// (set) Token: 0x06000412 RID: 1042
	public abstract byte[] Pixels { get; set; }

	// Token: 0x06000413 RID: 1043
	public abstract bool IsValid();

	// Token: 0x02000096 RID: 150
	public enum PIXEL_FORMAT
	{
		// Token: 0x0400039E RID: 926
		UNKNOWN_FORMAT,
		// Token: 0x0400039F RID: 927
		RGB565,
		// Token: 0x040003A0 RID: 928
		RGB888,
		// Token: 0x040003A1 RID: 929
		GRAYSCALE = 4,
		// Token: 0x040003A2 RID: 930
		YUV = 8,
		// Token: 0x040003A3 RID: 931
		RGBA8888 = 16
	}
}
