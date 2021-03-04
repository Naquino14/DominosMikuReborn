using System.Runtime.InteropServices;
using UnityEngine;

public class SysFont : MonoBehaviour
{
	public enum Alignment
	{
		Left,
		Center,
		Right
	}

	[DllImport("__Internal")]
	private static extern void _SysFontQueueTexture(string text, string fontName, int fontSize, bool isBold, bool isItalic, Alignment alignment, int maxWidthPixels, int maxHeightPixels, int textureID);

	[DllImport("__Internal")]
	private static extern void _SysFontUpdateQueuedTexture(int textureID);

	[DllImport("__Internal")]
	private static extern void _SysFontDequeueTexture(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextureWidth(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextureHeight(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextWidth(int textureID);

	[DllImport("__Internal")]
	private static extern int _SysFontGetTextHeight(int textureID);

	[DllImport("__Internal")]
	private static extern void _SysFontRender();

	public static int GetTextureWidth(int textureID)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static int GetTextureHeight(int textureID)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static int GetTextWidth(int textureID)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static int GetTextHeight(int textureID)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static void QueueTexture(string text, string fontName, int fontSize, bool isBold, bool isItalic, Alignment alignment, bool isMultiLine, int maxWidthPixels, int maxHeightPixels, int textureID)
	{
	}

	public static void UpdateQueuedTexture(int textureID)
	{
	}

	public static void DequeueTexture(int textureID)
	{
	}

	public static void SafeDestroy(Object obj)
	{
	}
}
