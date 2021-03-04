using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000E2 RID: 226
public abstract class TargetFinder
{
	// Token: 0x06000712 RID: 1810
	public abstract bool StartInit(string userAuth, string secretAuth);

	// Token: 0x06000713 RID: 1811
	public abstract TargetFinder.InitState GetInitState();

	// Token: 0x06000714 RID: 1812
	public abstract bool Deinit();

	// Token: 0x06000715 RID: 1813
	public abstract bool StartRecognition();

	// Token: 0x06000716 RID: 1814
	public abstract bool Stop();

	// Token: 0x06000717 RID: 1815
	public abstract void SetUIScanlineColor(Color color);

	// Token: 0x06000718 RID: 1816
	public abstract void SetUIPointColor(Color color);

	// Token: 0x06000719 RID: 1817
	public abstract bool IsRequesting();

	// Token: 0x0600071A RID: 1818
	public abstract TargetFinder.UpdateState Update();

	// Token: 0x0600071B RID: 1819
	public abstract IEnumerable<TargetFinder.TargetSearchResult> GetResults();

	// Token: 0x0600071C RID: 1820
	public abstract ImageTargetBehaviour EnableTracking(TargetFinder.TargetSearchResult result, string gameObjectName);

	// Token: 0x0600071D RID: 1821
	public abstract ImageTargetBehaviour EnableTracking(TargetFinder.TargetSearchResult result, GameObject gameObject);

	// Token: 0x0600071E RID: 1822
	public abstract void ClearTrackables(bool destroyGameObjects = true);

	// Token: 0x0600071F RID: 1823
	public abstract IEnumerable<ImageTarget> GetImageTargets();

	// Token: 0x020000E3 RID: 227
	public enum InitState
	{
		// Token: 0x04000474 RID: 1140
		INIT_DEFAULT,
		// Token: 0x04000475 RID: 1141
		INIT_RUNNING,
		// Token: 0x04000476 RID: 1142
		INIT_SUCCESS,
		// Token: 0x04000477 RID: 1143
		INIT_ERROR_NO_NETWORK_CONNECTION = -1,
		// Token: 0x04000478 RID: 1144
		INIT_ERROR_SERVICE_NOT_AVAILABLE = -2
	}

	// Token: 0x020000E4 RID: 228
	public enum UpdateState
	{
		// Token: 0x0400047A RID: 1146
		UPDATE_NO_MATCH,
		// Token: 0x0400047B RID: 1147
		UPDATE_NO_REQUEST,
		// Token: 0x0400047C RID: 1148
		UPDATE_RESULTS_AVAILABLE,
		// Token: 0x0400047D RID: 1149
		UPDATE_ERROR_AUTHORIZATION_FAILED = -1,
		// Token: 0x0400047E RID: 1150
		UPDATE_ERROR_PROJECT_SUSPENDED = -2,
		// Token: 0x0400047F RID: 1151
		UPDATE_ERROR_NO_NETWORK_CONNECTION = -3,
		// Token: 0x04000480 RID: 1152
		UPDATE_ERROR_SERVICE_NOT_AVAILABLE = -4,
		// Token: 0x04000481 RID: 1153
		UPDATE_ERROR_BAD_FRAME_QUALITY = -5,
		// Token: 0x04000482 RID: 1154
		UPDATE_ERROR_UPDATE_SDK = -6,
		// Token: 0x04000483 RID: 1155
		UPDATE_ERROR_TIMESTAMP_OUT_OF_RANGE = -7,
		// Token: 0x04000484 RID: 1156
		UPDATE_ERROR_REQUEST_TIMEOUT = -8
	}

	// Token: 0x020000E5 RID: 229
	public struct TargetSearchResult
	{
		// Token: 0x04000485 RID: 1157
		public string TargetName;

		// Token: 0x04000486 RID: 1158
		public string UniqueTargetId;

		// Token: 0x04000487 RID: 1159
		public float TargetSize;

		// Token: 0x04000488 RID: 1160
		public string MetaData;

		// Token: 0x04000489 RID: 1161
		public byte TrackingRating;

		// Token: 0x0400048A RID: 1162
		public IntPtr TargetSearchResultPtr;
	}
}
