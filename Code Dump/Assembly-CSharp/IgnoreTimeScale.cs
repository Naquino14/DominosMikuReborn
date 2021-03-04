using System;
using UnityEngine;

// Token: 0x02000042 RID: 66
[AddComponentMenu("NGUI/Internal/Ignore TimeScale Behaviour")]
public class IgnoreTimeScale : MonoBehaviour
{
	// Token: 0x1700002B RID: 43
	// (get) Token: 0x0600018B RID: 395 RVA: 0x00002678 File Offset: 0x00000878
	public float realTimeDelta
	{
		get
		{
		}
	}

	// Token: 0x0600018C RID: 396 RVA: 0x0000267C File Offset: 0x0000087C
	protected virtual void OnEnable()
	{
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00002680 File Offset: 0x00000880
	protected float UpdateRealTimeDelta()
	{
	}

	// Token: 0x0400019C RID: 412
	private float mTimeStart;

	// Token: 0x0400019D RID: 413
	private float mTimeDelta;

	// Token: 0x0400019E RID: 414
	private float mActual;

	// Token: 0x0400019F RID: 415
	private bool mTimeStarted;
}
