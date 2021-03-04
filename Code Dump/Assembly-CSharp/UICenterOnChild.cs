using System;
using UnityEngine;

// Token: 0x02000019 RID: 25
[AddComponentMenu("NGUI/Interaction/Center On Child")]
public class UICenterOnChild : MonoBehaviour
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x000022D0 File Offset: 0x000004D0
	public GameObject centeredObject
	{
		get
		{
		}
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x000022D4 File Offset: 0x000004D4
	private void OnEnable()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000022D8 File Offset: 0x000004D8
	private void OnDragFinished()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000022DC File Offset: 0x000004DC
	public void Recenter()
	{
	}

	// Token: 0x04000087 RID: 135
	public SpringPanel.OnFinished onFinished;

	// Token: 0x04000088 RID: 136
	private UIDraggablePanel mDrag;

	// Token: 0x04000089 RID: 137
	private GameObject mCenteredObject;
}
