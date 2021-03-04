using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000135 RID: 309
public class PoMainMiku2Controller : PoMainController
{
	// Token: 0x06000A08 RID: 2568 RVA: 0x0000431C File Offset: 0x0000251C
	private void Update()
	{
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00004320 File Offset: 0x00002520
	protected override void OnDownloadCompleted()
	{
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00004324 File Offset: 0x00002524
	public override void Init()
	{
	}

	// Token: 0x06000A0B RID: 2571 RVA: 0x00004328 File Offset: 0x00002528
	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
	}

	// Token: 0x06000A0C RID: 2572 RVA: 0x0000432C File Offset: 0x0000252C
	private void InitMiku()
	{
	}

	// Token: 0x06000A0D RID: 2573 RVA: 0x00004330 File Offset: 0x00002530
	protected override void OnFaceItemChange(int itemId)
	{
	}

	// Token: 0x06000A0E RID: 2574 RVA: 0x00004334 File Offset: 0x00002534
	protected override void OnPoseItemChange(int itemId)
	{
	}

	// Token: 0x06000A0F RID: 2575 RVA: 0x00004338 File Offset: 0x00002538
	protected override void OnGoToAr()
	{
	}

	// Token: 0x06000A10 RID: 2576 RVA: 0x0000433C File Offset: 0x0000253C
	private void OnAnimFinish()
	{
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00004340 File Offset: 0x00002540
	private void ResetCenter()
	{
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x00004344 File Offset: 0x00002544
	private string GetSpinePath()
	{
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x00004348 File Offset: 0x00002548
	private string GetSpinePath(GameObject go)
	{
	}

	// Token: 0x06000A14 RID: 2580 RVA: 0x0000434C File Offset: 0x0000254C
	private void SetMixing(GameObject go, Transform faceBone, Transform allBone)
	{
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00004350 File Offset: 0x00002550
	private void SetFaceMixing(GameObject go, bool recursive, Transform faceBone)
	{
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x00004354 File Offset: 0x00002554
	private void SetPoseMixing(GameObject go, bool recursive, Transform faceBone, Transform allBone)
	{
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x00004358 File Offset: 0x00002558
	private void SetPoseItemMixing(GameObject go, Transform itemBone)
	{
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x0000435C File Offset: 0x0000255C
	private void Mix(GameObject go, string anim, List<Transform> boneList, bool recursive)
	{
	}

	// Token: 0x06000A19 RID: 2585 RVA: 0x00004360 File Offset: 0x00002560
	private void ActiveModel(GameObject go)
	{
	}

	// Token: 0x04000681 RID: 1665
	private const string MIKU_SPINE_PATH = "Reference/Hips/Spine";

	// Token: 0x04000682 RID: 1666
	private GameObject _miku;

	// Token: 0x04000683 RID: 1667
	private bool _isAnimCheck;

	// Token: 0x04000684 RID: 1668
	private bool _isInitedMiku;

	// Token: 0x04000685 RID: 1669
	private GameObject _prevModel;

	// Token: 0x04000686 RID: 1670
	private Vector3 _prevSpinePos;

	// Token: 0x04000687 RID: 1671
	private Transform _itemBone;
}
