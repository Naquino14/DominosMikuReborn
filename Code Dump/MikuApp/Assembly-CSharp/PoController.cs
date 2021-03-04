using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PoController : MonoBehaviour, ITrackableEventHandler
{
	public Camera _arCam;

	public MaxCamera _modelCam;

	public Transform _modelCenter;

	public Transform _mikuContainer;

	public TrackableBehaviour[] mTrackableBehaviours;

	private TrackableBehaviour _curTrack;

	public event Action<string> onTrackingFound
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	public event Action onTrackingLost
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void GetCurrentTrack()
	{
	}

	public void DeactiveArCamera()
	{
	}

	public void ActiveArCamera()
	{
	}

	public void ModelCamToDepth()
	{
	}

	public void ModelCamToSkybox()
	{
	}

	public void ResetModel()
	{
	}

	public void ResetNeko(GameObject go)
	{
	}
}
