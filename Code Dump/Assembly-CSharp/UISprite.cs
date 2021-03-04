using System;
using UnityEngine;

// Token: 0x02000077 RID: 119
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Basic)")]
public class UISprite : UIWidget
{
	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600036E RID: 878 RVA: 0x00002E00 File Offset: 0x00001000
	public Rect outerUV
	{
		get
		{
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600036F RID: 879 RVA: 0x00002E04 File Offset: 0x00001004
	// (set) Token: 0x06000370 RID: 880 RVA: 0x00002E08 File Offset: 0x00001008
	public UIAtlas atlas
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000371 RID: 881 RVA: 0x00002E0C File Offset: 0x0000100C
	// (set) Token: 0x06000372 RID: 882 RVA: 0x00002E10 File Offset: 0x00001010
	public string spriteName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000373 RID: 883 RVA: 0x00002E14 File Offset: 0x00001014
	// (set) Token: 0x06000374 RID: 884 RVA: 0x00002E18 File Offset: 0x00001018
	public UIAtlas.Sprite sprite
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000375 RID: 885 RVA: 0x00002E1C File Offset: 0x0000101C
	public override Vector2 pivotOffset
	{
		get
		{
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000376 RID: 886 RVA: 0x00002E20 File Offset: 0x00001020
	public override Material material
	{
		get
		{
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000377 RID: 887 RVA: 0x00002E24 File Offset: 0x00001024
	public virtual Vector4 border
	{
		get
		{
		}
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00002E28 File Offset: 0x00001028
	public virtual void UpdateUVs(bool force)
	{
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00002E2C File Offset: 0x0000102C
	public override void MakePixelPerfect()
	{
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00002E30 File Offset: 0x00001030
	protected override void OnStart()
	{
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00002E34 File Offset: 0x00001034
	public override bool OnUpdate()
	{
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002E38 File Offset: 0x00001038
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x04000330 RID: 816
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	// Token: 0x04000331 RID: 817
	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	// Token: 0x04000332 RID: 818
	protected UIAtlas.Sprite mSprite;

	// Token: 0x04000333 RID: 819
	protected Rect mOuter;

	// Token: 0x04000334 RID: 820
	protected Rect mOuterUV;

	// Token: 0x04000335 RID: 821
	private bool mSpriteSet;

	// Token: 0x04000336 RID: 822
	private string mLastName;
}
