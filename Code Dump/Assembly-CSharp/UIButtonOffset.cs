using System;
using UnityEngine;

// Token: 0x02000012 RID: 18
[AddComponentMenu("NGUI/Interaction/Button Offset")]
public class UIButtonOffset : MonoBehaviour
{
	// Token: 0x06000073 RID: 115 RVA: 0x00002218 File Offset: 0x00000418
	private void Start()
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0000221C File Offset: 0x0000041C
	private void OnEnable()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002220 File Offset: 0x00000420
	private void OnDisable()
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002224 File Offset: 0x00000424
	private void Init()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002228 File Offset: 0x00000428
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x0000222C File Offset: 0x0000042C
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x0400004A RID: 74
	public Transform tweenTarget;

	// Token: 0x0400004B RID: 75
	public Vector3 hover;

	// Token: 0x0400004C RID: 76
	public Vector3 pressed;

	// Token: 0x0400004D RID: 77
	public float duration;

	// Token: 0x0400004E RID: 78
	private Vector3 mPos;

	// Token: 0x0400004F RID: 79
	private bool mInitDone;

	// Token: 0x04000050 RID: 80
	private bool mStarted;

	// Token: 0x04000051 RID: 81
	private bool mHighlighted;
}
