using System;
using UnityEngine;

// Token: 0x020000DB RID: 219
public class QCARRuntimeUtilities
{
	// Token: 0x060006FC RID: 1788 RVA: 0x00003774 File Offset: 0x00001974
	public static string StripFileNameFromPath(string fullPath)
	{
	}

	// Token: 0x060006FD RID: 1789 RVA: 0x00003778 File Offset: 0x00001978
	public static string StripExtensionFromPath(string fullPath)
	{
	}

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x060006FE RID: 1790 RVA: 0x0000377C File Offset: 0x0000197C
	public static ScreenOrientation ScreenOrientation
	{
		get
		{
		}
	}

	// Token: 0x060006FF RID: 1791 RVA: 0x00003780 File Offset: 0x00001980
	public static void CacheSurfaceOrientation(ScreenOrientation surfaceOrientation)
	{
	}

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000700 RID: 1792 RVA: 0x00003784 File Offset: 0x00001984
	public static bool IsLandscapeOrientation
	{
		get
		{
		}
	}

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000701 RID: 1793 RVA: 0x00003788 File Offset: 0x00001988
	public static bool IsPortraitOrientation
	{
		get
		{
		}
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x0000378C File Offset: 0x0000198C
	public static void ForceDisableTrackables()
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00003790 File Offset: 0x00001990
	public static bool IsPlayMode()
	{
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00003794 File Offset: 0x00001994
	public static bool IsQCAREnabled()
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00003798 File Offset: 0x00001998
	public static void RestartPlayMode()
	{
	}

	// Token: 0x04000467 RID: 1127
	private static ScreenOrientation sScreenOrientation;

	// Token: 0x020000DC RID: 220
	private enum WebCamUsed
	{
		// Token: 0x04000469 RID: 1129
		UNKNOWN,
		// Token: 0x0400046A RID: 1130
		TRUE,
		// Token: 0x0400046B RID: 1131
		FALSE
	}
}
