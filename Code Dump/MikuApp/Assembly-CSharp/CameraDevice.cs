using System.Runtime.InteropServices;

public abstract class CameraDevice
{
	public enum CameraDeviceMode
	{
		MODE_DEFAULT = -1,
		MODE_OPTIMIZE_SPEED = -2,
		MODE_OPTIMIZE_QUALITY = -3
	}

	public enum FocusMode
	{
		FOCUS_MODE_NORMAL,
		FOCUS_MODE_TRIGGERAUTO,
		FOCUS_MODE_CONTINUOUSAUTO,
		FOCUS_MODE_INFINITY,
		FOCUS_MODE_MACRO
	}

	public enum CameraDirection
	{
		CAMERA_DEFAULT,
		CAMERA_BACK,
		CAMERA_FRONT
	}

	[StructLayout(0, Pack = 1)]
	public struct VideoModeData
	{
		public int width;

		public int height;

		public float frameRate;
	}

	private static CameraDevice mInstance;

	public static CameraDevice Instance => (CameraDevice)/*Error near IL_0001: Stack underflow*/;

	public abstract bool Init(CameraDirection cameraDirection);

	public abstract bool Deinit();

	public abstract bool Start();

	public abstract bool Stop();

	public abstract VideoModeData GetVideoMode(CameraDeviceMode mode);

	public abstract bool SelectVideoMode(CameraDeviceMode mode);

	public abstract bool SetFlashTorchMode(bool on);

	public abstract bool SetFocusMode(FocusMode mode);

	public abstract bool SetFrameFormat(Image.PIXEL_FORMAT format, bool enabled);

	public abstract Image GetCameraImage(Image.PIXEL_FORMAT format);
}
