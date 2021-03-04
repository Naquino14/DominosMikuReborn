using System;

// Token: 0x0200009B RID: 155
public abstract class ImageTargetBuilder
{
	// Token: 0x0600042F RID: 1071
	public abstract bool Build(string targetName, float sceenSizeWidth);

	// Token: 0x06000430 RID: 1072
	public abstract void StartScan();

	// Token: 0x06000431 RID: 1073
	public abstract void StopScan();

	// Token: 0x06000432 RID: 1074
	public abstract ImageTargetBuilder.FrameQuality GetFrameQuality();

	// Token: 0x06000433 RID: 1075
	public abstract TrackableSource GetTrackableSource();

	// Token: 0x0200009C RID: 156
	public enum FrameQuality
	{
		// Token: 0x040003AF RID: 943
		FRAME_QUALITY_NONE = -1,
		// Token: 0x040003B0 RID: 944
		FRAME_QUALITY_LOW,
		// Token: 0x040003B1 RID: 945
		FRAME_QUALITY_MEDIUM,
		// Token: 0x040003B2 RID: 946
		FRAME_QUALITY_HIGH
	}
}
