using System;
using System.Runtime.InteropServices;

// Token: 0x02000024 RID: 36
public class SharingBinding
{
	// Token: 0x06000260 RID: 608
	[DllImport("__Internal")]
	private static extern void _sharingShareItems(string items, string excludedActivityTypes);

	// Token: 0x06000261 RID: 609 RVA: 0x00002898 File Offset: 0x00000A98
	public static void shareItems(string[] items)
	{
	}

	// Token: 0x06000262 RID: 610 RVA: 0x0000289C File Offset: 0x00000A9C
	public static void shareItems(string[] items, string[] excludedActivityTypes)
	{
	}
}
