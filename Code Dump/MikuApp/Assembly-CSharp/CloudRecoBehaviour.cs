using System.Collections.Generic;
using UnityEngine;

public class CloudRecoBehaviour : MonoBehaviour, ITrackerEventHandler
{
	private ImageTracker mImageTracker;

	private bool mCurrentlyInitializing;

	private bool mInitSuccess;

	private bool mCloudRecoStarted;

	private bool mOnInitializedCalled;

	private readonly List<ICloudRecoEventHandler> mHandlers;

	public string AccessKey;

	public string SecretKey;

	public Color ScanlineColor;

	public Color FeaturePointColor;

	public bool CloudRecoEnabled
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public bool CloudRecoInitialized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	private void Initialize()
	{
	}

	private void Deinitialize()
	{
	}

	private void CheckInitialization()
	{
	}

	private void StartCloudReco()
	{
	}

	private void StopCloudReco()
	{
	}

	public void RegisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
	}

	public bool UnregisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnInitialized()
	{
	}

	public void OnTrackablesUpdated()
	{
	}
}
