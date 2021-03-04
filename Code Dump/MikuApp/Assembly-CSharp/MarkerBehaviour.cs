using UnityEngine;

public class MarkerBehaviour : TrackableBehaviour, IEditorMarkerBehaviour, IEditorTrackableBehaviour
{
	[HideInInspector]
	[SerializeField]
	private int mMarkerID;

	private Marker mMarker;

	int IEditorMarkerBehaviour.MarkerID => (int)/*Error near IL_0001: Stack underflow*/;

	public Marker Marker => (Marker)/*Error near IL_0001: Stack underflow*/;

	bool IEditorMarkerBehaviour.SetMarkerID(int markerID)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	void IEditorMarkerBehaviour.InitializeMarker(Marker marker)
	{
	}

	protected override void InternalUnregisterTrackable()
	{
	}

	protected override bool CorrectScaleImpl()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
