using System;

public class ImageImpl : Image
{
	private int mWidth;

	private int mHeight;

	private int mStride;

	private int mBufferWidth;

	private int mBufferHeight;

	private PIXEL_FORMAT mPixelFormat;

	private byte[] mData;

	private IntPtr mUnmanagedData;

	private bool mDataSet;

	public override int Width
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override int Height
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override int Stride
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override int BufferWidth
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override int BufferHeight
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override PIXEL_FORMAT PixelFormat
	{
		get
		{
			return (PIXEL_FORMAT)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public override byte[] Pixels
	{
		get
		{
			return (byte[])/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public unsafe IntPtr UnmanagedData
	{
		get
		{
			return (IntPtr)(void*)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	~ImageImpl()
	{
	}

	public override bool IsValid()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void CopyPixelsFromUnmanagedBuffer()
	{
	}
}
