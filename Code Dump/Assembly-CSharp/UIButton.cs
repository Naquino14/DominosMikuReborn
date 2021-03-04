using System;
using UnityEngine;

// Token: 0x0200000C RID: 12
[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton : UIButtonColor
{
	// Token: 0x06000054 RID: 84 RVA: 0x0000219C File Offset: 0x0000039C
	protected override void OnEnable()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000021A0 File Offset: 0x000003A0
	protected override void OnHover(bool isOver)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000021A4 File Offset: 0x000003A4
	protected override void OnPress(bool isPressed)
	{
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000057 RID: 87 RVA: 0x000021A8 File Offset: 0x000003A8
	// (set) Token: 0x06000058 RID: 88 RVA: 0x000021AC File Offset: 0x000003AC
	public bool isEnabled
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000021B0 File Offset: 0x000003B0
	public void UpdateColor(bool shouldBeEnabled, bool immediate)
	{
	}

	// Token: 0x0400002C RID: 44
	public Color disabledColor;
}
