using System;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020000D6 RID: 214
public abstract class QCARRenderer
{
	// Token: 0x17000114 RID: 276
	// (get) Token: 0x060006F0 RID: 1776 RVA: 0x00003764 File Offset: 0x00001964
	public static QCARRenderer Instance
	{
		get
		{
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x060006F1 RID: 1777
	// (set) Token: 0x060006F2 RID: 1778
	public abstract bool DrawVideoBackground { get; set; }

	// Token: 0x060006F3 RID: 1779
	public abstract QCARRenderer.VideoBGCfgData GetVideoBackgroundConfig();

	// Token: 0x060006F4 RID: 1780
	public abstract void ClearVideoBackgroundConfig();

	// Token: 0x060006F5 RID: 1781
	public abstract void SetVideoBackgroundConfig(QCARRenderer.VideoBGCfgData config);

	// Token: 0x060006F6 RID: 1782
	public abstract bool SetVideoBackgroundTexture(Texture2D texture);

	// Token: 0x060006F7 RID: 1783
	public abstract bool IsVideoBackgroundInfoAvailable();

	// Token: 0x060006F8 RID: 1784
	public abstract QCARRenderer.VideoTextureInfo GetVideoTextureInfo();

	// Token: 0x04000459 RID: 1113
	private static QCARRenderer sInstance;

	// Token: 0x020000D7 RID: 215
	public enum VideoBackgroundReflection
	{
		// Token: 0x0400045B RID: 1115
		DEFAULT,
		// Token: 0x0400045C RID: 1116
		ON,
		// Token: 0x0400045D RID: 1117
		OFF
	}

	// Token: 0x020000D8 RID: 216
	[StructLayout(0, Pack = 1)]
	public struct VideoBGCfgData
	{
		// Token: 0x0400045E RID: 1118
		public int enabled;

		// Token: 0x0400045F RID: 1119
		public int synchronous;

		// Token: 0x04000460 RID: 1120
		public QCARRenderer.Vec2I position;

		// Token: 0x04000461 RID: 1121
		public QCARRenderer.Vec2I size;

		// Token: 0x04000462 RID: 1122
		[MarshalAs(31)]
		public QCARRenderer.VideoBackgroundReflection reflection;
	}

	// Token: 0x020000D9 RID: 217
	[StructLayout(0, Pack = 1)]
	public struct Vec2I
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x00003768 File Offset: 0x00001968
		public Vec2I(int v1, int v2)
		{
		}

		// Token: 0x04000463 RID: 1123
		public int x;

		// Token: 0x04000464 RID: 1124
		public int y;
	}

	// Token: 0x020000DA RID: 218
	[StructLayout(0, Pack = 1)]
	public struct VideoTextureInfo
	{
		// Token: 0x04000465 RID: 1125
		public QCARRenderer.Vec2I textureSize;

		// Token: 0x04000466 RID: 1126
		public QCARRenderer.Vec2I imageSize;
	}
}
