using System.Runtime.InteropServices;

public class FacebookComposer
{
	[DllImport("__Internal")]
	private static extern void showDEFbComposer_(string text, string imagePath);

	public static void showDialog(string text, string imagePath)
	{
	}

	public static void showDialog(string text)
	{
	}
}
