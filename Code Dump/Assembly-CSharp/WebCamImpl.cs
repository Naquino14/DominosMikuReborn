using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000C2 RID: 194
public class WebCamImpl
{
	// Token: 0x06000555 RID: 1365 RVA: 0x000033B4 File Offset: 0x000015B4
	public WebCamImpl(Camera arCamera, Camera backgroundCamera, int renderTextureLayer, string webcamDeviceName, bool flipHorizontally)
	{
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000556 RID: 1366 RVA: 0x000033B8 File Offset: 0x000015B8
	public bool DidUpdateThisFrame
	{
		get
		{
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000557 RID: 1367 RVA: 0x000033BC File Offset: 0x000015BC
	public bool IsPlaying
	{
		get
		{
		}
	}

	// Token: 0x170000FA RID: 250
	// (get) Token: 0x06000558 RID: 1368 RVA: 0x000033C0 File Offset: 0x000015C0
	public int ActualWidth
	{
		get
		{
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000559 RID: 1369 RVA: 0x000033C4 File Offset: 0x000015C4
	public int ActualHeight
	{
		get
		{
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x0600055A RID: 1370 RVA: 0x000033C8 File Offset: 0x000015C8
	// (set) Token: 0x0600055B RID: 1371 RVA: 0x000033CC File Offset: 0x000015CC
	public bool IsTextureSizeAvailable
	{
		[CompilerGenerated]
		get
		{
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x0600055C RID: 1372 RVA: 0x000033D0 File Offset: 0x000015D0
	public bool FlipHorizontally
	{
		get
		{
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x0600055D RID: 1373 RVA: 0x000033D4 File Offset: 0x000015D4
	public QCARRenderer.Vec2I ResampledTextureSize
	{
		get
		{
		}
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x000033D8 File Offset: 0x000015D8
	private void RenderFrame(RenderTexture frameToDraw)
	{
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x000033DC File Offset: 0x000015DC
	public void StartCamera()
	{
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x000033E0 File Offset: 0x000015E0
	public void StopCamera()
	{
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x000033E4 File Offset: 0x000015E4
	public Color32[] GetPixels32AndBufferFrame(int frameIndex)
	{
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x000033E8 File Offset: 0x000015E8
	public void SetFrameIndex(int frameIndex)
	{
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x000033EC File Offset: 0x000015EC
	public CameraDevice.VideoModeData GetVideoMode()
	{
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x000033F0 File Offset: 0x000015F0
	public QCARRenderer.VideoTextureInfo GetVideoTextureInfo()
	{
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x000033F4 File Offset: 0x000015F4
	public bool IsRendererDirty()
	{
	}

	// Token: 0x0400041F RID: 1055
	private readonly Camera mARCamera;

	// Token: 0x04000420 RID: 1056
	private readonly BGRenderingBehaviour mBgRenderingTexBehaviour;

	// Token: 0x04000421 RID: 1057
	private readonly WebCamTexAdaptor mWebCamTexture;

	// Token: 0x04000422 RID: 1058
	private CameraDevice.VideoModeData mVideoModeData;

	// Token: 0x04000423 RID: 1059
	private QCARRenderer.VideoTextureInfo mVideoTextureInfo;

	// Token: 0x04000424 RID: 1060
	private TextureRenderer mTextureRenderer;

	// Token: 0x04000425 RID: 1061
	private Texture2D mBufferReadTexture;

	// Token: 0x04000426 RID: 1062
	private Rect mReadPixelsRect;

	// Token: 0x04000427 RID: 1063
	private readonly WebCamProfile.ProfileData mWebCamProfile;

	// Token: 0x04000428 RID: 1064
	private readonly bool mFlipHorizontally;

	// Token: 0x04000429 RID: 1065
	private int mLastScreenWidth;

	// Token: 0x0400042A RID: 1066
	private int mLastScreenHeight;

	// Token: 0x0400042B RID: 1067
	private readonly Queue<WebCamImpl.BufferedFrame> mBufferedFrames;

	// Token: 0x0400042C RID: 1068
	private int mLastFrameIdx;

	// Token: 0x0400042D RID: 1069
	private readonly int mRenderTextureLayer;

	// Token: 0x020000C3 RID: 195
	private struct BufferedFrame
	{
		// Token: 0x0400042F RID: 1071
		public int frameIndex;

		// Token: 0x04000430 RID: 1072
		public RenderTexture frame;
	}
}
