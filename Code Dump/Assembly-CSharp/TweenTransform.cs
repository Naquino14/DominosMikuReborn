using System;
using UnityEngine;

// Token: 0x02000059 RID: 89
[AddComponentMenu("NGUI/Tween/Transform")]
public class TweenTransform : UITweener
{
	// Token: 0x06000275 RID: 629 RVA: 0x00002A20 File Offset: 0x00000C20
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002A24 File Offset: 0x00000C24
	public static TweenTransform Begin(GameObject go, float duration, Transform to)
	{
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002A28 File Offset: 0x00000C28
	public static TweenTransform Begin(GameObject go, float duration, Transform from, Transform to)
	{
	}

	// Token: 0x04000225 RID: 549
	public Transform from;

	// Token: 0x04000226 RID: 550
	public Transform to;

	// Token: 0x04000227 RID: 551
	public bool parentWhenFinished;

	// Token: 0x04000228 RID: 552
	private Transform mTrans;

	// Token: 0x04000229 RID: 553
	private Vector3 mPos;

	// Token: 0x0400022A RID: 554
	private Quaternion mRot;

	// Token: 0x0400022B RID: 555
	private Vector3 mScale;
}
