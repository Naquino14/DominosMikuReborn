using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000D2 RID: 210
[RequireComponent(typeof(Camera))]
public class QCARBehaviour : MonoBehaviour
{
	// Token: 0x1700010B RID: 267
	// (get) Token: 0x060006C5 RID: 1733 RVA: 0x000036E4 File Offset: 0x000018E4
	public QCARBehaviour.WorldCenterMode WorldCenterModeSetting
	{
		get
		{
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x060006C6 RID: 1734 RVA: 0x000036E8 File Offset: 0x000018E8
	public TrackableBehaviour WorldCenter
	{
		get
		{
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000036EC File Offset: 0x000018EC
	// (set) Token: 0x060006C8 RID: 1736 RVA: 0x000036F0 File Offset: 0x000018F0
	public bool VideoBackGroundMirrored
	{
		[CompilerGenerated]
		get
		{
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x000036F4 File Offset: 0x000018F4
	public void RegisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x000036F8 File Offset: 0x000018F8
	public bool UnregisterTrackerEventHandler(ITrackerEventHandler trackerEventHandler)
	{
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x000036FC File Offset: 0x000018FC
	public void RegisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00003700 File Offset: 0x00001900
	public bool UnregisterVideoBgEventHandler(IVideoBackgroundEventHandler videoBgEventHandler)
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00003704 File Offset: 0x00001904
	public void SetWorldCenterMode(QCARBehaviour.WorldCenterMode value)
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00003708 File Offset: 0x00001908
	public void SetWorldCenter(TrackableBehaviour value)
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x0000370C File Offset: 0x0000190C
	public Rect GetViewportRectangle()
	{
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00003710 File Offset: 0x00001910
	public ScreenOrientation GetSurfaceOrientation()
	{
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00003714 File Offset: 0x00001914
	public void ConfigureVideoBackground(bool forceReflectionSetting)
	{
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00003718 File Offset: 0x00001918
	public void ResetClearBuffers()
	{
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x0000371C File Offset: 0x0000191C
	private void Start()
	{
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00003720 File Offset: 0x00001920
	private void OnEnable()
	{
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00003724 File Offset: 0x00001924
	private void Update()
	{
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00003728 File Offset: 0x00001928
	private void OnPreRender()
	{
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x0000372C File Offset: 0x0000192C
	private void OnPostRender()
	{
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00003730 File Offset: 0x00001930
	private void OnApplicationPause(bool pause)
	{
	}

	// Token: 0x060006D9 RID: 1753 RVA: 0x00003734 File Offset: 0x00001934
	private void OnDisable()
	{
	}

	// Token: 0x060006DA RID: 1754 RVA: 0x00003738 File Offset: 0x00001938
	private void OnDestroy()
	{
	}

	// Token: 0x060006DB RID: 1755 RVA: 0x0000373C File Offset: 0x0000193C
	protected virtual void StartQCAR()
	{
	}

	// Token: 0x060006DC RID: 1756 RVA: 0x00003740 File Offset: 0x00001940
	protected virtual void StopQCAR()
	{
	}

	// Token: 0x060006DD RID: 1757 RVA: 0x00003744 File Offset: 0x00001944
	private void ResetCameraClearFlags()
	{
	}

	// Token: 0x060006DE RID: 1758 RVA: 0x00003748 File Offset: 0x00001948
	private void UpdateCameraClearFlags()
	{
	}

	// Token: 0x060006DF RID: 1759 RVA: 0x0000374C File Offset: 0x0000194C
	protected void UpdateProjection(ScreenOrientation orientation)
	{
	}

	// Token: 0x0400043C RID: 1084
	[SerializeField]
	protected CameraDevice.CameraDeviceMode CameraDeviceModeSetting;

	// Token: 0x0400043D RID: 1085
	[SerializeField]
	private int MaxSimultaneousImageTargets;

	// Token: 0x0400043E RID: 1086
	[SerializeField]
	private bool SynchronousVideo;

	// Token: 0x0400043F RID: 1087
	[SerializeField]
	[HideInInspector]
	protected QCARBehaviour.WorldCenterMode mWorldCenterMode;

	// Token: 0x04000440 RID: 1088
	[HideInInspector]
	[SerializeField]
	private TrackableBehaviour mWorldCenter;

	// Token: 0x04000441 RID: 1089
	[SerializeField]
	protected CameraDevice.CameraDirection CameraDirection;

	// Token: 0x04000442 RID: 1090
	[SerializeField]
	private QCARRenderer.VideoBackgroundReflection MirrorVideoBackground;

	// Token: 0x04000443 RID: 1091
	private List<ITrackerEventHandler> mTrackerEventHandlers;

	// Token: 0x04000444 RID: 1092
	private List<IVideoBackgroundEventHandler> mVideoBgEventHandlers;

	// Token: 0x04000445 RID: 1093
	private bool mIsInitialized;

	// Token: 0x04000446 RID: 1094
	private QCARBehaviour.CameraState mCameraState;

	// Token: 0x04000447 RID: 1095
	private Material mClearMaterial;

	// Token: 0x04000448 RID: 1096
	private Rect mViewportRect;

	// Token: 0x04000449 RID: 1097
	private int mClearBuffers;

	// Token: 0x0400044A RID: 1098
	private bool mHasStartedOnce;

	// Token: 0x0400044B RID: 1099
	private ScreenOrientation mProjectionOrientation;

	// Token: 0x0400044C RID: 1100
	private bool mCachedDrawVideoBackground;

	// Token: 0x0400044D RID: 1101
	private CameraClearFlags mCachedCameraClearFlags;

	// Token: 0x0400044E RID: 1102
	private Color mCachedCameraBackgroundColor;

	// Token: 0x020000D3 RID: 211
	public enum WorldCenterMode
	{
		// Token: 0x04000451 RID: 1105
		USER,
		// Token: 0x04000452 RID: 1106
		AUTO,
		// Token: 0x04000453 RID: 1107
		NONE
	}

	// Token: 0x020000D4 RID: 212
	private enum CameraState
	{
		// Token: 0x04000455 RID: 1109
		UNINITED,
		// Token: 0x04000456 RID: 1110
		DEVICE_INITED,
		// Token: 0x04000457 RID: 1111
		RENDERING_INITED
	}
}
