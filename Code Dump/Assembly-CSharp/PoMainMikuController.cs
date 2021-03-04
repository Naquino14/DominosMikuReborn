using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000136 RID: 310
public class PoMainMikuController : PoMainController
{
	// Token: 0x06000A1B RID: 2587 RVA: 0x00004368 File Offset: 0x00002568
	private void Update()
	{
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x0000436C File Offset: 0x0000256C
	protected override void OnDownloadCompleted()
	{
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00004370 File Offset: 0x00002570
	public override void Init()
	{
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00004374 File Offset: 0x00002574
	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00004378 File Offset: 0x00002578
	private void InitMiku()
	{
	}

	// Token: 0x06000A20 RID: 2592 RVA: 0x0000437C File Offset: 0x0000257C
	private void InitNeko()
	{
	}

	// Token: 0x06000A21 RID: 2593 RVA: 0x00004380 File Offset: 0x00002580
	private void DeactiveNeko()
	{
	}

	// Token: 0x06000A22 RID: 2594 RVA: 0x00004384 File Offset: 0x00002584
	protected override void OnFaceItemChange(int itemId)
	{
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00004388 File Offset: 0x00002588
	protected override void OnPoseItemChange(int itemId)
	{
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x0000438C File Offset: 0x0000258C
	protected override void OnGoToAr()
	{
	}

	// Token: 0x06000A25 RID: 2597 RVA: 0x00004390 File Offset: 0x00002590
	private void OnAnimFinish()
	{
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00004394 File Offset: 0x00002594
	private void ResetCenter()
	{
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00004398 File Offset: 0x00002598
	private string GetSpinePath()
	{
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x0000439C File Offset: 0x0000259C
	private string GetSpinePath(GameObject go)
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x000043A0 File Offset: 0x000025A0
	private void SetMixing(GameObject go, Transform faceBone, Transform allBone)
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x000043A4 File Offset: 0x000025A4
	private void SetFaceMixing(GameObject go, bool recursive, Transform faceBone)
	{
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x000043A8 File Offset: 0x000025A8
	private void SetPoseMixing(GameObject go, bool recursive, Transform faceBone, Transform allBone)
	{
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x000043AC File Offset: 0x000025AC
	private void SetPoseItemMixing(GameObject go, Transform itemBone)
	{
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x000043B0 File Offset: 0x000025B0
	private void Mix(GameObject go, string anim, List<Transform> boneList, bool recursive)
	{
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x000043B4 File Offset: 0x000025B4
	private void ActiveModel(GameObject go)
	{
	}

	// Token: 0x04000688 RID: 1672
	private const string MIKU_SPINE_PATH = "Reference/Hips/Spine";

	// Token: 0x04000689 RID: 1673
	private const string NEKO_SPINE_PATH = "neko_pose:Reference/neko_pose:Hips/neko_pose:Spine";

	// Token: 0x0400068A RID: 1674
	private GameObject _miku;

	// Token: 0x0400068B RID: 1675
	private GameObject _neko;

	// Token: 0x0400068C RID: 1676
	private bool _isAnimCheck;

	// Token: 0x0400068D RID: 1677
	private bool _isInitedMiku;

	// Token: 0x0400068E RID: 1678
	private GameObject _prevModel;

	// Token: 0x0400068F RID: 1679
	private Vector3 _prevSpinePos;

	// Token: 0x04000690 RID: 1680
	private Transform _itemBone;
}
