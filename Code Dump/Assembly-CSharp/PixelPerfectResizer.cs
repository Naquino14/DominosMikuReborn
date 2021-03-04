using System;
using UnityEngine;

// Token: 0x0200010F RID: 271
[ExecuteInEditMode]
public class PixelPerfectResizer : MonoBehaviour
{
	// Token: 0x0600082A RID: 2090 RVA: 0x00003BA4 File Offset: 0x00001DA4
	private void Awake()
	{
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x00003BA8 File Offset: 0x00001DA8
	private void Update()
	{
	}

	// Token: 0x04000528 RID: 1320
	public Camera cam;

	// Token: 0x04000529 RID: 1321
	private Transform _transform;

	// Token: 0x0400052A RID: 1322
	private float _lastOrthographicSize;

	// Token: 0x0400052B RID: 1323
	private float _lastPixelWidth;

	// Token: 0x0400052C RID: 1324
	private float _lastPixelHeight;
}
