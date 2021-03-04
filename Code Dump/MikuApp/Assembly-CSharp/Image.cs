public abstract class Image
{
	public enum PIXEL_FORMAT
	{
		UNKNOWN_FORMAT = 0,
		RGB565 = 1,
		RGB888 = 2,
		GRAYSCALE = 4,
		YUV = 8,
		RGBA8888 = 0x10
	}

	public abstract int Width
	{
		get;
		set;
	}

	public abstract int Height
	{
		get;
		set;
	}

	public abstract int Stride
	{
		get;
		set;
	}

	public abstract int BufferWidth
	{
		get;
		set;
	}

	public abstract int BufferHeight
	{
		get;
		set;
	}

	public abstract PIXEL_FORMAT PixelFormat
	{
		get;
		set;
	}

	public abstract byte[] Pixels
	{
		get;
		set;
	}

	public abstract bool IsValid();
}
