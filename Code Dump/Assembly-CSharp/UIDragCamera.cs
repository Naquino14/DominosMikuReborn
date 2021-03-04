using System;
using UnityEngine;

// Token: 0x0200001D RID: 29
[AddComponentMenu("NGUI/Interaction/Drag Camera")]
[ExecuteInEditMode]
public class UIDragCamera : IgnoreTimeScale
{
	// Token: 0x060000B4 RID: 180 RVA: 0x0000231C File Offset: 0x0000051C
	private void Awake()
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002320 File Offset: 0x00000520
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002324 File Offset: 0x00000524
	private void OnDrag(Vector2 delta)
	{
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002328 File Offset: 0x00000528
	private void OnScroll(float delta)
	{
	}

	// Token: 0x0400009C RID: 156
	public UIDraggableCamera draggableCamera;

	// Token: 0x0400009D RID: 157
	[HideInInspector]
	[SerializeField]
	private Component target;
}
