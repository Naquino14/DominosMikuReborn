using System;
using UnityEngine;

// Token: 0x02000028 RID: 40
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Image Button")]
public class UIImageButton : MonoBehaviour
{
	// Token: 0x060000F7 RID: 247 RVA: 0x00002428 File Offset: 0x00000628
	private void OnEnable()
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000242C File Offset: 0x0000062C
	private void Start()
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002430 File Offset: 0x00000630
	private void OnHover(bool isOver)
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002434 File Offset: 0x00000634
	private void OnPress(bool pressed)
	{
	}

	// Token: 0x040000F3 RID: 243
	public UISprite target;

	// Token: 0x040000F4 RID: 244
	public string normalSprite;

	// Token: 0x040000F5 RID: 245
	public string hoverSprite;

	// Token: 0x040000F6 RID: 246
	public string pressedSprite;
}
