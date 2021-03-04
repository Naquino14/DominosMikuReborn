using System;
using UnityEngine;

// Token: 0x02000054 RID: 84
[AddComponentMenu("NGUI/Tween/Color")]
public class TweenColor : UITweener
{
	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000257 RID: 599 RVA: 0x000029A8 File Offset: 0x00000BA8
	// (set) Token: 0x06000258 RID: 600 RVA: 0x000029AC File Offset: 0x00000BAC
	public Color color
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x000029B0 File Offset: 0x00000BB0
	private void Awake()
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x000029B4 File Offset: 0x00000BB4
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x000029B8 File Offset: 0x00000BB8
	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
	}

	// Token: 0x04000211 RID: 529
	public Color from;

	// Token: 0x04000212 RID: 530
	public Color to;

	// Token: 0x04000213 RID: 531
	private Transform mTrans;

	// Token: 0x04000214 RID: 532
	private UIWidget mWidget;

	// Token: 0x04000215 RID: 533
	private Material mMat;

	// Token: 0x04000216 RID: 534
	private Light mLight;
}
