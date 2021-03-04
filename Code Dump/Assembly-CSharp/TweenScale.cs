using System;
using UnityEngine;

// Token: 0x02000058 RID: 88
[AddComponentMenu("NGUI/Tween/Scale")]
public class TweenScale : UITweener
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x0600026F RID: 623 RVA: 0x00002A08 File Offset: 0x00000C08
	public Transform cachedTransform
	{
		get
		{
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000270 RID: 624 RVA: 0x00002A0C File Offset: 0x00000C0C
	// (set) Token: 0x06000271 RID: 625 RVA: 0x00002A10 File Offset: 0x00000C10
	public Vector3 scale
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002A14 File Offset: 0x00000C14
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002A18 File Offset: 0x00000C18
	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
	}

	// Token: 0x04000220 RID: 544
	public Vector3 from;

	// Token: 0x04000221 RID: 545
	public Vector3 to;

	// Token: 0x04000222 RID: 546
	public bool updateTable;

	// Token: 0x04000223 RID: 547
	private Transform mTrans;

	// Token: 0x04000224 RID: 548
	private UITable mTable;
}
