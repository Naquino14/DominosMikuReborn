using System.Collections.Generic;

public class CameraDeviceImpl : CameraDevice
{
	private Dictionary<Image.PIXEL_FORMAT, Image> mCameraImages;

	private static WebCamImpl mWebCam;

	private bool mCameraReady;

	private bool mIsDirty;

	public WebCamImpl WebCam => (WebCamImpl)/*Error near IL_0001: Stack underflow*/;

	public bool CameraReady => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override bool Init(CameraDirection cameraDirection)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool Deinit()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool Start()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool Stop()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override VideoModeData GetVideoMode(CameraDeviceMode mode)
	{
		return (VideoModeData)/*Error near IL_0001: Stack underflow*/;
	}

	public override bool SelectVideoMode(CameraDeviceMode mode)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool SetFlashTorchMode(bool on)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool SetFocusMode(FocusMode mode)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool SetFrameFormat(Image.PIXEL_FORMAT format, bool enabled)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override Image GetCameraImage(Image.PIXEL_FORMAT format)
	{
		return (Image)/*Error near IL_0001: Stack underflow*/;
	}

	public Dictionary<Image.PIXEL_FORMAT, Image> GetAllImages()
	{
		return (Dictionary<Image.PIXEL_FORMAT, Image>)/*Error near IL_0001: Stack underflow*/;
	}

	public bool IsDirty()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void ResetDirtyFlag()
	{
	}

	private int InitCameraDevice(int camera)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private int DeinitCameraDevice()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private int StartCameraDevice()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private int StopCameraDevice()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}
}
