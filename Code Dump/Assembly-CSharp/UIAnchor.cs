using System;
using UnityEngine;

// Token: 0x0200005E RID: 94
[AddComponentMenu("NGUI/UI/Anchor")]
[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	// Token: 0x0600028D RID: 653 RVA: 0x00002A7C File Offset: 0x00000C7C
	private void Awake()
	{
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002A80 File Offset: 0x00000C80
	private void Start()
	{
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002A84 File Offset: 0x00000C84
	private void Update()
	{
	}

	// Token: 0x04000248 RID: 584
	private bool mIsWindows;

	// Token: 0x04000249 RID: 585
	public Camera uiCamera;

	// Token: 0x0400024A RID: 586
	public UIWidget widgetContainer;

	// Token: 0x0400024B RID: 587
	public UIPanel panelContainer;

	// Token: 0x0400024C RID: 588
	public UIAnchor.Side side;

	// Token: 0x0400024D RID: 589
	public bool halfPixelOffset;

	// Token: 0x0400024E RID: 590
	public float depthOffset;

	// Token: 0x0400024F RID: 591
	public Vector2 relativeOffset;

	// Token: 0x04000250 RID: 592
	private Animation mAnim;

	// Token: 0x04000251 RID: 593
	private UIRoot mRoot;

	// Token: 0x0200005F RID: 95
	public enum Side
	{
		// Token: 0x04000253 RID: 595
		BottomLeft,
		// Token: 0x04000254 RID: 596
		Left,
		// Token: 0x04000255 RID: 597
		TopLeft,
		// Token: 0x04000256 RID: 598
		Top,
		// Token: 0x04000257 RID: 599
		TopRight,
		// Token: 0x04000258 RID: 600
		Right,
		// Token: 0x04000259 RID: 601
		BottomRight,
		// Token: 0x0400025A RID: 602
		Bottom,
		// Token: 0x0400025B RID: 603
		Center
	}
}
