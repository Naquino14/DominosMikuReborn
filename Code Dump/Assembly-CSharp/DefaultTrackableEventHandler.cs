using System;
using UnityEngine;

// Token: 0x0200008D RID: 141
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
	// Token: 0x060003ED RID: 1005 RVA: 0x00002FA8 File Offset: 0x000011A8
	private void Start()
	{
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00002FAC File Offset: 0x000011AC
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00002FB0 File Offset: 0x000011B0
	private void OnTrackingFound()
	{
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00002FB4 File Offset: 0x000011B4
	private void OnTrackingLost()
	{
	}

	// Token: 0x04000399 RID: 921
	private TrackableBehaviour mTrackableBehaviour;
}
