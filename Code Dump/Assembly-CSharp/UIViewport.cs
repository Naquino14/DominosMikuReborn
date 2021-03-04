using System;
using UnityEngine;

// Token: 0x02000081 RID: 129
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Viewport Camera")]
public class UIViewport : MonoBehaviour
{
	// Token: 0x060003B2 RID: 946 RVA: 0x00002F10 File Offset: 0x00001110
	private void Start()
	{
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002F14 File Offset: 0x00001114
	private void LateUpdate()
	{
	}

	// Token: 0x0400036E RID: 878
	public Camera sourceCamera;

	// Token: 0x0400036F RID: 879
	public Transform topLeft;

	// Token: 0x04000370 RID: 880
	public Transform bottomRight;

	// Token: 0x04000371 RID: 881
	public float fullSize;

	// Token: 0x04000372 RID: 882
	private Camera mCam;
}
