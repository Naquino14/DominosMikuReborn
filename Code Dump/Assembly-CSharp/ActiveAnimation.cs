using System;
using AnimationOrTween;
using UnityEngine;

// Token: 0x02000037 RID: 55
[RequireComponent(typeof(Animation))]
[AddComponentMenu("NGUI/Internal/Active Animation")]
public class ActiveAnimation : IgnoreTimeScale
{
	// Token: 0x06000153 RID: 339 RVA: 0x00002598 File Offset: 0x00000798
	public void Reset()
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x0000259C File Offset: 0x0000079C
	private void Update()
	{
	}

	// Token: 0x06000155 RID: 341 RVA: 0x000025A0 File Offset: 0x000007A0
	private void Play(string clipName, Direction playDirection)
	{
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000025A4 File Offset: 0x000007A4
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x000025A8 File Offset: 0x000007A8
	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
	}

	// Token: 0x06000158 RID: 344 RVA: 0x000025AC File Offset: 0x000007AC
	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
	}

	// Token: 0x0400015C RID: 348
	public ActiveAnimation.OnFinished onFinished;

	// Token: 0x0400015D RID: 349
	public GameObject eventReceiver;

	// Token: 0x0400015E RID: 350
	public string callWhenFinished;

	// Token: 0x0400015F RID: 351
	private Animation mAnim;

	// Token: 0x04000160 RID: 352
	private Direction mLastDirection;

	// Token: 0x04000161 RID: 353
	private Direction mDisableDirection;

	// Token: 0x04000162 RID: 354
	private bool mNotify;

	// Token: 0x02000154 RID: 340
	// (Invoke) Token: 0x06000B45 RID: 2885
	public delegate void OnFinished(ActiveAnimation anim);
}
