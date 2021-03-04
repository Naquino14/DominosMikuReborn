using System;
using UnityEngine;

// Token: 0x02000080 RID: 128
[AddComponentMenu("NGUI/UI/Tooltip")]
public class UITooltip : MonoBehaviour
{
	// Token: 0x060003AA RID: 938 RVA: 0x00002EF0 File Offset: 0x000010F0
	private void Awake()
	{
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00002EF4 File Offset: 0x000010F4
	private void OnDestroy()
	{
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00002EF8 File Offset: 0x000010F8
	private void Start()
	{
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00002EFC File Offset: 0x000010FC
	private void Update()
	{
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00002F00 File Offset: 0x00001100
	private void SetAlpha(float val)
	{
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002F04 File Offset: 0x00001104
	private void SetText(string tooltipText)
	{
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00002F08 File Offset: 0x00001108
	public static void ShowText(string tooltipText)
	{
	}

	// Token: 0x04000362 RID: 866
	private static UITooltip mInstance;

	// Token: 0x04000363 RID: 867
	public Camera uiCamera;

	// Token: 0x04000364 RID: 868
	public UILabel text;

	// Token: 0x04000365 RID: 869
	public UISlicedSprite background;

	// Token: 0x04000366 RID: 870
	public float appearSpeed;

	// Token: 0x04000367 RID: 871
	public bool scalingTransitions;

	// Token: 0x04000368 RID: 872
	private Transform mTrans;

	// Token: 0x04000369 RID: 873
	private float mTarget;

	// Token: 0x0400036A RID: 874
	private float mCurrent;

	// Token: 0x0400036B RID: 875
	private Vector3 mPos;

	// Token: 0x0400036C RID: 876
	private Vector3 mSize;

	// Token: 0x0400036D RID: 877
	private UIWidget[] mWidgets;
}
