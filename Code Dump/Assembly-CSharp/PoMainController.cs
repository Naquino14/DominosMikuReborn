using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000139 RID: 313
public class PoMainController : MonoBehaviour
{
	// Token: 0x06000A54 RID: 2644 RVA: 0x0000444C File Offset: 0x0000264C
	public virtual void Init()
	{
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00004450 File Offset: 0x00002650
	public void GetProperties(PoMainController other)
	{
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00004454 File Offset: 0x00002654
	private void Start()
	{
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00004458 File Offset: 0x00002658
	protected void ResetCenter(GameObject go, string spinePath)
	{
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x0000445C File Offset: 0x0000265C
	protected void ResetCenter(Vector3 prevSpinePos, GameObject go, string spinePath)
	{
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00004460 File Offset: 0x00002660
	private void OnEnable()
	{
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00004464 File Offset: 0x00002664
	private void AddDelegates()
	{
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00004468 File Offset: 0x00002668
	private void OnDisable()
	{
	}

	// Token: 0x06000A5C RID: 2652 RVA: 0x0000446C File Offset: 0x0000266C
	private void RemoveDelegates()
	{
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x00004470 File Offset: 0x00002670
	protected virtual void OnDownloadCompleted()
	{
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x00004474 File Offset: 0x00002674
	protected virtual void OnFaceItemChange(int itemId)
	{
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00004478 File Offset: 0x00002678
	protected virtual void OnPoseItemChange(int itemId)
	{
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x0000447C File Offset: 0x0000267C
	[DebuggerHidden]
	protected IEnumerator ShowSpecialDialog()
	{
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x00004480 File Offset: 0x00002680
	protected virtual void OnGoToAr()
	{
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x00004484 File Offset: 0x00002684
	private void OnSpecialDialogClose()
	{
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00004488 File Offset: 0x00002688
	private void OnSpecialDialogGoar()
	{
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x0000448C File Offset: 0x0000268C
	private void ToPortrait()
	{
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00004490 File Offset: 0x00002690
	private void RunSpecial()
	{
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x00004494 File Offset: 0x00002694
	private void GoToAr()
	{
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00004498 File Offset: 0x00002698
	private void UnlockUI()
	{
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x0000449C File Offset: 0x0000269C
	private void OnBannerClick()
	{
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x000044A0 File Offset: 0x000026A0
	private void OnArBackClick()
	{
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x000044A4 File Offset: 0x000026A4
	private void OnTrackingFound(string obj)
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x000044A8 File Offset: 0x000026A8
	private void OnTrackingLost()
	{
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x000044AC File Offset: 0x000026AC
	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x000044B0 File Offset: 0x000026B0
	private void OnSwitchNormalClick()
	{
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x000044B4 File Offset: 0x000026B4
	private void OnSwitchNewClick()
	{
	}

	// Token: 0x040006AF RID: 1711
	public PoController _poCtrl;

	// Token: 0x040006B0 RID: 1712
	public PoUIController _poUICtrl;

	// Token: 0x040006B1 RID: 1713
	public PoDLController _poDlCtrl;

	// Token: 0x040006B2 RID: 1714
	public TouchScriptForMaxCam _poModelCtrl;

	// Token: 0x040006B3 RID: 1715
	public QCARBehaviour2 _qcarCtrl;

	// Token: 0x040006B4 RID: 1716
	public Transform _mikuContainer;

	// Token: 0x040006B5 RID: 1717
	[HideInInspector]
	public GameObject _curModel;

	// Token: 0x040006B6 RID: 1718
	[HideInInspector]
	public MSpecialPose _specialData;

	// Token: 0x040006B7 RID: 1719
	[HideInInspector]
	public List<string> faceList;

	// Token: 0x040006B8 RID: 1720
	[HideInInspector]
	public List<string> poseList;

	// Token: 0x040006B9 RID: 1721
	private bool isStarted;
}
