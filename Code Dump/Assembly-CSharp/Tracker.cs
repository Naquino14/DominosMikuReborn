using System;
using UnityEngine;

// Token: 0x020000EC RID: 236
public abstract class Tracker
{
	// Token: 0x0600073E RID: 1854
	public abstract bool Start();

	// Token: 0x0600073F RID: 1855
	public abstract void Stop();

	// Token: 0x06000740 RID: 1856 RVA: 0x0000382C File Offset: 0x00001A2C
	protected void PositionCamera(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00003830 File Offset: 0x00001A30
	protected void PositionTrackable(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	// Token: 0x020000ED RID: 237
	public enum Type
	{
		// Token: 0x0400049F RID: 1183
		IMAGE_TRACKER,
		// Token: 0x040004A0 RID: 1184
		MARKER_TRACKER
	}
}
