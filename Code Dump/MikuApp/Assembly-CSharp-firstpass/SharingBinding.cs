using System.Runtime.InteropServices;

public class SharingBinding
{
	[DllImport("__Internal")]
	private static extern void _sharingShareItems(string items, string excludedActivityTypes);

	public static void shareItems(string[] items)
	{
	}

	public static void shareItems(string[] items, string[] excludedActivityTypes)
	{
	}
}
