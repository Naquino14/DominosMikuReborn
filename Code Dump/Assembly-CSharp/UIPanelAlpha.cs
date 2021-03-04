using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
[AddComponentMenu("NGUI/Interaction/Panel Alpha")]
public class UIPanelAlpha : MonoBehaviour
{
	// Token: 0x060000FF RID: 255 RVA: 0x00002448 File Offset: 0x00000648
	private void Start()
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0000244C File Offset: 0x0000064C
	private void Update()
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002450 File Offset: 0x00000650
	private void UpdateAlpha()
	{
	}

	// Token: 0x040000FF RID: 255
	public float alpha;

	// Token: 0x04000100 RID: 256
	private Collider[] mColliders;

	// Token: 0x04000101 RID: 257
	private UIWidget[] mWidgets;

	// Token: 0x04000102 RID: 258
	private float[] mAlpha;

	// Token: 0x04000103 RID: 259
	private float mLastAlpha;

	// Token: 0x04000104 RID: 260
	private int mLevel;
}
