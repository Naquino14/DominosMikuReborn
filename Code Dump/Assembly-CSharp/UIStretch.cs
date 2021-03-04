using System;
using UnityEngine;

// Token: 0x02000079 RID: 121
[AddComponentMenu("NGUI/UI/Stretch")]
[ExecuteInEditMode]
public class UIStretch : MonoBehaviour
{
	// Token: 0x0600038B RID: 907 RVA: 0x00002E74 File Offset: 0x00001074
	private void Awake()
	{
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00002E78 File Offset: 0x00001078
	private void Start()
	{
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00002E7C File Offset: 0x0000107C
	private void Update()
	{
	}

	// Token: 0x0400033F RID: 831
	public Camera uiCamera;

	// Token: 0x04000340 RID: 832
	public UIWidget widgetContainer;

	// Token: 0x04000341 RID: 833
	public UIPanel panelContainer;

	// Token: 0x04000342 RID: 834
	public UIStretch.Style style;

	// Token: 0x04000343 RID: 835
	public Vector2 relativeSize;

	// Token: 0x04000344 RID: 836
	private Transform mTrans;

	// Token: 0x04000345 RID: 837
	private UIRoot mRoot;

	// Token: 0x04000346 RID: 838
	private Animation mAnim;

	// Token: 0x0200007A RID: 122
	public enum Style
	{
		// Token: 0x04000348 RID: 840
		None,
		// Token: 0x04000349 RID: 841
		Horizontal,
		// Token: 0x0400034A RID: 842
		Vertical,
		// Token: 0x0400034B RID: 843
		Both,
		// Token: 0x0400034C RID: 844
		BasedOnHeight
	}
}
