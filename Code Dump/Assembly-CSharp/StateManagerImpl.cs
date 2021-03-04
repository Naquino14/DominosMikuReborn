using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000B9 RID: 185
public class StateManagerImpl : StateManager
{
	// Token: 0x06000512 RID: 1298 RVA: 0x000032A8 File Offset: 0x000014A8
	public override IEnumerable<TrackableBehaviour> GetActiveTrackableBehaviours()
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x000032AC File Offset: 0x000014AC
	public override IEnumerable<TrackableBehaviour> GetTrackableBehaviours()
	{
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x000032B0 File Offset: 0x000014B0
	public void AssociateMarkerBehaviours()
	{
	}

	// Token: 0x06000515 RID: 1301 RVA: 0x000032B4 File Offset: 0x000014B4
	public void AssociateTrackableBehavioursForDataSet(DataSet dataSet)
	{
	}

	// Token: 0x06000516 RID: 1302 RVA: 0x000032B8 File Offset: 0x000014B8
	public void ClearTrackableBehaviours()
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x000032BC File Offset: 0x000014BC
	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject)
	{
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x000032C0 File Offset: 0x000014C0
	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject, DataSet dataSet)
	{
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x000032C4 File Offset: 0x000014C4
	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, string gameObjectName)
	{
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x000032C8 File Offset: 0x000014C8
	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, GameObject gameObject)
	{
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x000032CC File Offset: 0x000014CC
	public void DestroyTrackableBehavioursForTrackable(Trackable trackable, bool destroyGameObjects = true)
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x000032D0 File Offset: 0x000014D0
	public void SetTrackableBehavioursForTrackableToNotFound(Trackable trackable)
	{
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x000032D4 File Offset: 0x000014D4
	public void EnableTrackableBehavioursForTrackable(Trackable trackable, bool enabled)
	{
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x000032D8 File Offset: 0x000014D8
	public void RemoveDisabledTrackablesFromQueue(ref LinkedList<int> trackableIDs)
	{
	}

	// Token: 0x0600051F RID: 1311 RVA: 0x000032DC File Offset: 0x000014DC
	public void UpdateCameraPose(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x000032E0 File Offset: 0x000014E0
	public void UpdateTrackablePoses(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	// Token: 0x06000521 RID: 1313 RVA: 0x000032E4 File Offset: 0x000014E4
	public void UpdateVirtualButtons(int numVirtualButtons, IntPtr virtualButtonPtr)
	{
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x000032E8 File Offset: 0x000014E8
	private void AssociateVirtualButtonBehaviours(VirtualButtonBehaviour[] vbBehaviours, DataSet dataSet)
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x000032EC File Offset: 0x000014EC
	private void CreateMissingDataSetTrackableBehaviours(DataSet dataSet)
	{
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x000032F0 File Offset: 0x000014F0
	private ImageTargetBehaviour CreateImageTargetBehaviour(ImageTarget imageTarget)
	{
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x000032F4 File Offset: 0x000014F4
	private MultiTargetBehaviour CreateMultiTargetBehaviour(MultiTarget multiTarget)
	{
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x000032F8 File Offset: 0x000014F8
	private void InitializeMarkerBehaviour(MarkerBehaviour markerBehaviour, Marker marker)
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x000032FC File Offset: 0x000014FC
	private void PositionCamera(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00003300 File Offset: 0x00001500
	private void PositionTrackable(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	// Token: 0x04000400 RID: 1024
	private readonly Dictionary<int, TrackableBehaviour> mTrackableBehaviours;

	// Token: 0x04000401 RID: 1025
	private readonly List<TrackableBehaviour> mActiveTrackableBehaviours;
}
