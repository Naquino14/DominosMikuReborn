using System;

// Token: 0x020000A4 RID: 164
public interface IEditorMarkerBehaviour : IEditorTrackableBehaviour
{
	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000480 RID: 1152
	int MarkerID { get; }

	// Token: 0x06000481 RID: 1153
	bool SetMarkerID(int markerID);

	// Token: 0x06000482 RID: 1154
	void InitializeMarker(Marker marker);
}
