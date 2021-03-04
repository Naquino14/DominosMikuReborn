using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ArController : MonoBehaviour, ITrackableEventHandler
{
	public ArUIController _arUICtrl;

	public Camera _arCam;

	public Camera _modelCam;

	public Transform _arRoot;

	public Transform _hidePos;

	public Transform _showPos;

	private bool _isMarked;

	private bool _isInited;

	private TrackableBehaviour _curTrack;

	public TrackableBehaviour[] mTrackableBehaviours;

	public GameObject _effect1;

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

	public event Action onArInited
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

	public void Init()
	{
	}

	public void DeactiveArCamera()
	{
	}

	public void ActiveArCamera()
	{
	}

	public void ShowRoot()
	{
	}

	public void HideRoot()
	{
	}

	public void ActiveEffect()
	{
	}

	public void DeactiveEffect()
	{
	}

	public void ModelCamToDepth()
	{
	}

	public void ModelCamToSkybox()
	{
	}

	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	private void Update()
	{
	}

	private void ResetShowPos()
	{
	}
}
