using UnityEngine;

public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
	private TrackableBehaviour mTrackableBehaviour;

	private void Start()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void OnTrackingFound()
	{
	}

	private void OnTrackingLost()
	{
	}
}
