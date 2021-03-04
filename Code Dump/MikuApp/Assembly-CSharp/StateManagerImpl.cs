using System;
using System.Collections.Generic;
using UnityEngine;

public class StateManagerImpl : StateManager
{
	private readonly Dictionary<int, TrackableBehaviour> mTrackableBehaviours;

	private readonly List<TrackableBehaviour> mActiveTrackableBehaviours;

	public override IEnumerable<TrackableBehaviour> GetActiveTrackableBehaviours()
	{
		return (IEnumerable<TrackableBehaviour>)/*Error near IL_0001: Stack underflow*/;
	}

	public override IEnumerable<TrackableBehaviour> GetTrackableBehaviours()
	{
		return (IEnumerable<TrackableBehaviour>)/*Error near IL_0001: Stack underflow*/;
	}

	public void AssociateMarkerBehaviours()
	{
	}

	public void AssociateTrackableBehavioursForDataSet(DataSet dataSet)
	{
	}

	public void ClearTrackableBehaviours()
	{
	}

	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject)
	{
		return (ImageTargetBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public ImageTargetBehaviour FindOrCreateImageTargetBehaviourForTrackable(ImageTarget trackable, GameObject gameObject, DataSet dataSet)
	{
		return (ImageTargetBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, string gameObjectName)
	{
		return (MarkerBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public MarkerBehaviour CreateNewMarkerBehaviourForMarker(Marker trackable, GameObject gameObject)
	{
		return (MarkerBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public void DestroyTrackableBehavioursForTrackable(Trackable trackable, bool destroyGameObjects = true)
	{
	}

	public void SetTrackableBehavioursForTrackableToNotFound(Trackable trackable)
	{
	}

	public void EnableTrackableBehavioursForTrackable(Trackable trackable, bool enabled)
	{
	}

	public void RemoveDisabledTrackablesFromQueue(ref LinkedList<int> trackableIDs)
	{
	}

	public void UpdateCameraPose(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	public void UpdateTrackablePoses(Camera arCamera, QCARManagerImpl.TrackableResultData[] trackableResultDataArray, int originTrackableID)
	{
	}

	public void UpdateVirtualButtons(int numVirtualButtons, IntPtr virtualButtonPtr)
	{
	}

	private void AssociateVirtualButtonBehaviours(VirtualButtonBehaviour[] vbBehaviours, DataSet dataSet)
	{
	}

	private void CreateMissingDataSetTrackableBehaviours(DataSet dataSet)
	{
	}

	private ImageTargetBehaviour CreateImageTargetBehaviour(ImageTarget imageTarget)
	{
		return (ImageTargetBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	private MultiTargetBehaviour CreateMultiTargetBehaviour(MultiTarget multiTarget)
	{
		return (MultiTargetBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	private void InitializeMarkerBehaviour(MarkerBehaviour markerBehaviour, Marker marker)
	{
	}

	private void PositionCamera(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}

	private void PositionTrackable(TrackableBehaviour trackableBehaviour, Camera arCamera, QCARManagerImpl.PoseData camToTargetPose)
	{
	}
}
