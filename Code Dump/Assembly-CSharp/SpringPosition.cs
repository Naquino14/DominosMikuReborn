using System;
using UnityEngine;

// Token: 0x02000052 RID: 82
[AddComponentMenu("NGUI/Tween/Spring Position")]
public class SpringPosition : IgnoreTimeScale
{
	// Token: 0x0600024D RID: 589 RVA: 0x00002980 File Offset: 0x00000B80
	private void Start()
	{
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00002984 File Offset: 0x00000B84
	private void Update()
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002988 File Offset: 0x00000B88
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
	}

	// Token: 0x04000204 RID: 516
	public Vector3 target;

	// Token: 0x04000205 RID: 517
	public float strength;

	// Token: 0x04000206 RID: 518
	public bool worldSpace;

	// Token: 0x04000207 RID: 519
	public bool ignoreTimeScale;

	// Token: 0x04000208 RID: 520
	public GameObject eventReceiver;

	// Token: 0x04000209 RID: 521
	public string callWhenFinished;

	// Token: 0x0400020A RID: 522
	public SpringPosition.OnFinished onFinished;

	// Token: 0x0400020B RID: 523
	private Transform mTrans;

	// Token: 0x0400020C RID: 524
	private float mThreshold;

	// Token: 0x0200015E RID: 350
	// (Invoke) Token: 0x06000B6D RID: 2925
	public delegate void OnFinished(SpringPosition spring);
}
