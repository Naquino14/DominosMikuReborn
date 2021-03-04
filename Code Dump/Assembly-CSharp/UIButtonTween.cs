using System;
using AnimationOrTween;
using UnityEngine;

// Token: 0x02000018 RID: 24
[AddComponentMenu("NGUI/Interaction/Button Tween")]
public class UIButtonTween : MonoBehaviour
{
	// Token: 0x06000096 RID: 150 RVA: 0x000022A4 File Offset: 0x000004A4
	private void Start()
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x000022A8 File Offset: 0x000004A8
	private void OnEnable()
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x000022AC File Offset: 0x000004AC
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x06000099 RID: 153 RVA: 0x000022B0 File Offset: 0x000004B0
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000022B4 File Offset: 0x000004B4
	private void OnClick()
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x000022B8 File Offset: 0x000004B8
	private void OnDoubleClick()
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x000022BC File Offset: 0x000004BC
	private void OnSelect(bool isSelected)
	{
	}

	// Token: 0x0600009D RID: 157 RVA: 0x000022C0 File Offset: 0x000004C0
	private void OnActivate(bool isActive)
	{
	}

	// Token: 0x0600009E RID: 158 RVA: 0x000022C4 File Offset: 0x000004C4
	private void Update()
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000022C8 File Offset: 0x000004C8
	public void Play(bool forward)
	{
	}

	// Token: 0x04000079 RID: 121
	public GameObject tweenTarget;

	// Token: 0x0400007A RID: 122
	public int tweenGroup;

	// Token: 0x0400007B RID: 123
	public Trigger trigger;

	// Token: 0x0400007C RID: 124
	public Direction playDirection;

	// Token: 0x0400007D RID: 125
	public bool resetOnPlay;

	// Token: 0x0400007E RID: 126
	public EnableCondition ifDisabledOnPlay;

	// Token: 0x0400007F RID: 127
	public DisableCondition disableWhenFinished;

	// Token: 0x04000080 RID: 128
	public bool includeChildren;

	// Token: 0x04000081 RID: 129
	public GameObject eventReceiver;

	// Token: 0x04000082 RID: 130
	public string callWhenFinished;

	// Token: 0x04000083 RID: 131
	public UITweener.OnFinished onFinished;

	// Token: 0x04000084 RID: 132
	private UITweener[] mTweens;

	// Token: 0x04000085 RID: 133
	private bool mStarted;

	// Token: 0x04000086 RID: 134
	private bool mHighlighted;
}
