using System;
using UnityEngine;

// Token: 0x0200007F RID: 127
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Tiled)")]
public class UITiledSprite : UISlicedSprite
{
	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060003A6 RID: 934 RVA: 0x00002EE0 File Offset: 0x000010E0
	public override Vector4 border
	{
		get
		{
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00002EE4 File Offset: 0x000010E4
	public override void MakePixelPerfect()
	{
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00002EE8 File Offset: 0x000010E8
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
