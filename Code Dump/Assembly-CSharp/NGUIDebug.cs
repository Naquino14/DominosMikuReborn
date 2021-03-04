using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000044 RID: 68
[AddComponentMenu("NGUI/Internal/Debug")]
public class NGUIDebug : MonoBehaviour
{
	// Token: 0x0600019A RID: 410 RVA: 0x000026B4 File Offset: 0x000008B4
	public static void Log(string text)
	{
	}

	// Token: 0x0600019B RID: 411 RVA: 0x000026B8 File Offset: 0x000008B8
	public static void DrawBounds(Bounds b)
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x000026BC File Offset: 0x000008BC
	private void OnGUI()
	{
	}

	// Token: 0x040001A5 RID: 421
	private static List<string> mLines;

	// Token: 0x040001A6 RID: 422
	private static NGUIDebug mInstance;
}
