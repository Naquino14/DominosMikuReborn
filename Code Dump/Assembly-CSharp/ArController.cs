using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000124 RID: 292
public class ArController : MonoBehaviour, ITrackableEventHandler
{
	// Token: 0x14000003 RID: 3
	// (add) Token: 0x0600090B RID: 2315 RVA: 0x00003F28 File Offset: 0x00002128
	// (remove) Token: 0x0600090C RID: 2316 RVA: 0x00003F2C File Offset: 0x0000212C
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

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600090D RID: 2317 RVA: 0x00003F30 File Offset: 0x00002130
	// (remove) Token: 0x0600090E RID: 2318 RVA: 0x00003F34 File Offset: 0x00002134
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

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x0600090F RID: 2319 RVA: 0x00003F38 File Offset: 0x00002138
	// (remove) Token: 0x06000910 RID: 2320 RVA: 0x00003F3C File Offset: 0x0000213C
	public event Action onArInited
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

	// Token: 0x06000911 RID: 2321 RVA: 0x00003F40 File Offset: 0x00002140
	private void Awake()
	{
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x00003F44 File Offset: 0x00002144
	public void Init()
	{
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00003F48 File Offset: 0x00002148
	public void DeactiveArCamera()
	{
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00003F4C File Offset: 0x0000214C
	public void ActiveArCamera()
	{
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00003F50 File Offset: 0x00002150
	public void ShowRoot()
	{
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x00003F54 File Offset: 0x00002154
	public void HideRoot()
	{
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x00003F58 File Offset: 0x00002158
	public void ActiveEffect()
	{
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x00003F5C File Offset: 0x0000215C
	public void DeactiveEffect()
	{
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x00003F60 File Offset: 0x00002160
	public void ModelCamToDepth()
	{
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00003F64 File Offset: 0x00002164
	public void ModelCamToSkybox()
	{
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00003F68 File Offset: 0x00002168
	public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
	{
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x00003F6C File Offset: 0x0000216C
	private void Update()
	{
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x00003F70 File Offset: 0x00002170
	private void ResetShowPos()
	{
	}

	// Token: 0x040005BC RID: 1468
	public ArUIController _arUICtrl;

	// Token: 0x040005BD RID: 1469
	public Camera _arCam;

	// Token: 0x040005BE RID: 1470
	public Camera _modelCam;

	// Token: 0x040005BF RID: 1471
	public Transform _arRoot;

	// Token: 0x040005C0 RID: 1472
	public Transform _hidePos;

	// Token: 0x040005C1 RID: 1473
	public Transform _showPos;

	// Token: 0x040005C2 RID: 1474
	private bool _isMarked;

	// Token: 0x040005C3 RID: 1475
	private bool _isInited;

	// Token: 0x040005C4 RID: 1476
	private TrackableBehaviour _curTrack;

	// Token: 0x040005C5 RID: 1477
	public TrackableBehaviour[] mTrackableBehaviours;

	// Token: 0x040005C6 RID: 1478
	public GameObject _effect1;
}
