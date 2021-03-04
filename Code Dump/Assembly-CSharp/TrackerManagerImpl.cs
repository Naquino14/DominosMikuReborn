using System;

// Token: 0x020000C0 RID: 192
public class TrackerManagerImpl : TrackerManager
{
	// Token: 0x06000549 RID: 1353 RVA: 0x00003384 File Offset: 0x00001584
	public override Tracker GetTracker(Tracker.Type trackerType)
	{
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00003388 File Offset: 0x00001588
	public override Tracker InitTracker(Tracker.Type trackerType)
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0000338C File Offset: 0x0000158C
	public override bool DeinitTracker(Tracker.Type trackerType)
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00003390 File Offset: 0x00001590
	public override StateManager GetStateManager()
	{
	}

	// Token: 0x04000416 RID: 1046
	private ImageTracker mImageTracker;

	// Token: 0x04000417 RID: 1047
	private MarkerTracker mMarkerTracker;

	// Token: 0x04000418 RID: 1048
	private StateManager mStateManager;
}
