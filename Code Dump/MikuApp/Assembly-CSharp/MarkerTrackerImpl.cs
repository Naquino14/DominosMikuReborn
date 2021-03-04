using System.Collections.Generic;

public class MarkerTrackerImpl : MarkerTracker
{
	private readonly Dictionary<int, Marker> mMarkerDict;

	public override bool Start()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override void Stop()
	{
	}

	public override MarkerBehaviour CreateMarker(int markerID, string trackableName, float size)
	{
		return (MarkerBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public override bool DestroyMarker(Marker marker, bool destroyGameObject)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override IEnumerable<Marker> GetMarkers()
	{
		return (IEnumerable<Marker>)/*Error near IL_0001: Stack underflow*/;
	}

	public override Marker GetMarkerByMarkerID(int markerID)
	{
		return (Marker)/*Error near IL_0001: Stack underflow*/;
	}

	public Marker InternalCreateMarker(int markerID, string name, float size)
	{
		return (Marker)/*Error near IL_0001: Stack underflow*/;
	}

	public override void DestroyAllMarkers(bool destroyGameObject)
	{
	}

	private int RegisterMarker(int markerID, string trackableName, float size)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}
}
