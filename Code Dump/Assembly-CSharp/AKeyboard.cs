using System;
using UnityEngine;

// Token: 0x02000103 RID: 259
public class AKeyboard : MonoBehaviour
{
	// Token: 0x060007DB RID: 2011 RVA: 0x00003A6C File Offset: 0x00001C6C
	public static void Open(string defautText, MonoBehaviour receiver)
	{
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00003A70 File Offset: 0x00001C70
	private void Update()
	{
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00003A74 File Offset: 0x00001C74
	private static void DestroyKeyboard()
	{
	}

	// Token: 0x040004EF RID: 1263
	public TouchScreenKeyboard keyboard;

	// Token: 0x040004F0 RID: 1264
	public static AKeyboard instance;

	// Token: 0x040004F1 RID: 1265
	private string onKeyboardDoneFunc;

	// Token: 0x040004F2 RID: 1266
	private GameObject receiver;
}
