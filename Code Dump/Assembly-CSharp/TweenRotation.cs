using System;
using UnityEngine;

// Token: 0x02000057 RID: 87
[AddComponentMenu("NGUI/Tween/Rotation")]
public class TweenRotation : UITweener
{
	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000269 RID: 617 RVA: 0x000029F0 File Offset: 0x00000BF0
	public Transform cachedTransform
	{
		get
		{
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x0600026A RID: 618 RVA: 0x000029F4 File Offset: 0x00000BF4
	// (set) Token: 0x0600026B RID: 619 RVA: 0x000029F8 File Offset: 0x00000BF8
	public Quaternion rotation
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x000029FC File Offset: 0x00000BFC
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002A00 File Offset: 0x00000C00
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
	}

	// Token: 0x0400021D RID: 541
	public Vector3 from;

	// Token: 0x0400021E RID: 542
	public Vector3 to;

	// Token: 0x0400021F RID: 543
	private Transform mTrans;
}
