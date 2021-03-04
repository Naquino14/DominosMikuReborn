using System;
using System.Runtime.InteropServices;

// Token: 0x02000106 RID: 262
public class FacebookComposer
{
	// Token: 0x060007E5 RID: 2021
	[DllImport("__Internal")]
	private static extern void showDEFbComposer_(string text, string imagePath);

	// Token: 0x060007E6 RID: 2022 RVA: 0x00003A94 File Offset: 0x00001C94
	public static void showDialog(string text, string imagePath)
	{
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00003A98 File Offset: 0x00001C98
	public static void showDialog(string text)
	{
	}
}
