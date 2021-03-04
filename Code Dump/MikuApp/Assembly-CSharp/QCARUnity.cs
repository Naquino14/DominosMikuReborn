using UnityEngine;

public static class QCARUnity
{
	public enum InitError
	{
		INIT_DEVICE_NOT_SUPPORTED = -2,
		INIT_ERROR,
		INIT_SUCCESS
	}

	public enum QCARHint
	{
		HINT_MAX_SIMULTANEOUS_IMAGE_TARGETS
	}

	public static InitError CheckInitializationError()
	{
		return (InitError)/*Error near IL_0001: Stack underflow*/;
	}

	public static bool IsRendererDirty()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static bool SetHint(QCARHint hint, int value)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static bool RequiresAlpha()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static Matrix4x4 GetProjectionGL(float nearPlane, float farPlane, ScreenOrientation screenOrientation)
	{
		return (Matrix4x4)/*Error near IL_0001: Stack underflow*/;
	}
}
