using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000F0 RID: 240
public class UserDefinedTargetBuildingBehaviour : MonoBehaviour, ITrackerEventHandler
{
	// Token: 0x0600074C RID: 1868 RVA: 0x0000384C File Offset: 0x00001A4C
	public void RegisterEventHandler(IUserDefinedTargetEventHandler eventHandler)
	{
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00003850 File Offset: 0x00001A50
	public bool UnregisterEventHandler(IUserDefinedTargetEventHandler eventHandler)
	{
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00003854 File Offset: 0x00001A54
	public void StartScanning()
	{
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00003858 File Offset: 0x00001A58
	public void BuildNewTarget(string targetName, float sceenSizeWidth)
	{
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x0000385C File Offset: 0x00001A5C
	public void StopScanning()
	{
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00003860 File Offset: 0x00001A60
	private void SetFrameQuality(ImageTargetBuilder.FrameQuality frameQuality)
	{
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00003864 File Offset: 0x00001A64
	private void Start()
	{
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00003868 File Offset: 0x00001A68
	private void Update()
	{
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x0000386C File Offset: 0x00001A6C
	private void OnApplicationPause(bool pause)
	{
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x00003870 File Offset: 0x00001A70
	private void OnEnable()
	{
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x00003874 File Offset: 0x00001A74
	private void OnDisable()
	{
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00003878 File Offset: 0x00001A78
	public void OnInitialized()
	{
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x0000387C File Offset: 0x00001A7C
	public void OnTrackablesUpdated()
	{
	}

	// Token: 0x040004A2 RID: 1186
	private ImageTracker mImageTracker;

	// Token: 0x040004A3 RID: 1187
	private ImageTargetBuilder.FrameQuality mLastFrameQuality;

	// Token: 0x040004A4 RID: 1188
	private bool mCurrentlyScanning;

	// Token: 0x040004A5 RID: 1189
	private bool mWasScanningBeforeDisable;

	// Token: 0x040004A6 RID: 1190
	private bool mCurrentlyBuilding;

	// Token: 0x040004A7 RID: 1191
	private bool mWasBuildingBeforeDisable;

	// Token: 0x040004A8 RID: 1192
	private bool mOnInitializedCalled;

	// Token: 0x040004A9 RID: 1193
	private readonly List<IUserDefinedTargetEventHandler> mHandlers;

	// Token: 0x040004AA RID: 1194
	public bool StopTrackerWhileScanning;

	// Token: 0x040004AB RID: 1195
	public bool StartScanningAutomatically;

	// Token: 0x040004AC RID: 1196
	public bool StopScanningWhenFinshedBuilding;
}
