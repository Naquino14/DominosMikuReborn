using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000B7 RID: 183
public class QCARRendererImpl : QCARRenderer
{
	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000502 RID: 1282 RVA: 0x00003268 File Offset: 0x00001468
	// (set) Token: 0x06000501 RID: 1281 RVA: 0x00003264 File Offset: 0x00001464
	public override bool DrawVideoBackground
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000504 RID: 1284 RVA: 0x00003270 File Offset: 0x00001470
	// (set) Token: 0x06000503 RID: 1283 RVA: 0x0000326C File Offset: 0x0000146C
	public Texture2D VideoBackgroundForEmulator
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

	// Token: 0x06000505 RID: 1285 RVA: 0x00003274 File Offset: 0x00001474
	public override QCARRenderer.VideoBGCfgData GetVideoBackgroundConfig()
	{
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00003278 File Offset: 0x00001478
	public override void ClearVideoBackgroundConfig()
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x0000327C File Offset: 0x0000147C
	public override void SetVideoBackgroundConfig(QCARRenderer.VideoBGCfgData config)
	{
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x00003280 File Offset: 0x00001480
	public override bool SetVideoBackgroundTexture(Texture2D texture)
	{
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x00003284 File Offset: 0x00001484
	public override bool IsVideoBackgroundInfoAvailable()
	{
	}

	// Token: 0x0600050A RID: 1290 RVA: 0x00003288 File Offset: 0x00001488
	public override QCARRenderer.VideoTextureInfo GetVideoTextureInfo()
	{
	}

	// Token: 0x040003FD RID: 1021
	private QCARRenderer.VideoBGCfgData mVideoBGConfig;

	// Token: 0x040003FE RID: 1022
	private bool mVideoBGConfigSet;
}
