using System;
using AnimationOrTween;
using UnityEngine;

// Token: 0x0200005B RID: 91
public abstract class UITweener : IgnoreTimeScale
{
	// Token: 0x17000052 RID: 82
	// (get) Token: 0x0600027F RID: 639 RVA: 0x00002A48 File Offset: 0x00000C48
	public float amountPerDelta
	{
		get
		{
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000280 RID: 640 RVA: 0x00002A4C File Offset: 0x00000C4C
	public float tweenFactor
	{
		get
		{
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000281 RID: 641 RVA: 0x00002A50 File Offset: 0x00000C50
	public Direction direction
	{
		get
		{
		}
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002A54 File Offset: 0x00000C54
	protected override void OnEnable()
	{
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002A58 File Offset: 0x00000C58
	private void Start()
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002A5C File Offset: 0x00000C5C
	private void Update()
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002A60 File Offset: 0x00000C60
	public void Sample(float factor, bool isFinished)
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002A64 File Offset: 0x00000C64
	private float BounceLogic(float val)
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002A68 File Offset: 0x00000C68
	public void Play(bool forward)
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002A6C File Offset: 0x00000C6C
	public void Reset()
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002A70 File Offset: 0x00000C70
	public void Toggle()
	{
	}

	// Token: 0x0600028A RID: 650
	protected abstract void OnUpdate(float factor, bool isFinished);

	// Token: 0x0600028B RID: 651 RVA: 0x00002A74 File Offset: 0x00000C74
	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
	}

	// Token: 0x0400022F RID: 559
	public UITweener.OnFinished onFinished;

	// Token: 0x04000230 RID: 560
	public UITweener.Method method;

	// Token: 0x04000231 RID: 561
	public UITweener.Style style;

	// Token: 0x04000232 RID: 562
	public bool ignoreTimeScale;

	// Token: 0x04000233 RID: 563
	public float delay;

	// Token: 0x04000234 RID: 564
	public float duration;

	// Token: 0x04000235 RID: 565
	public bool steeperCurves;

	// Token: 0x04000236 RID: 566
	public int tweenGroup;

	// Token: 0x04000237 RID: 567
	public GameObject eventReceiver;

	// Token: 0x04000238 RID: 568
	public string callWhenFinished;

	// Token: 0x04000239 RID: 569
	private float mStartTime;

	// Token: 0x0400023A RID: 570
	private float mDuration;

	// Token: 0x0400023B RID: 571
	private float mAmountPerDelta;

	// Token: 0x0400023C RID: 572
	private float mFactor;

	// Token: 0x0200005C RID: 92
	public enum Method
	{
		// Token: 0x0400023E RID: 574
		Linear,
		// Token: 0x0400023F RID: 575
		EaseIn,
		// Token: 0x04000240 RID: 576
		EaseOut,
		// Token: 0x04000241 RID: 577
		EaseInOut,
		// Token: 0x04000242 RID: 578
		BounceIn,
		// Token: 0x04000243 RID: 579
		BounceOut
	}

	// Token: 0x0200005D RID: 93
	public enum Style
	{
		// Token: 0x04000245 RID: 581
		Once,
		// Token: 0x04000246 RID: 582
		Loop,
		// Token: 0x04000247 RID: 583
		PingPong
	}

	// Token: 0x0200015F RID: 351
	// (Invoke) Token: 0x06000B71 RID: 2929
	public delegate void OnFinished(UITweener tween);
}
