using UnityEngine;

public class QCARRuntimeUtilities
{
	private enum WebCamUsed
	{
		UNKNOWN,
		TRUE,
		FALSE
	}

	private static ScreenOrientation sScreenOrientation;

	public static ScreenOrientation ScreenOrientation => (ScreenOrientation)/*Error near IL_0001: Stack underflow*/;

	public static bool IsLandscapeOrientation => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public static bool IsPortraitOrientation => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public static string StripFileNameFromPath(string fullPath)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public static string StripExtensionFromPath(string fullPath)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public static void CacheSurfaceOrientation(ScreenOrientation surfaceOrientation)
	{
	}

	public static void ForceDisableTrackables()
	{
	}

	public static bool IsPlayMode()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static bool IsQCAREnabled()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static void RestartPlayMode()
	{
	}
}
