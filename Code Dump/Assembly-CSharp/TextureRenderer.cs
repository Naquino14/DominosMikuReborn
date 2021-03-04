using System;
using UnityEngine;

// Token: 0x020000BD RID: 189
public class TextureRenderer
{
	// Token: 0x06000539 RID: 1337 RVA: 0x00003344 File Offset: 0x00001544
	public TextureRenderer(Texture textureToRender, int renderTextureLayer, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x0600053A RID: 1338 RVA: 0x00003348 File Offset: 0x00001548
	public int Width
	{
		get
		{
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x0600053B RID: 1339 RVA: 0x0000334C File Offset: 0x0000154C
	public int Height
	{
		get
		{
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x00003350 File Offset: 0x00001550
	public RenderTexture Render()
	{
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x00003354 File Offset: 0x00001554
	public void Destroy()
	{
	}

	// Token: 0x0400040F RID: 1039
	private Camera mTextureBufferCamera;

	// Token: 0x04000410 RID: 1040
	private int mTextureWidth;

	// Token: 0x04000411 RID: 1041
	private int mTextureHeight;
}
