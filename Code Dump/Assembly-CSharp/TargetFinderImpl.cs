using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020000BA RID: 186
public class TargetFinderImpl : TargetFinder
{
	// Token: 0x0600052A RID: 1322 RVA: 0x00003308 File Offset: 0x00001508
	protected override void Finalize()
	{
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0000330C File Offset: 0x0000150C
	public override bool StartInit(string userAuth, string secretAuth)
	{
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00003310 File Offset: 0x00001510
	public override TargetFinder.InitState GetInitState()
	{
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00003314 File Offset: 0x00001514
	public override bool Deinit()
	{
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00003318 File Offset: 0x00001518
	public override bool StartRecognition()
	{
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0000331C File Offset: 0x0000151C
	public override bool Stop()
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00003320 File Offset: 0x00001520
	public override void SetUIScanlineColor(Color color)
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00003324 File Offset: 0x00001524
	public override void SetUIPointColor(Color color)
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00003328 File Offset: 0x00001528
	public override bool IsRequesting()
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0000332C File Offset: 0x0000152C
	public override TargetFinder.UpdateState Update()
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00003330 File Offset: 0x00001530
	public override IEnumerable<TargetFinder.TargetSearchResult> GetResults()
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00003334 File Offset: 0x00001534
	public override ImageTargetBehaviour EnableTracking(TargetFinder.TargetSearchResult result, string gameObjectName)
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00003338 File Offset: 0x00001538
	public override ImageTargetBehaviour EnableTracking(TargetFinder.TargetSearchResult result, GameObject gameObject)
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0000333C File Offset: 0x0000153C
	public override void ClearTrackables(bool destroyGameObjects = true)
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00003340 File Offset: 0x00001540
	public override IEnumerable<ImageTarget> GetImageTargets()
	{
	}

	// Token: 0x04000402 RID: 1026
	private IntPtr mTargetFinderStatePtr;

	// Token: 0x04000403 RID: 1027
	private TargetFinderImpl.TargetFinderState mTargetFinderState;

	// Token: 0x04000404 RID: 1028
	private List<TargetFinder.TargetSearchResult> mNewResults;

	// Token: 0x04000405 RID: 1029
	private Dictionary<int, ImageTarget> mImageTargets;

	// Token: 0x020000BB RID: 187
	[StructLayout(0, Pack = 1)]
	private struct TargetFinderState
	{
		// Token: 0x04000406 RID: 1030
		public int IsRequesting;

		// Token: 0x04000407 RID: 1031
		[MarshalAs(31)]
		public TargetFinder.UpdateState UpdateState;

		// Token: 0x04000408 RID: 1032
		public int ResultCount;
	}

	// Token: 0x020000BC RID: 188
	[StructLayout(0, Pack = 1)]
	private struct InternalTargetSearchResult
	{
		// Token: 0x04000409 RID: 1033
		public IntPtr TargetNamePtr;

		// Token: 0x0400040A RID: 1034
		public IntPtr UniqueTargetIdPtr;

		// Token: 0x0400040B RID: 1035
		public float TargetSize;

		// Token: 0x0400040C RID: 1036
		public IntPtr MetaDataPtr;

		// Token: 0x0400040D RID: 1037
		public IntPtr TargetSearchResultPtr;

		// Token: 0x0400040E RID: 1038
		public byte TrackingRating;
	}
}
