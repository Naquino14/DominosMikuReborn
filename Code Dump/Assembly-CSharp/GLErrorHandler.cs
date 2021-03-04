using System;
using UnityEngine;

// Token: 0x0200008E RID: 142
public class GLErrorHandler : MonoBehaviour
{
	// Token: 0x060003F3 RID: 1011 RVA: 0x00002FC0 File Offset: 0x000011C0
	public static void SetError(string errorText)
	{
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002FC4 File Offset: 0x000011C4
	private void OnGUI()
	{
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00002FC8 File Offset: 0x000011C8
	private void DrawWindowContent(int id)
	{
	}

	// Token: 0x0400039A RID: 922
	private const string WINDOW_TITLE = "Sample Error";

	// Token: 0x0400039B RID: 923
	private static string mErrorText;

	// Token: 0x0400039C RID: 924
	private static bool mErrorOccurred;
}
