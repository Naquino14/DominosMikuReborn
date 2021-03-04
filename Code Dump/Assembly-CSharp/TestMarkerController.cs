using System;
using UnityEngine;

// Token: 0x02000146 RID: 326
public class TestMarkerController : MonoBehaviour, ITrackableEventHandler
{
	// Token: 0x06000B08 RID: 2824 RVA: 0x0000471C File Offset: 0x0000291C
	private void Start()
	{
	}

	// Token: 0x06000B09 RID: 2825 RVA: 0x00004720 File Offset: 0x00002920
	private void Update()
	{
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x00004724 File Offset: 0x00002924
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	// Token: 0x06000B0B RID: 2827 RVA: 0x00004728 File Offset: 0x00002928
	private void OnTrackingFound()
	{
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x0000472C File Offset: 0x0000292C
	private void OnTrackingLost()
	{
	}

	// Token: 0x0400070A RID: 1802
	public GameObject restObject;

	// Token: 0x0400070B RID: 1803
	public GameObject rootObj;

	// Token: 0x0400070C RID: 1804
	public GameObject targetTr;

	// Token: 0x0400070D RID: 1805
	private bool isMarked;

	// Token: 0x0400070E RID: 1806
	public TrackableBehaviour mTrackableBehaviour;
}
