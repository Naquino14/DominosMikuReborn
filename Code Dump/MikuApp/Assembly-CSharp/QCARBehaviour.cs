using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class QCARBehaviour : MonoBehaviour
{
	public enum WorldCenterMode
	{
		USER,
		AUTO,
		NONE
	}

	private enum CameraState
	{
		UNINITED,
		DEVICE_INITED,
		RENDERING_INITED
	}

	[SerializeField]
	protected CameraDevice.CameraDeviceMode CameraDeviceModeSetting;

	[SerializeField]
	private int MaxSimultaneousImageTargets;

	[SerializeField]
	private bool SynchronousVideo;

	[SerializeField]
	[HideInInspector]
	protected WorldCenterMode mWorldCenterMode;

	[HideInInspector]
	[SerializeField]
	private TrackableBehaviour mWorldCenter;

	[SerializeField]
	protected CameraDevice.CameraDirection CameraDirection;

	[SerializeField]
	private QCARRenderer.VideoBackgroundReflection MirrorVideoBackground;

	private List<ITrackerEventHandler> mTrackerEventHandlers;

	private List<IVideoBackgroundEventHandler> mVideoBgEventHandlers;

	private bool mIsInitialized;

	private CameraState mCameraState;

	private Material mClearMaterial;

	private Rect mViewportRect;

	private int mClearBuffers;

	private bool mHasStartedOnce;

	private ScreenOrientation mProjectionOrientation;

	private bool mCachedDrawVideoBackground;

	private CameraClearFlags mCachedCameraClearFlags;

	private Color mCachedCameraBackgroundColor;

	public WorldCenterMode WorldCenterModeSetting => (WorldCenterMode)/*Error near IL_0001: Stack underflow*/;

	public TrackableBehaviour WorldCenter => (TrackableBehaviour)/*Error near IL_0001: Stack underflow*/;

	public bool VideoBackGroundMirrored
	{
		[CompilerGenerated]
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void RegisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
	}

	public bool UnregisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void RegisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
	}

	public bool UnregisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void SetWorldCenterMode(WorldCenterMode value)
	{
	}

	public void SetWorldCenter(TrackableBehaviour value)
	{
	}

	public Rect GetViewportRectangle()
	{
		return (Rect)/*Error near IL_0001: Stack underflow*/;
	}

	public ScreenOrientation GetSurfaceOrientation()
	{
		return (ScreenOrientation)/*Error near IL_0001: Stack underflow*/;
	}

	public void ConfigureVideoBackground(bool forceReflectionSetting)
	{
	}

	public void ResetClearBuffers()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnPreRender()
	{
	}

	private void OnPostRender()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void StartQCAR()
	{
	}

	protected virtual void StopQCAR()
	{
	}

	private void ResetCameraClearFlags()
	{
	}

	private void UpdateCameraClearFlags()
	{
	}

	protected void UpdateProjection(ScreenOrientation orientation)
	{
	}
}
