using System;
using UnityEngine;

// Token: 0x02000020 RID: 32
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Drag Panel Contents")]
public class UIDragPanelContents : MonoBehaviour
{
	// Token: 0x060000BF RID: 191 RVA: 0x00002348 File Offset: 0x00000548
	private void Awake()
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x0000234C File Offset: 0x0000054C
	private void Start()
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002350 File Offset: 0x00000550
	private void OnPress(bool pressed)
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002354 File Offset: 0x00000554
	private void OnDrag(Vector2 delta)
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002358 File Offset: 0x00000558
	private void OnScroll(float delta)
	{
	}

	// Token: 0x040000AF RID: 175
	public UIDraggablePanel draggablePanel;

	// Token: 0x040000B0 RID: 176
	[SerializeField]
	[HideInInspector]
	private UIPanel panel;
}
