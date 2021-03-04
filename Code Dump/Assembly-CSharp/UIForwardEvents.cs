using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
[AddComponentMenu("NGUI/Interaction/Forward Events")]
public class UIForwardEvents : MonoBehaviour
{
	// Token: 0x060000E7 RID: 231 RVA: 0x000023E8 File Offset: 0x000005E8
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x000023EC File Offset: 0x000005EC
	private void OnPress(bool pressed)
	{
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x000023F0 File Offset: 0x000005F0
	private void OnClick()
	{
	}

	// Token: 0x060000EA RID: 234 RVA: 0x000023F4 File Offset: 0x000005F4
	private void OnDoubleClick()
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x000023F8 File Offset: 0x000005F8
	private void OnSelect(bool selected)
	{
	}

	// Token: 0x060000EC RID: 236 RVA: 0x000023FC File Offset: 0x000005FC
	private void OnDrag(Vector2 delta)
	{
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00002400 File Offset: 0x00000600
	private void OnDrop(GameObject go)
	{
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002404 File Offset: 0x00000604
	private void OnInput(string text)
	{
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002408 File Offset: 0x00000608
	private void OnSubmit()
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000240C File Offset: 0x0000060C
	private void OnScroll(float delta)
	{
	}

	// Token: 0x040000DD RID: 221
	public GameObject target;

	// Token: 0x040000DE RID: 222
	public bool onHover;

	// Token: 0x040000DF RID: 223
	public bool onPress;

	// Token: 0x040000E0 RID: 224
	public bool onClick;

	// Token: 0x040000E1 RID: 225
	public bool onDoubleClick;

	// Token: 0x040000E2 RID: 226
	public bool onSelect;

	// Token: 0x040000E3 RID: 227
	public bool onDrag;

	// Token: 0x040000E4 RID: 228
	public bool onDrop;

	// Token: 0x040000E5 RID: 229
	public bool onInput;

	// Token: 0x040000E6 RID: 230
	public bool onSubmit;

	// Token: 0x040000E7 RID: 231
	public bool onScroll;
}
