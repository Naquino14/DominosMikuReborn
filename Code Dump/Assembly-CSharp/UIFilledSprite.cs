using System;
using UnityEngine;

// Token: 0x02000067 RID: 103
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite (Filled)")]
public class UIFilledSprite : UISprite
{
	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060002C8 RID: 712 RVA: 0x00002B68 File Offset: 0x00000D68
	// (set) Token: 0x060002C9 RID: 713 RVA: 0x00002B6C File Offset: 0x00000D6C
	public UIFilledSprite.FillDirection fillDirection
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060002CA RID: 714 RVA: 0x00002B70 File Offset: 0x00000D70
	// (set) Token: 0x060002CB RID: 715 RVA: 0x00002B74 File Offset: 0x00000D74
	public float fillAmount
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060002CC RID: 716 RVA: 0x00002B78 File Offset: 0x00000D78
	// (set) Token: 0x060002CD RID: 717 RVA: 0x00002B7C File Offset: 0x00000D7C
	public bool invert
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002B80 File Offset: 0x00000D80
	private bool AdjustRadial(Vector2[] xy, Vector2[] uv, float fill, bool invert)
	{
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002B84 File Offset: 0x00000D84
	private void Rotate(Vector2[] v, int offset)
	{
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00002B88 File Offset: 0x00000D88
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x040002A8 RID: 680
	[HideInInspector]
	[SerializeField]
	private UIFilledSprite.FillDirection mFillDirection;

	// Token: 0x040002A9 RID: 681
	[HideInInspector]
	[SerializeField]
	private float mFillAmount;

	// Token: 0x040002AA RID: 682
	[SerializeField]
	[HideInInspector]
	private bool mInvert;

	// Token: 0x02000068 RID: 104
	public enum FillDirection
	{
		// Token: 0x040002AC RID: 684
		Horizontal,
		// Token: 0x040002AD RID: 685
		Vertical,
		// Token: 0x040002AE RID: 686
		Radial90,
		// Token: 0x040002AF RID: 687
		Radial180,
		// Token: 0x040002B0 RID: 688
		Radial360
	}
}
