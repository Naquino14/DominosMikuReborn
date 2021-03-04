using UnityEngine;

public class TestMarker2Controller : MonoBehaviour, ITrackableEventHandler
{
	public GameObject restObject;

	public GameObject rootObj;

	public GameObject targetTr;

	private bool isMarked;

	public TrackableBehaviour mTrackableBehaviour;

	private void Start()
	{
	}

	private void Update()
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
