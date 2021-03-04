using System;
using UnityEngine;

// Token: 0x02000015 RID: 21
[AddComponentMenu("NGUI/Interaction/Button Scale")]
public class UIButtonScale : MonoBehaviour
{
	// Token: 0x0600008B RID: 139 RVA: 0x00002278 File Offset: 0x00000478
	private void Start()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x0000227C File Offset: 0x0000047C
	private void OnEnable()
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002280 File Offset: 0x00000480
	private void OnDisable()
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002284 File Offset: 0x00000484
	private void Init()
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002288 File Offset: 0x00000488
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000228C File Offset: 0x0000048C
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x04000067 RID: 103
	public Transform tweenTarget;

	// Token: 0x04000068 RID: 104
	public Vector3 hover;

	// Token: 0x04000069 RID: 105
	public Vector3 pressed;

	// Token: 0x0400006A RID: 106
	public float duration;

	// Token: 0x0400006B RID: 107
	private Vector3 mScale;

	// Token: 0x0400006C RID: 108
	private bool mInitDone;

	// Token: 0x0400006D RID: 109
	private bool mStarted;

	// Token: 0x0400006E RID: 110
	private bool mHighlighted;
}
