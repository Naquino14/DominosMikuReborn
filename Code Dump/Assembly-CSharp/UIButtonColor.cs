using System;
using UnityEngine;

// Token: 0x0200000E RID: 14
[AddComponentMenu("NGUI/Interaction/Button Color")]
public class UIButtonColor : MonoBehaviour
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600005D RID: 93 RVA: 0x000021C0 File Offset: 0x000003C0
	// (set) Token: 0x0600005E RID: 94 RVA: 0x000021C4 File Offset: 0x000003C4
	public Color defaultColor
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600005F RID: 95 RVA: 0x000021C8 File Offset: 0x000003C8
	private void Awake()
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000021CC File Offset: 0x000003CC
	private void Start()
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000021D0 File Offset: 0x000003D0
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000021D4 File Offset: 0x000003D4
	private void OnDisable()
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000021D8 File Offset: 0x000003D8
	protected void Init()
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x000021DC File Offset: 0x000003DC
	protected virtual void OnPress(bool isPressed)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000021E0 File Offset: 0x000003E0
	protected virtual void OnHover(bool isOver)
	{
	}

	// Token: 0x0400002F RID: 47
	public GameObject tweenTarget;

	// Token: 0x04000030 RID: 48
	public Color hover;

	// Token: 0x04000031 RID: 49
	public Color pressed;

	// Token: 0x04000032 RID: 50
	public float duration;

	// Token: 0x04000033 RID: 51
	protected Color mColor;

	// Token: 0x04000034 RID: 52
	protected bool mInitDone;

	// Token: 0x04000035 RID: 53
	protected bool mStarted;

	// Token: 0x04000036 RID: 54
	protected bool mHighlighted;
}
