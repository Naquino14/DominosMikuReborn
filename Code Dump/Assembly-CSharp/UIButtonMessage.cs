using System;
using UnityEngine;

// Token: 0x02000010 RID: 16
[AddComponentMenu("NGUI/Interaction/Button Message")]
public class UIButtonMessage : MonoBehaviour
{
	// Token: 0x0600006B RID: 107 RVA: 0x000021F8 File Offset: 0x000003F8
	private void Start()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000021FC File Offset: 0x000003FC
	private void OnEnable()
	{
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002200 File Offset: 0x00000400
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002204 File Offset: 0x00000404
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002208 File Offset: 0x00000408
	private void OnClick()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000220C File Offset: 0x0000040C
	private void OnDoubleClick()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002210 File Offset: 0x00000410
	private void Send()
	{
	}

	// Token: 0x0400003D RID: 61
	public GameObject target;

	// Token: 0x0400003E RID: 62
	public string functionName;

	// Token: 0x0400003F RID: 63
	public UIButtonMessage.Trigger trigger;

	// Token: 0x04000040 RID: 64
	public bool includeChildren;

	// Token: 0x04000041 RID: 65
	private bool mStarted;

	// Token: 0x04000042 RID: 66
	private bool mHighlighted;

	// Token: 0x02000011 RID: 17
	public enum Trigger
	{
		// Token: 0x04000044 RID: 68
		OnClick,
		// Token: 0x04000045 RID: 69
		OnMouseOver,
		// Token: 0x04000046 RID: 70
		OnMouseOut,
		// Token: 0x04000047 RID: 71
		OnPress,
		// Token: 0x04000048 RID: 72
		OnRelease,
		// Token: 0x04000049 RID: 73
		OnDoubleClick
	}
}
