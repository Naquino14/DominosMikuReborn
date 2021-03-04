using System;
using System.Collections.Generic;

// Token: 0x020000CE RID: 206
public abstract class MarkerTracker : Tracker
{
	// Token: 0x060006B9 RID: 1721
	public abstract MarkerBehaviour CreateMarker(int markerID, string trackableName, float size);

	// Token: 0x060006BA RID: 1722
	public abstract bool DestroyMarker(Marker marker, bool destroyGameObject);

	// Token: 0x060006BB RID: 1723
	public abstract IEnumerable<Marker> GetMarkers();

	// Token: 0x060006BC RID: 1724
	public abstract Marker GetMarkerByMarkerID(int markerID);

	// Token: 0x060006BD RID: 1725
	public abstract void DestroyAllMarkers(bool destroyGameObject);
}
