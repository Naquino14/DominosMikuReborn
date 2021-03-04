using System;
using UnityEngine;

// Token: 0x02000014 RID: 20
[AddComponentMenu("NGUI/Interaction/Button Rotation")]
public class UIButtonRotation : MonoBehaviour
{
	// Token: 0x06000084 RID: 132 RVA: 0x0000225C File Offset: 0x0000045C
	private void Start()
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002260 File Offset: 0x00000460
	private void OnEnable()
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002264 File Offset: 0x00000464
	private void OnDisable()
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002268 File Offset: 0x00000468
	private void Init()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000226C File Offset: 0x0000046C
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002270 File Offset: 0x00000470
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x0400005F RID: 95
	public Transform tweenTarget;

	// Token: 0x04000060 RID: 96
	public Vector3 hover;

	// Token: 0x04000061 RID: 97
	public Vector3 pressed;

	// Token: 0x04000062 RID: 98
	public float duration;

	// Token: 0x04000063 RID: 99
	private Quaternion mRot;

	// Token: 0x04000064 RID: 100
	private bool mInitDone;

	// Token: 0x04000065 RID: 101
	private bool mStarted;

	// Token: 0x04000066 RID: 102
	private bool mHighlighted;
}
