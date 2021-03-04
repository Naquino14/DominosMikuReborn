using System;
using UnityEngine;

// Token: 0x020000AF RID: 175
public class NullWebCamTexAdaptor : WebCamTexAdaptor
{
	// Token: 0x060004E7 RID: 1255 RVA: 0x000031FC File Offset: 0x000013FC
	public NullWebCamTexAdaptor(int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00003200 File Offset: 0x00001400
	public override bool DidUpdateThisFrame
	{
		get
		{
		}
	}

	// Token: 0x170000E5 RID: 229
	// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00003204 File Offset: 0x00001404
	public override bool IsPlaying
	{
		get
		{
		}
	}

	// Token: 0x170000E6 RID: 230
	// (get) Token: 0x060004EA RID: 1258 RVA: 0x00003208 File Offset: 0x00001408
	public override Texture Texture
	{
		get
		{
		}
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x0000320C File Offset: 0x0000140C
	public override void Play()
	{
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00003210 File Offset: 0x00001410
	public override void Stop()
	{
	}

	// Token: 0x040003D7 RID: 983
	private const string ERROR_MSG = "No camera connected!\nTo run your application using Play Mode, please connect a webcam to your computer.";

	// Token: 0x040003D8 RID: 984
	private readonly Texture2D mTexture;

	// Token: 0x040003D9 RID: 985
	private bool mPseudoPlaying;

	// Token: 0x040003DA RID: 986
	private readonly double mMsBetweenFrames;

	// Token: 0x040003DB RID: 987
	private DateTime mLastFrame;
}
