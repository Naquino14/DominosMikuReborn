using System;

// Token: 0x02000090 RID: 144
public interface ITrackableEventHandler
{
	// Token: 0x060003FB RID: 1019
	void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus);
}
