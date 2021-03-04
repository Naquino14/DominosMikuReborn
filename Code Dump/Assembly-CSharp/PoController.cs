using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000137 RID: 311
public class PoController : MonoBehaviour, ITrackableEventHandler
{
	// Token: 0x1400000F RID: 15
	// (add) Token: 0x06000A30 RID: 2608 RVA: 0x000043BC File Offset: 0x000025BC
	// (remove) Token: 0x06000A31 RID: 2609 RVA: 0x000043C0 File Offset: 0x000025C0
	public event Action<string> onTrackingFound
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x14000010 RID: 16
	// (add) Token: 0x06000A32 RID: 2610 RVA: 0x000043C4 File Offset: 0x000025C4
	// (remove) Token: 0x06000A33 RID: 2611 RVA: 0x000043C8 File Offset: 0x000025C8
	public event Action onTrackingLost
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x000043CC File Offset: 0x000025CC
	private void Awake()
	{
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x000043D0 File Offset: 0x000025D0
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x000043D4 File Offset: 0x000025D4
	private void GetCurrentTrack()
	{
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x000043D8 File Offset: 0x000025D8
	public void DeactiveArCamera()
	{
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x000043DC File Offset: 0x000025DC
	public void ActiveArCamera()
	{
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x000043E0 File Offset: 0x000025E0
	public void ModelCamToDepth()
	{
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x000043E4 File Offset: 0x000025E4
	public void ModelCamToSkybox()
	{
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x000043E8 File Offset: 0x000025E8
	public void ResetModel()
	{
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x000043EC File Offset: 0x000025EC
	public void ResetNeko(GameObject go)
	{
	}

	// Token: 0x04000691 RID: 1681
	public Camera _arCam;

	// Token: 0x04000692 RID: 1682
	public MaxCamera _modelCam;

	// Token: 0x04000693 RID: 1683
	public Transform _modelCenter;

	// Token: 0x04000694 RID: 1684
	public Transform _mikuContainer;

	// Token: 0x04000695 RID: 1685
	public TrackableBehaviour[] mTrackableBehaviours;

	// Token: 0x04000696 RID: 1686
	private TrackableBehaviour _curTrack;
}
