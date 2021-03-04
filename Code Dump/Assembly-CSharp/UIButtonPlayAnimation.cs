using System;
using AnimationOrTween;
using UnityEngine;

// Token: 0x02000013 RID: 19
[AddComponentMenu("NGUI/Interaction/Button Play Animation")]
public class UIButtonPlayAnimation : MonoBehaviour
{
	// Token: 0x0600007A RID: 122 RVA: 0x00002234 File Offset: 0x00000434
	private void Start()
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002238 File Offset: 0x00000438
	private void OnEnable()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0000223C File Offset: 0x0000043C
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002240 File Offset: 0x00000440
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002244 File Offset: 0x00000444
	private void OnClick()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002248 File Offset: 0x00000448
	private void OnDoubleClick()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x0000224C File Offset: 0x0000044C
	private void OnSelect(bool isSelected)
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002250 File Offset: 0x00000450
	private void OnActivate(bool isActive)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002254 File Offset: 0x00000454
	private void Play(bool forward)
	{
	}

	// Token: 0x04000052 RID: 82
	public Animation target;

	// Token: 0x04000053 RID: 83
	public string clipName;

	// Token: 0x04000054 RID: 84
	public Trigger trigger;

	// Token: 0x04000055 RID: 85
	public Direction playDirection;

	// Token: 0x04000056 RID: 86
	public bool resetOnPlay;

	// Token: 0x04000057 RID: 87
	public bool clearSelection;

	// Token: 0x04000058 RID: 88
	public EnableCondition ifDisabledOnPlay;

	// Token: 0x04000059 RID: 89
	public DisableCondition disableWhenFinished;

	// Token: 0x0400005A RID: 90
	public GameObject eventReceiver;

	// Token: 0x0400005B RID: 91
	public string callWhenFinished;

	// Token: 0x0400005C RID: 92
	public ActiveAnimation.OnFinished onFinished;

	// Token: 0x0400005D RID: 93
	private bool mStarted;

	// Token: 0x0400005E RID: 94
	private bool mHighlighted;
}
