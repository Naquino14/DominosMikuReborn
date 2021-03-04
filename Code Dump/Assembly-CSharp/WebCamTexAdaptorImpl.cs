using System;
using UnityEngine;

// Token: 0x020000C7 RID: 199
public class WebCamTexAdaptorImpl : WebCamTexAdaptor
{
	// Token: 0x06000571 RID: 1393 RVA: 0x00003410 File Offset: 0x00001610
	public WebCamTexAdaptorImpl(string deviceName, int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000572 RID: 1394 RVA: 0x00003414 File Offset: 0x00001614
	public override bool DidUpdateThisFrame
	{
		get
		{
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06000573 RID: 1395 RVA: 0x00003418 File Offset: 0x00001618
	public override bool IsPlaying
	{
		get
		{
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06000574 RID: 1396 RVA: 0x0000341C File Offset: 0x0000161C
	public override Texture Texture
	{
		get
		{
		}
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x00003420 File Offset: 0x00001620
	public override void Play()
	{
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x00003424 File Offset: 0x00001624
	public override void Stop()
	{
	}

	// Token: 0x04000436 RID: 1078
	private WebCamTexture mWebCamTexture;
}
