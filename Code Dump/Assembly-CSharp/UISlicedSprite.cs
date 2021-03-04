using System;
using UnityEngine;

// Token: 0x02000076 RID: 118
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Sliced)")]
public class UISlicedSprite : UISprite
{
	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000365 RID: 869 RVA: 0x00002DDC File Offset: 0x00000FDC
	public Rect innerUV
	{
		get
		{
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000366 RID: 870 RVA: 0x00002DE0 File Offset: 0x00000FE0
	// (set) Token: 0x06000367 RID: 871 RVA: 0x00002DE4 File Offset: 0x00000FE4
	public bool fillCenter
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000368 RID: 872 RVA: 0x00002DE8 File Offset: 0x00000FE8
	public override Vector4 border
	{
		get
		{
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000369 RID: 873 RVA: 0x00002DEC File Offset: 0x00000FEC
	public override Vector2 pivotOffset
	{
		get
		{
		}
	}

	// Token: 0x0600036A RID: 874 RVA: 0x00002DF0 File Offset: 0x00000FF0
	public override void UpdateUVs(bool force)
	{
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00002DF4 File Offset: 0x00000FF4
	public override void MakePixelPerfect()
	{
	}

	// Token: 0x0600036C RID: 876 RVA: 0x00002DF8 File Offset: 0x00000FF8
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x0400032C RID: 812
	[SerializeField]
	[HideInInspector]
	private bool mFillCenter;

	// Token: 0x0400032D RID: 813
	protected Rect mInner;

	// Token: 0x0400032E RID: 814
	protected Rect mInnerUV;

	// Token: 0x0400032F RID: 815
	protected Vector3 mScale;
}
