using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000087 RID: 135
public class CloudRecoBehaviour : MonoBehaviour, ITrackerEventHandler
{
	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060003C2 RID: 962 RVA: 0x00002F28 File Offset: 0x00001128
	// (set) Token: 0x060003C3 RID: 963 RVA: 0x00002F2C File Offset: 0x0000112C
	public bool CloudRecoEnabled
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060003C4 RID: 964 RVA: 0x00002F30 File Offset: 0x00001130
	public bool CloudRecoInitialized
	{
		get
		{
		}
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00002F34 File Offset: 0x00001134
	private void Initialize()
	{
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00002F38 File Offset: 0x00001138
	private void Deinitialize()
	{
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00002F3C File Offset: 0x0000113C
	private void CheckInitialization()
	{
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00002F40 File Offset: 0x00001140
	private void StartCloudReco()
	{
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00002F44 File Offset: 0x00001144
	private void StopCloudReco()
	{
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00002F48 File Offset: 0x00001148
	public void RegisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00002F4C File Offset: 0x0000114C
	public bool UnregisterEventHandler(ICloudRecoEventHandler eventHandler)
	{
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00002F50 File Offset: 0x00001150
	private void OnEnable()
	{
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00002F54 File Offset: 0x00001154
	private void OnDisable()
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00002F58 File Offset: 0x00001158
	private void Start()
	{
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00002F5C File Offset: 0x0000115C
	private void Update()
	{
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002F60 File Offset: 0x00001160
	public void OnInitialized()
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002F64 File Offset: 0x00001164
	public void OnTrackablesUpdated()
	{
	}

	// Token: 0x04000385 RID: 901
	private ImageTracker mImageTracker;

	// Token: 0x04000386 RID: 902
	private bool mCurrentlyInitializing;

	// Token: 0x04000387 RID: 903
	private bool mInitSuccess;

	// Token: 0x04000388 RID: 904
	private bool mCloudRecoStarted;

	// Token: 0x04000389 RID: 905
	private bool mOnInitializedCalled;

	// Token: 0x0400038A RID: 906
	private readonly List<ICloudRecoEventHandler> mHandlers;

	// Token: 0x0400038B RID: 907
	public string AccessKey;

	// Token: 0x0400038C RID: 908
	public string SecretKey;

	// Token: 0x0400038D RID: 909
	public Color ScanlineColor;

	// Token: 0x0400038E RID: 910
	public Color FeaturePointColor;
}
