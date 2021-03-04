public interface IEditorMarkerBehaviour : IEditorTrackableBehaviour
{
	int MarkerID
	{
		get;
	}

	bool SetMarkerID(int markerID);

	void InitializeMarker(Marker marker);
}
