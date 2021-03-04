using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WebCamImpl
{
	private struct BufferedFrame
	{
		public int frameIndex;

		public RenderTexture frame;
	}

	private readonly Camera mARCamera;

	private readonly BGRenderingBehaviour mBgRenderingTexBehaviour;

	private readonly WebCamTexAdaptor mWebCamTexture;

	private CameraDevice.VideoModeData mVideoModeData;

	private QCARRenderer.VideoTextureInfo mVideoTextureInfo;

	private TextureRenderer mTextureRenderer;

	private Texture2D mBufferReadTexture;

	private Rect mReadPixelsRect;

	private readonly WebCamProfile.ProfileData mWebCamProfile;

	private readonly bool mFlipHorizontally;

	private int mLastScreenWidth;

	private int mLastScreenHeight;

	private readonly Queue<BufferedFrame> mBufferedFrames;

	private int mLastFrameIdx;

	private readonly int mRenderTextureLayer;

	public bool DidUpdateThisFrame => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public bool IsPlaying => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public int ActualWidth => (int)/*Error near IL_0001: Stack underflow*/;

	public int ActualHeight => (int)/*Error near IL_0001: Stack underflow*/;

	public bool IsTextureSizeAvailable
	{
		[CompilerGenerated]
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool FlipHorizontally => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public QCARRenderer.Vec2I ResampledTextureSize => (QCARRenderer.Vec2I)/*Error near IL_0001: Stack underflow*/;

	public WebCamImpl(Camera arCamera, Camera backgroundCamera, int renderTextureLayer, string webcamDeviceName, bool flipHorizontally)
	{
	}

	private void RenderFrame(RenderTexture frameToDraw)
	{
	}

	public void StartCamera()
	{
	}

	public void StopCamera()
	{
	}

	public Color32[] GetPixels32AndBufferFrame(int frameIndex)
	{
		return (Color32[])/*Error near IL_0001: Stack underflow*/;
	}

	public void SetFrameIndex(int frameIndex)
	{
	}

	public CameraDevice.VideoModeData GetVideoMode()
	{
		return (CameraDevice.VideoModeData)/*Error near IL_0001: Stack underflow*/;
	}

	public QCARRenderer.VideoTextureInfo GetVideoTextureInfo()
	{
		return (QCARRenderer.VideoTextureInfo)/*Error near IL_0001: Stack underflow*/;
	}

	public bool IsRendererDirty()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
