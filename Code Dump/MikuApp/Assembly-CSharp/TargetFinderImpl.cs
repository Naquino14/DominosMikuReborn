using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class TargetFinderImpl : TargetFinder
{
	[StructLayout(0, Pack = 1)]
	private struct TargetFinderState
	{
		public int IsRequesting;

		[MarshalAs(31)]
		public UpdateState UpdateState;

		public int ResultCount;
	}

	[StructLayout(0, Pack = 1)]
	private struct InternalTargetSearchResult
	{
		public IntPtr TargetNamePtr;

		public IntPtr UniqueTargetIdPtr;

		public float TargetSize;

		public IntPtr MetaDataPtr;

		public IntPtr TargetSearchResultPtr;

		public byte TrackingRating;
	}

	private IntPtr mTargetFinderStatePtr;

	private TargetFinderState mTargetFinderState;

	private List<TargetSearchResult> mNewResults;

	private Dictionary<int, ImageTarget> mImageTargets;

	~TargetFinderImpl()
	{
	}

	public override bool StartInit(string userAuth, string secretAuth)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override InitState GetInitState()
	{
		return (InitState)/*Error near IL_0001: Stack underflow*/;
	}

	public override bool Deinit()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool StartRecognition()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool Stop()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override void SetUIScanlineColor(Color color)
	{
	}

	public override void SetUIPointColor(Color color)
	{
	}

	public override bool IsRequesting()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override UpdateState Update()
	{
		return (UpdateState)/*Error near IL_0001: Stack underflow*/;
	}

	public override IEnumerable<TargetSearchResult> GetResults()
	{
		return (IEnumerable<TargetSearchResult>)/*Error near IL_0001: Stack underflow*/;
	}

	public override ImageTargetBehaviour EnableTracking(TargetSearchResult result, string gameObjectName)
	{
		return (ImageTargetBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public override ImageTargetBehaviour EnableTracking(TargetSearchResult result, GameObject gameObject)
	{
		return (ImageTargetBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public override void ClearTrackables(bool destroyGameObjects = true)
	{
	}

	public override IEnumerable<ImageTarget> GetImageTargets()
	{
		return (IEnumerable<ImageTarget>)/*Error near IL_0001: Stack underflow*/;
	}
}
