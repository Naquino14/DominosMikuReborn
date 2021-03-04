using System;
using UnityEngine;

// Token: 0x02000056 RID: 86
[AddComponentMenu("NGUI/Tween/Position")]
public class TweenPosition : UITweener
{
	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000263 RID: 611 RVA: 0x000029D8 File Offset: 0x00000BD8
	public Transform cachedTransform
	{
		get
		{
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000264 RID: 612 RVA: 0x000029DC File Offset: 0x00000BDC
	// (set) Token: 0x06000265 RID: 613 RVA: 0x000029E0 File Offset: 0x00000BE0
	public Vector3 position
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000266 RID: 614 RVA: 0x000029E4 File Offset: 0x00000BE4
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x06000267 RID: 615 RVA: 0x000029E8 File Offset: 0x00000BE8
	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
	}

	// Token: 0x0400021A RID: 538
	public Vector3 from;

	// Token: 0x0400021B RID: 539
	public Vector3 to;

	// Token: 0x0400021C RID: 540
	private Transform mTrans;
}
