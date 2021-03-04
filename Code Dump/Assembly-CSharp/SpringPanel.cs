using System;
using UnityEngine;

// Token: 0x02000047 RID: 71
[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Internal/Spring Panel")]
public class SpringPanel : IgnoreTimeScale
{
	// Token: 0x060001E8 RID: 488 RVA: 0x000027EC File Offset: 0x000009EC
	private void Start()
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x000027F0 File Offset: 0x000009F0
	private void Update()
	{
	}

	// Token: 0x060001EA RID: 490 RVA: 0x000027F4 File Offset: 0x000009F4
	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
	}

	// Token: 0x040001AA RID: 426
	public Vector3 target;

	// Token: 0x040001AB RID: 427
	public float strength;

	// Token: 0x040001AC RID: 428
	public SpringPanel.OnFinished onFinished;

	// Token: 0x040001AD RID: 429
	private UIPanel mPanel;

	// Token: 0x040001AE RID: 430
	private Transform mTrans;

	// Token: 0x040001AF RID: 431
	private float mThreshold;

	// Token: 0x040001B0 RID: 432
	private UIDraggablePanel mDrag;

	// Token: 0x02000155 RID: 341
	// (Invoke) Token: 0x06000B49 RID: 2889
	public delegate void OnFinished();
}
