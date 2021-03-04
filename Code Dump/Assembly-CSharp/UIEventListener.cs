using System;
using UnityEngine;

// Token: 0x0200004A RID: 74
[AddComponentMenu("NGUI/Internal/Event Listener")]
public class UIEventListener : MonoBehaviour
{
	// Token: 0x060001FE RID: 510 RVA: 0x00002844 File Offset: 0x00000A44
	private void OnSubmit()
	{
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00002848 File Offset: 0x00000A48
	private void OnClick()
	{
	}

	// Token: 0x06000200 RID: 512 RVA: 0x0000284C File Offset: 0x00000A4C
	private void OnDoubleClick()
	{
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00002850 File Offset: 0x00000A50
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00002854 File Offset: 0x00000A54
	private void OnPress(bool isPressed)
	{
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00002858 File Offset: 0x00000A58
	private void OnSelect(bool selected)
	{
	}

	// Token: 0x06000204 RID: 516 RVA: 0x0000285C File Offset: 0x00000A5C
	private void OnScroll(float delta)
	{
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00002860 File Offset: 0x00000A60
	private void OnDrag(Vector2 delta)
	{
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00002864 File Offset: 0x00000A64
	private void OnDrop(GameObject go)
	{
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00002868 File Offset: 0x00000A68
	private void OnInput(string text)
	{
	}

	// Token: 0x06000208 RID: 520 RVA: 0x0000286C File Offset: 0x00000A6C
	private void OnKey(KeyCode key)
	{
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00002870 File Offset: 0x00000A70
	public static UIEventListener Get(GameObject go)
	{
	}

	// Token: 0x040001C5 RID: 453
	public object parameter;

	// Token: 0x040001C6 RID: 454
	public UIEventListener.VoidDelegate onSubmit;

	// Token: 0x040001C7 RID: 455
	public UIEventListener.VoidDelegate onClick;

	// Token: 0x040001C8 RID: 456
	public UIEventListener.VoidDelegate onDoubleClick;

	// Token: 0x040001C9 RID: 457
	public UIEventListener.BoolDelegate onHover;

	// Token: 0x040001CA RID: 458
	public UIEventListener.BoolDelegate onPress;

	// Token: 0x040001CB RID: 459
	public UIEventListener.BoolDelegate onSelect;

	// Token: 0x040001CC RID: 460
	public UIEventListener.FloatDelegate onScroll;

	// Token: 0x040001CD RID: 461
	public UIEventListener.VectorDelegate onDrag;

	// Token: 0x040001CE RID: 462
	public UIEventListener.ObjectDelegate onDrop;

	// Token: 0x040001CF RID: 463
	public UIEventListener.StringDelegate onInput;

	// Token: 0x040001D0 RID: 464
	public UIEventListener.KeyCodeDelegate onKey;

	// Token: 0x02000156 RID: 342
	// (Invoke) Token: 0x06000B4D RID: 2893
	public delegate void VoidDelegate(GameObject go);

	// Token: 0x02000157 RID: 343
	// (Invoke) Token: 0x06000B51 RID: 2897
	public delegate void BoolDelegate(GameObject go, bool state);

	// Token: 0x02000158 RID: 344
	// (Invoke) Token: 0x06000B55 RID: 2901
	public delegate void FloatDelegate(GameObject go, float delta);

	// Token: 0x02000159 RID: 345
	// (Invoke) Token: 0x06000B59 RID: 2905
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	// Token: 0x0200015A RID: 346
	// (Invoke) Token: 0x06000B5D RID: 2909
	public delegate void StringDelegate(GameObject go, string text);

	// Token: 0x0200015B RID: 347
	// (Invoke) Token: 0x06000B61 RID: 2913
	public delegate void ObjectDelegate(GameObject go, GameObject draggedObject);

	// Token: 0x0200015C RID: 348
	// (Invoke) Token: 0x06000B65 RID: 2917
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);
}
