using System;

// Token: 0x020000EE RID: 238
public abstract class TrackerManager
{
	// Token: 0x17000122 RID: 290
	// (get) Token: 0x06000744 RID: 1860 RVA: 0x0000383C File Offset: 0x00001A3C
	public static TrackerManager Instance
	{
		get
		{
		}
	}

	// Token: 0x06000745 RID: 1861
	public abstract Tracker GetTracker(Tracker.Type trackerType);

	// Token: 0x06000746 RID: 1862
	public abstract Tracker InitTracker(Tracker.Type trackerType);

	// Token: 0x06000747 RID: 1863
	public abstract bool DeinitTracker(Tracker.Type trackerType);

	// Token: 0x06000748 RID: 1864
	public abstract StateManager GetStateManager();

	// Token: 0x040004A1 RID: 1185
	private static TrackerManager mInstance;
}
