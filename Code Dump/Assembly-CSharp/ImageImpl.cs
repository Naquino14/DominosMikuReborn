using System;

// Token: 0x020000A8 RID: 168
public class ImageImpl : Image
{
	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00003100 File Offset: 0x00001300
	// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00003104 File Offset: 0x00001304
	public override int Width
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x060004AA RID: 1194 RVA: 0x00003108 File Offset: 0x00001308
	// (set) Token: 0x060004AB RID: 1195 RVA: 0x0000310C File Offset: 0x0000130C
	public override int Height
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000DA RID: 218
	// (get) Token: 0x060004AC RID: 1196 RVA: 0x00003110 File Offset: 0x00001310
	// (set) Token: 0x060004AD RID: 1197 RVA: 0x00003114 File Offset: 0x00001314
	public override int Stride
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x060004AE RID: 1198 RVA: 0x00003118 File Offset: 0x00001318
	// (set) Token: 0x060004AF RID: 1199 RVA: 0x0000311C File Offset: 0x0000131C
	public override int BufferWidth
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00003120 File Offset: 0x00001320
	// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00003124 File Offset: 0x00001324
	public override int BufferHeight
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000DD RID: 221
	// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00003128 File Offset: 0x00001328
	// (set) Token: 0x060004B3 RID: 1203 RVA: 0x0000312C File Offset: 0x0000132C
	public override Image.PIXEL_FORMAT PixelFormat
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000DE RID: 222
	// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00003130 File Offset: 0x00001330
	// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00003134 File Offset: 0x00001334
	public override byte[] Pixels
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000DF RID: 223
	// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00003138 File Offset: 0x00001338
	// (set) Token: 0x060004B7 RID: 1207 RVA: 0x0000313C File Offset: 0x0000133C
	public IntPtr UnmanagedData
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00003140 File Offset: 0x00001340
	protected override void Finalize()
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00003144 File Offset: 0x00001344
	public override bool IsValid()
	{
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00003148 File Offset: 0x00001348
	public void CopyPixelsFromUnmanagedBuffer()
	{
	}

	// Token: 0x040003C2 RID: 962
	private int mWidth;

	// Token: 0x040003C3 RID: 963
	private int mHeight;

	// Token: 0x040003C4 RID: 964
	private int mStride;

	// Token: 0x040003C5 RID: 965
	private int mBufferWidth;

	// Token: 0x040003C6 RID: 966
	private int mBufferHeight;

	// Token: 0x040003C7 RID: 967
	private Image.PIXEL_FORMAT mPixelFormat;

	// Token: 0x040003C8 RID: 968
	private byte[] mData;

	// Token: 0x040003C9 RID: 969
	private IntPtr mUnmanagedData;

	// Token: 0x040003CA RID: 970
	private bool mDataSet;
}
