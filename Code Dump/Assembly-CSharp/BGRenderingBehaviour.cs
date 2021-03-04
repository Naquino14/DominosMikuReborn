using System;
using UnityEngine;

// Token: 0x0200009E RID: 158
public class BGRenderingBehaviour : MonoBehaviour
{
	// Token: 0x0600043F RID: 1087 RVA: 0x00003028 File Offset: 0x00001228
	public void CheckAndSetActive(bool isActive)
	{
	}

	// Token: 0x06000440 RID: 1088 RVA: 0x0000302C File Offset: 0x0000122C
	public void SetTexture(Texture texture)
	{
	}

	// Token: 0x06000441 RID: 1089 RVA: 0x00003030 File Offset: 0x00001230
	public void SetFlipHorizontally(bool flip)
	{
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00003034 File Offset: 0x00001234
	private void Start()
	{
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00003038 File Offset: 0x00001238
	private void Update()
	{
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x0000303C File Offset: 0x0000123C
	private Mesh CreateVideoMesh()
	{
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00003040 File Offset: 0x00001240
	private void PositionVideoMesh()
	{
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00003044 File Offset: 0x00001244
	private bool ShouldFitWidth()
	{
	}

	// Token: 0x040003B3 RID: 947
	public Camera Camera;

	// Token: 0x040003B4 RID: 948
	private QCARRenderer.VideoTextureInfo mTextureInfo;

	// Token: 0x040003B5 RID: 949
	private ScreenOrientation mScreenOrientation;

	// Token: 0x040003B6 RID: 950
	private int mScreenWidth;

	// Token: 0x040003B7 RID: 951
	private int mScreenHeight;

	// Token: 0x040003B8 RID: 952
	private bool mFlipHorizontally;
}
