using System;
using UnityEngine;

// Token: 0x0200005A RID: 90
[AddComponentMenu("NGUI/Tween/Volume")]
public class TweenVolume : UITweener
{
	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000279 RID: 633 RVA: 0x00002A30 File Offset: 0x00000C30
	public AudioSource audioSource
	{
		get
		{
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x0600027A RID: 634 RVA: 0x00002A34 File Offset: 0x00000C34
	// (set) Token: 0x0600027B RID: 635 RVA: 0x00002A38 File Offset: 0x00000C38
	public float volume
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002A3C File Offset: 0x00000C3C
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002A40 File Offset: 0x00000C40
	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
	}

	// Token: 0x0400022C RID: 556
	public float from;

	// Token: 0x0400022D RID: 557
	public float to;

	// Token: 0x0400022E RID: 558
	private AudioSource mSource;
}
