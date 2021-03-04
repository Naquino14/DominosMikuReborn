using System;
using UnityEngine;

// Token: 0x02000029 RID: 41
[RequireComponent(typeof(UIInput))]
[AddComponentMenu("NGUI/Interaction/Input Validator")]
public class UIInputValidator : MonoBehaviour
{
	// Token: 0x060000FC RID: 252 RVA: 0x0000243C File Offset: 0x0000063C
	private void Start()
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002440 File Offset: 0x00000640
	private char Validate(string text, char ch)
	{
	}

	// Token: 0x040000F7 RID: 247
	public UIInputValidator.Validation logic;

	// Token: 0x0200002A RID: 42
	public enum Validation
	{
		// Token: 0x040000F9 RID: 249
		None,
		// Token: 0x040000FA RID: 250
		Integer,
		// Token: 0x040000FB RID: 251
		Float,
		// Token: 0x040000FC RID: 252
		Alphanumeric,
		// Token: 0x040000FD RID: 253
		Username,
		// Token: 0x040000FE RID: 254
		Name
	}
}
