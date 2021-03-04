using System;
using System.Runtime.InteropServices;

// Token: 0x0200014D RID: 333
public class UIWrapper
{
	// Token: 0x06000B26 RID: 2854
	[DllImport("__Internal")]
	private static extern void showDomino_();

	// Token: 0x06000B27 RID: 2855
	[DllImport("__Internal")]
	private static extern void playShutterSound_();

	// Token: 0x06000B28 RID: 2856
	[DllImport("__Internal")]
	private static extern bool isTest_();

	// Token: 0x06000B29 RID: 2857 RVA: 0x00004794 File Offset: 0x00002994
	public static void showDomino()
	{
	}

	// Token: 0x06000B2A RID: 2858 RVA: 0x00004798 File Offset: 0x00002998
	public static void playShutterSound()
	{
	}

	// Token: 0x06000B2B RID: 2859 RVA: 0x0000479C File Offset: 0x0000299C
	public static bool isTest()
	{
	}
}
