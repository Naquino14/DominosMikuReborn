using System;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x0200002D RID: 45
public class SysFont : MonoBehaviour
{
	// Token: 0x060002E1 RID: 737
	[DllImport("__Internal")]
	private static extern void _SysFontQueueTexture(string text, string fontName, int fontSize, bool isBold, bool isItalic, SysFont.Alignment alignment, int maxWidthPixels, int maxHeightPixels, int textureID);

	// Token: 0x060002E2 RID: 738
	[DllImport("__Internal")]
	private static extern void _SysFontUpdateQueuedTexture(int textureID);

	// Token: 0x060002E3 RID: 739
	[DllImport("__Internal")]
	private static extern void _SysFontDequeueTexture(int textureID);

	// Token: 0x060002E4 RID: 740
	[DllImport("__Internal")]
	private static extern int _SysFontGetTextureWidth(int textureID);

	// Token: 0x060002E5 RID: 741
	[DllImport("__Internal")]
	private static extern int _SysFontGetTextureHeight(int textureID);

	// Token: 0x060002E6 RID: 742
	[DllImport("__Internal")]
	private static extern int _SysFontGetTextWidth(int textureID);

	// Token: 0x060002E7 RID: 743
	[DllImport("__Internal")]
	private static extern int _SysFontGetTextHeight(int textureID);

	// Token: 0x060002E8 RID: 744
	[DllImport("__Internal")]
	private static extern void _SysFontRender();

	// Token: 0x060002E9 RID: 745 RVA: 0x00002A00 File Offset: 0x00000C00
	public static int GetTextureWidth(int textureID)
	{
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00002A04 File Offset: 0x00000C04
	public static int GetTextureHeight(int textureID)
	{
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00002A08 File Offset: 0x00000C08
	public static int GetTextWidth(int textureID)
	{
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00002A0C File Offset: 0x00000C0C
	public static int GetTextHeight(int textureID)
	{
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002A10 File Offset: 0x00000C10
	public static void QueueTexture(string text, string fontName, int fontSize, bool isBold, bool isItalic, SysFont.Alignment alignment, bool isMultiLine, int maxWidthPixels, int maxHeightPixels, int textureID)
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00002A14 File Offset: 0x00000C14
	public static void UpdateQueuedTexture(int textureID)
	{
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002A18 File Offset: 0x00000C18
	public static void DequeueTexture(int textureID)
	{
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002A1C File Offset: 0x00000C1C
	public static void SafeDestroy(UnityEngine.Object obj)
	{
	}

	// Token: 0x0200002E RID: 46
	public enum Alignment
	{
		// Token: 0x040000FC RID: 252
		Left,
		// Token: 0x040000FD RID: 253
		Center,
		// Token: 0x040000FE RID: 254
		Right
	}
}
