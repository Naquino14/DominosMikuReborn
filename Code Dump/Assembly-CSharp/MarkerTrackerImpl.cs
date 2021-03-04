using System;
using System.Collections.Generic;

// Token: 0x020000AD RID: 173
public class MarkerTrackerImpl : MarkerTracker
{
	// Token: 0x060004DD RID: 1245 RVA: 0x000031D4 File Offset: 0x000013D4
	public override bool Start()
	{
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x000031D8 File Offset: 0x000013D8
	public override void Stop()
	{
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x000031DC File Offset: 0x000013DC
	public override MarkerBehaviour CreateMarker(int markerID, string trackableName, float size)
	{
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x000031E0 File Offset: 0x000013E0
	public override bool DestroyMarker(Marker marker, bool destroyGameObject)
	{
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x000031E4 File Offset: 0x000013E4
	public override IEnumerable<Marker> GetMarkers()
	{
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x000031E8 File Offset: 0x000013E8
	public override Marker GetMarkerByMarkerID(int markerID)
	{
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x000031EC File Offset: 0x000013EC
	public Marker InternalCreateMarker(int markerID, string name, float size)
	{
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x000031F0 File Offset: 0x000013F0
	public override void DestroyAllMarkers(bool destroyGameObject)
	{
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x000031F4 File Offset: 0x000013F4
	private int RegisterMarker(int markerID, string trackableName, float size)
	{
	}

	// Token: 0x040003D6 RID: 982
	private readonly Dictionary<int, Marker> mMarkerDict;
}
