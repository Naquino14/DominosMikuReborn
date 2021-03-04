using System;
using System.Collections.Generic;

// Token: 0x0200009F RID: 159
public class CameraDeviceImpl : CameraDevice
{
	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000449 RID: 1097 RVA: 0x00003050 File Offset: 0x00001250
	public WebCamImpl WebCam
	{
		get
		{
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x0600044A RID: 1098 RVA: 0x00003054 File Offset: 0x00001254
	public bool CameraReady
	{
		get
		{
		}
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00003058 File Offset: 0x00001258
	public override bool Init(CameraDevice.CameraDirection cameraDirection)
	{
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x0000305C File Offset: 0x0000125C
	public override bool Deinit()
	{
	}

	// Token: 0x0600044D RID: 1101 RVA: 0x00003060 File Offset: 0x00001260
	public override bool Start()
	{
	}

	// Token: 0x0600044E RID: 1102 RVA: 0x00003064 File Offset: 0x00001264
	public override bool Stop()
	{
	}

	// Token: 0x0600044F RID: 1103 RVA: 0x00003068 File Offset: 0x00001268
	public override CameraDevice.VideoModeData GetVideoMode(CameraDevice.CameraDeviceMode mode)
	{
	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0000306C File Offset: 0x0000126C
	public override bool SelectVideoMode(CameraDevice.CameraDeviceMode mode)
	{
	}

	// Token: 0x06000451 RID: 1105 RVA: 0x00003070 File Offset: 0x00001270
	public override bool SetFlashTorchMode(bool on)
	{
	}

	// Token: 0x06000452 RID: 1106 RVA: 0x00003074 File Offset: 0x00001274
	public override bool SetFocusMode(CameraDevice.FocusMode mode)
	{
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00003078 File Offset: 0x00001278
	public override bool SetFrameFormat(Image.PIXEL_FORMAT format, bool enabled)
	{
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x0000307C File Offset: 0x0000127C
	public override Image GetCameraImage(Image.PIXEL_FORMAT format)
	{
	}

	// Token: 0x06000455 RID: 1109 RVA: 0x00003080 File Offset: 0x00001280
	public Dictionary<Image.PIXEL_FORMAT, Image> GetAllImages()
	{
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00003084 File Offset: 0x00001284
	public bool IsDirty()
	{
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x00003088 File Offset: 0x00001288
	public void ResetDirtyFlag()
	{
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x0000308C File Offset: 0x0000128C
	private int InitCameraDevice(int camera)
	{
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x00003090 File Offset: 0x00001290
	private int DeinitCameraDevice()
	{
	}

	// Token: 0x0600045A RID: 1114 RVA: 0x00003094 File Offset: 0x00001294
	private int StartCameraDevice()
	{
	}

	// Token: 0x0600045B RID: 1115 RVA: 0x00003098 File Offset: 0x00001298
	private int StopCameraDevice()
	{
	}

	// Token: 0x040003B9 RID: 953
	private Dictionary<Image.PIXEL_FORMAT, Image> mCameraImages;

	// Token: 0x040003BA RID: 954
	private static WebCamImpl mWebCam;

	// Token: 0x040003BB RID: 955
	private bool mCameraReady;

	// Token: 0x040003BC RID: 956
	private bool mIsDirty;
}
