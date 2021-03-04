using System;
using System.Collections.Generic;

// Token: 0x020000E1 RID: 225
public abstract class StateManager
{
	// Token: 0x0600070F RID: 1807
	public abstract IEnumerable<TrackableBehaviour> GetActiveTrackableBehaviours();

	// Token: 0x06000710 RID: 1808
	public abstract IEnumerable<TrackableBehaviour> GetTrackableBehaviours();
}
