using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class TargetFinder
{
	public enum InitState
	{
		INIT_DEFAULT = 0,
		INIT_RUNNING = 1,
		INIT_SUCCESS = 2,
		INIT_ERROR_NO_NETWORK_CONNECTION = -1,
		INIT_ERROR_SERVICE_NOT_AVAILABLE = -2
	}

	public enum UpdateState
	{
		UPDATE_NO_MATCH = 0,
		UPDATE_NO_REQUEST = 1,
		UPDATE_RESULTS_AVAILABLE = 2,
		UPDATE_ERROR_AUTHORIZATION_FAILED = -1,
		UPDATE_ERROR_PROJECT_SUSPENDED = -2,
		UPDATE_ERROR_NO_NETWORK_CONNECTION = -3,
		UPDATE_ERROR_SERVICE_NOT_AVAILABLE = -4,
		UPDATE_ERROR_BAD_FRAME_QUALITY = -5,
		UPDATE_ERROR_UPDATE_SDK = -6,
		UPDATE_ERROR_TIMESTAMP_OUT_OF_RANGE = -7,
		UPDATE_ERROR_REQUEST_TIMEOUT = -8
	}

	public struct TargetSearchResult
	{
		public string TargetName;

		public string UniqueTargetId;

		public float TargetSize;

		public string MetaData;

		public byte TrackingRating;

		public IntPtr TargetSearchResultPtr;
	}

	public abstract bool StartInit(string userAuth, string secretAuth);

	public abstract InitState GetInitState();

	public abstract bool Deinit();

	public abstract bool StartRecognition();

	public abstract bool Stop();

	public abstract void SetUIScanlineColor(Color color);

	public abstract void SetUIPointColor(Color color);

	public abstract bool IsRequesting();

	public abstract UpdateState Update();

	public abstract IEnumerable<TargetSearchResult> GetResults();

	public abstract ImageTargetBehaviour EnableTracking(TargetSearchResult result, string gameObjectName);

	public abstract ImageTargetBehaviour EnableTracking(TargetSearchResult result, GameObject gameObject);

	public abstract void ClearTrackables(bool destroyGameObjects = true);

	public abstract IEnumerable<ImageTarget> GetImageTargets();
}
