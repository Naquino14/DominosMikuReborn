using System;

// Token: 0x02000092 RID: 146
public interface IUserDefinedTargetEventHandler
{
	// Token: 0x060003FE RID: 1022
	void OnInitialized();

	// Token: 0x060003FF RID: 1023
	void OnFrameQualityChanged(ImageTargetBuilder.FrameQuality frameQuality);

	// Token: 0x06000400 RID: 1024
	void OnNewTrackableSource(TrackableSource trackableSource);
}
