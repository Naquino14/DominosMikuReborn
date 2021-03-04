using System.Collections.Generic;

public abstract class StateManager
{
	public abstract IEnumerable<TrackableBehaviour> GetActiveTrackableBehaviours();

	public abstract IEnumerable<TrackableBehaviour> GetTrackableBehaviours();
}
