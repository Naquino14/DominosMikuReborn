using System;
using UnityEngine;

// Token: 0x0200004B RID: 75
public class UIGeometry
{
	// Token: 0x17000037 RID: 55
	// (get) Token: 0x0600020B RID: 523 RVA: 0x00002878 File Offset: 0x00000A78
	public bool hasVertices
	{
		get
		{
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x0600020C RID: 524 RVA: 0x0000287C File Offset: 0x00000A7C
	public bool hasTransformed
	{
		get
		{
		}
	}

	// Token: 0x0600020D RID: 525 RVA: 0x00002880 File Offset: 0x00000A80
	public void Clear()
	{
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00002884 File Offset: 0x00000A84
	public void ApplyOffset(Vector3 pivotOffset)
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002888 File Offset: 0x00000A88
	public void ApplyTransform(Matrix4x4 widgetToPanel, bool normals)
	{
	}

	// Token: 0x06000210 RID: 528 RVA: 0x0000288C File Offset: 0x00000A8C
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	// Token: 0x040001D1 RID: 465
	public BetterList<Vector3> verts;

	// Token: 0x040001D2 RID: 466
	public BetterList<Vector2> uvs;

	// Token: 0x040001D3 RID: 467
	public BetterList<Color32> cols;

	// Token: 0x040001D4 RID: 468
	private BetterList<Vector3> mRtpVerts;

	// Token: 0x040001D5 RID: 469
	private Vector3 mRtpNormal;

	// Token: 0x040001D6 RID: 470
	private Vector4 mRtpTan;
}
