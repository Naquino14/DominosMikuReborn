public abstract class TrackerManager
{
	private static TrackerManager mInstance;

	public static TrackerManager Instance => (TrackerManager)/*Error near IL_0001: Stack underflow*/;

	public abstract Tracker GetTracker(Tracker.Type trackerType);

	public abstract Tracker InitTracker(Tracker.Type trackerType);

	public abstract bool DeinitTracker(Tracker.Type trackerType);

	public abstract StateManager GetStateManager();
}
