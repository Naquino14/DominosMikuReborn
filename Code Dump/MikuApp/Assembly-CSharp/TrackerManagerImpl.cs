public class TrackerManagerImpl : TrackerManager
{
	private ImageTracker mImageTracker;

	private MarkerTracker mMarkerTracker;

	private StateManager mStateManager;

	public override Tracker GetTracker(Tracker.Type trackerType)
	{
		return (Tracker)/*Error near IL_0001: Stack underflow*/;
	}

	public override Tracker InitTracker(Tracker.Type trackerType)
	{
		return (Tracker)/*Error near IL_0001: Stack underflow*/;
	}

	public override bool DeinitTracker(Tracker.Type trackerType)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override StateManager GetStateManager()
	{
		return (StateManager)/*Error near IL_0001: Stack underflow*/;
	}
}
