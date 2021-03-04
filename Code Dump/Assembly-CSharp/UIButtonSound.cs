using System;
using UnityEngine;

// Token: 0x02000016 RID: 22
[AddComponentMenu("NGUI/Interaction/Button Sound")]
public class UIButtonSound : MonoBehaviour
{
	// Token: 0x06000092 RID: 146 RVA: 0x00002294 File Offset: 0x00000494
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002298 File Offset: 0x00000498
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000229C File Offset: 0x0000049C
	private void OnClick()
	{
	}

	// Token: 0x0400006F RID: 111
	public AudioClip audioClip;

	// Token: 0x04000070 RID: 112
	public UIButtonSound.Trigger trigger;

	// Token: 0x04000071 RID: 113
	public float volume;

	// Token: 0x04000072 RID: 114
	public float pitch;

	// Token: 0x02000017 RID: 23
	public enum Trigger
	{
		// Token: 0x04000074 RID: 116
		OnClick,
		// Token: 0x04000075 RID: 117
		OnMouseOver,
		// Token: 0x04000076 RID: 118
		OnMouseOut,
		// Token: 0x04000077 RID: 119
		OnPress,
		// Token: 0x04000078 RID: 120
		OnRelease
	}
}
