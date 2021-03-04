using System.Collections.Generic;

public abstract class MarkerTracker : Tracker
{
	public abstract MarkerBehaviour CreateMarker(int markerID, string trackableName, float size);

	public abstract bool DestroyMarker(Marker marker, bool destroyGameObject);

	public abstract IEnumerable<Marker> GetMarkers();

	public abstract Marker GetMarkerByMarkerID(int markerID);

	public abstract void DestroyAllMarkers(bool destroyGameObject);
}
