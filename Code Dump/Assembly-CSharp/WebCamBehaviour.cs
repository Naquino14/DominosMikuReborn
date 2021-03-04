using System;
using UnityEngine;

// Token: 0x020000F5 RID: 245
[RequireComponent(typeof(Camera))]
public class WebCamBehaviour : MonoBehaviour
{
	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x00003910 File Offset: 0x00001B10
	// (set) Token: 0x06000785 RID: 1925 RVA: 0x00003914 File Offset: 0x00001B14
	public string DeviceName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06000786 RID: 1926 RVA: 0x00003918 File Offset: 0x00001B18
	public WebCamImpl ImplementationClass
	{
		get
		{
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06000787 RID: 1927 RVA: 0x0000391C File Offset: 0x00001B1C
	// (set) Token: 0x06000788 RID: 1928 RVA: 0x00003920 File Offset: 0x00001B20
	public bool FlipHorizontally
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06000789 RID: 1929 RVA: 0x00003924 File Offset: 0x00001B24
	// (set) Token: 0x0600078A RID: 1930 RVA: 0x00003928 File Offset: 0x00001B28
	public bool TurnOffWebCam
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x0600078B RID: 1931 RVA: 0x0000392C File Offset: 0x00001B2C
	public bool IsPlaying
	{
		get
		{
		}
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00003930 File Offset: 0x00001B30
	public void InitCamera()
	{
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00003934 File Offset: 0x00001B34
	public void StartCamera()
	{
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00003938 File Offset: 0x00001B38
	public void StopCamera()
	{
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x0000393C File Offset: 0x00001B3C
	public bool CheckNativePluginSupport()
	{
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00003940 File Offset: 0x00001B40
	public bool IsWebCamUsed()
	{
	}

	// Token: 0x040004C4 RID: 1220
	public Camera BackgroundCameraPrefab;

	// Token: 0x040004C5 RID: 1221
	public int RenderTextureLayer;

	// Token: 0x040004C6 RID: 1222
	[HideInInspector]
	[SerializeField]
	private string mDeviceNameSetInEditor;

	// Token: 0x040004C7 RID: 1223
	[HideInInspector]
	[SerializeField]
	private bool mFlipHorizontally;

	// Token: 0x040004C8 RID: 1224
	[SerializeField]
	[HideInInspector]
	private bool mTurnOffWebCam;

	// Token: 0x040004C9 RID: 1225
	private WebCamImpl mWebCamImpl;

	// Token: 0x040004CA RID: 1226
	private Camera mBackgroundCameraInstance;
}
