using System;
using UnityEngine;

// Token: 0x02000145 RID: 325
public class TestMarker2Controller : MonoBehaviour, ITrackableEventHandler
{
	// Token: 0x06000B02 RID: 2818 RVA: 0x00004704 File Offset: 0x00002904
	private void Start()
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00004708 File Offset: 0x00002908
	private void Update()
	{
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x0000470C File Offset: 0x0000290C
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	// Token: 0x06000B05 RID: 2821 RVA: 0x00004710 File Offset: 0x00002910
	private void OnTrackingFound()
	{
	}

	// Token: 0x06000B06 RID: 2822 RVA: 0x00004714 File Offset: 0x00002914
	private void OnTrackingLost()
	{
	}

	// Token: 0x04000705 RID: 1797
	public GameObject restObject;

	// Token: 0x04000706 RID: 1798
	public GameObject rootObj;

	// Token: 0x04000707 RID: 1799
	public GameObject targetTr;

	// Token: 0x04000708 RID: 1800
	private bool isMarked;

	// Token: 0x04000709 RID: 1801
	public TrackableBehaviour mTrackableBehaviour;
}
