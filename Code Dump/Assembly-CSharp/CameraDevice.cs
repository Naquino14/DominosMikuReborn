using System;
using System.Runtime.InteropServices;

// Token: 0x02000082 RID: 130
public abstract class CameraDevice
{
	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x00002F20 File Offset: 0x00001120
	public static CameraDevice Instance
	{
		get
		{
		}
	}

	// Token: 0x060003B7 RID: 951
	public abstract bool Init(CameraDevice.CameraDirection cameraDirection);

	// Token: 0x060003B8 RID: 952
	public abstract bool Deinit();

	// Token: 0x060003B9 RID: 953
	public abstract bool Start();

	// Token: 0x060003BA RID: 954
	public abstract bool Stop();

	// Token: 0x060003BB RID: 955
	public abstract CameraDevice.VideoModeData GetVideoMode(CameraDevice.CameraDeviceMode mode);

	// Token: 0x060003BC RID: 956
	public abstract bool SelectVideoMode(CameraDevice.CameraDeviceMode mode);

	// Token: 0x060003BD RID: 957
	public abstract bool SetFlashTorchMode(bool on);

	// Token: 0x060003BE RID: 958
	public abstract bool SetFocusMode(CameraDevice.FocusMode mode);

	// Token: 0x060003BF RID: 959
	public abstract bool SetFrameFormat(Image.PIXEL_FORMAT format, bool enabled);

	// Token: 0x060003C0 RID: 960
	public abstract Image GetCameraImage(Image.PIXEL_FORMAT format);

	// Token: 0x04000373 RID: 883
	private static CameraDevice mInstance;

	// Token: 0x02000083 RID: 131
	public enum CameraDeviceMode
	{
		// Token: 0x04000375 RID: 885
		MODE_DEFAULT = -1,
		// Token: 0x04000376 RID: 886
		MODE_OPTIMIZE_SPEED = -2,
		// Token: 0x04000377 RID: 887
		MODE_OPTIMIZE_QUALITY = -3
	}

	// Token: 0x02000084 RID: 132
	public enum FocusMode
	{
		// Token: 0x04000379 RID: 889
		FOCUS_MODE_NORMAL,
		// Token: 0x0400037A RID: 890
		FOCUS_MODE_TRIGGERAUTO,
		// Token: 0x0400037B RID: 891
		FOCUS_MODE_CONTINUOUSAUTO,
		// Token: 0x0400037C RID: 892
		FOCUS_MODE_INFINITY,
		// Token: 0x0400037D RID: 893
		FOCUS_MODE_MACRO
	}

	// Token: 0x02000085 RID: 133
	public enum CameraDirection
	{
		// Token: 0x0400037F RID: 895
		CAMERA_DEFAULT,
		// Token: 0x04000380 RID: 896
		CAMERA_BACK,
		// Token: 0x04000381 RID: 897
		CAMERA_FRONT
	}

	// Token: 0x02000086 RID: 134
	[StructLayout(0, Pack = 1)]
	public struct VideoModeData
	{
		// Token: 0x04000382 RID: 898
		public int width;

		// Token: 0x04000383 RID: 899
		public int height;

		// Token: 0x04000384 RID: 900
		public float frameRate;
	}
}
