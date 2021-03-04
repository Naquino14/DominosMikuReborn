using System;
using UnityEngine;

// Token: 0x020000DD RID: 221
public static class QCARUnity
{
	// Token: 0x06000706 RID: 1798 RVA: 0x0000379C File Offset: 0x0000199C
	public static QCARUnity.InitError CheckInitializationError()
	{
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x000037A0 File Offset: 0x000019A0
	public static bool IsRendererDirty()
	{
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x000037A4 File Offset: 0x000019A4
	public static bool SetHint(QCARUnity.QCARHint hint, int value)
	{
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x000037A8 File Offset: 0x000019A8
	public static bool RequiresAlpha()
	{
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x000037AC File Offset: 0x000019AC
	public static Matrix4x4 GetProjectionGL(float nearPlane, float farPlane, ScreenOrientation screenOrientation)
	{
	}

	// Token: 0x020000DE RID: 222
	public enum InitError
	{
		// Token: 0x0400046D RID: 1133
		INIT_DEVICE_NOT_SUPPORTED = -2,
		// Token: 0x0400046E RID: 1134
		INIT_ERROR,
		// Token: 0x0400046F RID: 1135
		INIT_SUCCESS
	}

	// Token: 0x020000DF RID: 223
	public enum QCARHint
	{
		// Token: 0x04000471 RID: 1137
		HINT_MAX_SIMULTANEOUS_IMAGE_TARGETS
	}
}
