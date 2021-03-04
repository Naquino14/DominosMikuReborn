using System.Runtime.InteropServices;

public class UIWrapper
{
	[DllImport("__Internal")]
	private static extern void showDomino_();

	[DllImport("__Internal")]
	private static extern void playShutterSound_();

	[DllImport("__Internal")]
	private static extern bool isTest_();

	public static void showDomino()
	{
	}

	public static void playShutterSound()
	{
	}

	public static bool isTest()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
