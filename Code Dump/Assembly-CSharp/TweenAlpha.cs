using System;
using UnityEngine;

// Token: 0x02000053 RID: 83
[AddComponentMenu("NGUI/Tween/Alpha")]
public class TweenAlpha : UITweener
{
	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000251 RID: 593 RVA: 0x00002990 File Offset: 0x00000B90
	// (set) Token: 0x06000252 RID: 594 RVA: 0x00002994 File Offset: 0x00000B94
	public float alpha
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002998 File Offset: 0x00000B98
	private void Awake()
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0000299C File Offset: 0x00000B9C
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x06000255 RID: 597 RVA: 0x000029A0 File Offset: 0x00000BA0
	public static TweenAlpha Begin(GameObject go, float duration, float alpha)
	{
	}

	// Token: 0x0400020D RID: 525
	public float from;

	// Token: 0x0400020E RID: 526
	public float to;

	// Token: 0x0400020F RID: 527
	private Transform mTrans;

	// Token: 0x04000210 RID: 528
	private UIWidget mWidget;
}
