using System.Collections.Generic;
using UnityEngine;

public class UserDefinedTargetBuildingBehaviour : MonoBehaviour, ITrackerEventHandler
{
	private ImageTracker mImageTracker;

	private ImageTargetBuilder.FrameQuality mLastFrameQuality;

	private bool mCurrentlyScanning;

	private bool mWasScanningBeforeDisable;

	private bool mCurrentlyBuilding;

	private bool mWasBuildingBeforeDisable;

	private bool mOnInitializedCalled;

	private readonly List<IUserDefinedTargetEventHandler> mHandlers;

	public bool StopTrackerWhileScanning;

	public bool StartScanningAutomatically;

	public bool StopScanningWhenFinshedBuilding;

	public void RegisterEventHandler(IUserDefinedTargetEventHandler eventHandler)
	{
	}

	public bool UnregisterEventHandler(IUserDefinedTargetEventHandler eventHandler)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void StartScanning()
	{
	}

	public void BuildNewTarget(string targetName, float sceenSizeWidth)
	{
	}

	public void StopScanning()
	{
	}

	private void SetFrameQuality(ImageTargetBuilder.FrameQuality frameQuality)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnInitialized()
	{
	}

	public void OnTrackablesUpdated()
	{
	}
}
