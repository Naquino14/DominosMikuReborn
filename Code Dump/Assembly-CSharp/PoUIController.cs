using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200013B RID: 315
public class PoUIController : MonoBehaviour
{
	// Token: 0x14000012 RID: 18
	// (add) Token: 0x06000A7B RID: 2683 RVA: 0x000044E8 File Offset: 0x000026E8
	// (remove) Token: 0x06000A7C RID: 2684 RVA: 0x000044EC File Offset: 0x000026EC
	public event Action onBannerClick
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

	// Token: 0x14000013 RID: 19
	// (add) Token: 0x06000A7D RID: 2685 RVA: 0x000044F0 File Offset: 0x000026F0
	// (remove) Token: 0x06000A7E RID: 2686 RVA: 0x000044F4 File Offset: 0x000026F4
	public event Action onArBackClick
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

	// Token: 0x14000014 RID: 20
	// (add) Token: 0x06000A7F RID: 2687 RVA: 0x000044F8 File Offset: 0x000026F8
	// (remove) Token: 0x06000A80 RID: 2688 RVA: 0x000044FC File Offset: 0x000026FC
	public event Action onSwitchClick
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

	// Token: 0x14000015 RID: 21
	// (add) Token: 0x06000A81 RID: 2689 RVA: 0x00004500 File Offset: 0x00002700
	// (remove) Token: 0x06000A82 RID: 2690 RVA: 0x00004504 File Offset: 0x00002704
	public event Action onNewClick
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

	// Token: 0x06000A83 RID: 2691 RVA: 0x00004508 File Offset: 0x00002708
	public void Awake()
	{
	}

	// Token: 0x06000A84 RID: 2692 RVA: 0x0000450C File Offset: 0x0000270C
	private void OnDisable()
	{
	}

	// Token: 0x06000A85 RID: 2693 RVA: 0x00004510 File Offset: 0x00002710
	private void AddAllDelegates()
	{
	}

	// Token: 0x06000A86 RID: 2694 RVA: 0x00004514 File Offset: 0x00002714
	private void RemoveAllDelegates()
	{
	}

	// Token: 0x06000A87 RID: 2695 RVA: 0x00004518 File Offset: 0x00002718
	public int GetCurrentFace()
	{
	}

	// Token: 0x06000A88 RID: 2696 RVA: 0x0000451C File Offset: 0x0000271C
	private void OnFaceItemChange(int itemId)
	{
	}

	// Token: 0x06000A89 RID: 2697 RVA: 0x00004520 File Offset: 0x00002720
	private void OnPoseItemChange(int itemId)
	{
	}

	// Token: 0x06000A8A RID: 2698 RVA: 0x00004524 File Offset: 0x00002724
	public void OnBannerClick()
	{
	}

	// Token: 0x06000A8B RID: 2699 RVA: 0x00004528 File Offset: 0x00002728
	public void OnArBackClick()
	{
	}

	// Token: 0x06000A8C RID: 2700 RVA: 0x0000452C File Offset: 0x0000272C
	public void OnBackClick()
	{
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x00004530 File Offset: 0x00002730
	public void OnHelpClick()
	{
	}

	// Token: 0x06000A8E RID: 2702 RVA: 0x00004534 File Offset: 0x00002734
	public void OnCameraClick()
	{
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x00004538 File Offset: 0x00002738
	[DebuggerHidden]
	private IEnumerator RenTexture()
	{
	}

	// Token: 0x06000A90 RID: 2704 RVA: 0x0000453C File Offset: 0x0000273C
	private Texture2D CreateScreenTex()
	{
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x00004540 File Offset: 0x00002740
	private Material CreateScreenMat(Texture2D tex)
	{
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x00004544 File Offset: 0x00002744
	private void CreateCaptureObject(Material mat)
	{
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x00004548 File Offset: 0x00002748
	[DebuggerHidden]
	private IEnumerator Flash()
	{
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0000454C File Offset: 0x0000274C
	[DebuggerHidden]
	private IEnumerator SaveScreenShot()
	{
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x00004550 File Offset: 0x00002750
	[DebuggerHidden]
	private IEnumerator CaptureScreen()
	{
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x00004554 File Offset: 0x00002754
	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x00004558 File Offset: 0x00002758
	private void OnShareClose()
	{
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x0000455C File Offset: 0x0000275C
	[DebuggerHidden]
	public IEnumerator ShowHelp()
	{
	}

	// Token: 0x06000A99 RID: 2713 RVA: 0x00004560 File Offset: 0x00002760
	private void OnHelpClose()
	{
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x00004564 File Offset: 0x00002764
	public void OnFaceClick()
	{
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x00004568 File Offset: 0x00002768
	private void ShowFace()
	{
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x0000456C File Offset: 0x0000276C
	public void OnPoseClick()
	{
	}

	// Token: 0x06000A9D RID: 2717 RVA: 0x00004570 File Offset: 0x00002770
	private void ShowPose()
	{
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x00004574 File Offset: 0x00002774
	public void OnCloseClick()
	{
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x00004578 File Offset: 0x00002778
	public void OnFaceDiskCloseClick()
	{
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x0000457C File Offset: 0x0000277C
	public void OnPoseDiskCloseClick()
	{
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x00004580 File Offset: 0x00002780
	public void Found()
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00004584 File Offset: 0x00002784
	[DebuggerHidden]
	private IEnumerator IEfound()
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00004588 File Offset: 0x00002788
	public void ShowAr()
	{
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x0000458C File Offset: 0x0000278C
	public void ShowAr(float fadeTime)
	{
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00004590 File Offset: 0x00002790
	public void HideAr()
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00004594 File Offset: 0x00002794
	public void HideAr(float fadeTime, string callback)
	{
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x00004598 File Offset: 0x00002798
	public void Show(float fadeTime)
	{
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x0000459C File Offset: 0x0000279C
	public void ShowAndWaitSpecialAppear(float fadeTime)
	{
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x000045A0 File Offset: 0x000027A0
	public void ActiveSpecialText(bool active)
	{
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x000045A4 File Offset: 0x000027A4
	public void ActiveSpecialText(float time, float delay)
	{
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x000045A8 File Offset: 0x000027A8
	public void DestroyTweenSpecialText()
	{
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x000045AC File Offset: 0x000027AC
	public void Hide()
	{
	}

	// Token: 0x06000AAD RID: 2733 RVA: 0x000045B0 File Offset: 0x000027B0
	public void Hide(float fadeTime, string callback)
	{
	}

	// Token: 0x06000AAE RID: 2734 RVA: 0x000045B4 File Offset: 0x000027B4
	public void StartRotateEffect()
	{
	}

	// Token: 0x06000AAF RID: 2735 RVA: 0x000045B8 File Offset: 0x000027B8
	public void Lock()
	{
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x000045BC File Offset: 0x000027BC
	public void Unlock()
	{
	}

	// Token: 0x06000AB1 RID: 2737 RVA: 0x000045C0 File Offset: 0x000027C0
	public void UnlockAfter(float delay)
	{
	}

	// Token: 0x06000AB2 RID: 2738 RVA: 0x000045C4 File Offset: 0x000027C4
	[DebuggerHidden]
	private IEnumerator IErotatePoseDisk(float delay)
	{
	}

	// Token: 0x06000AB3 RID: 2739 RVA: 0x000045C8 File Offset: 0x000027C8
	private void HidePoseDisk()
	{
	}

	// Token: 0x06000AB4 RID: 2740 RVA: 0x000045CC File Offset: 0x000027CC
	private void ShowPoseDisk(float delay)
	{
	}

	// Token: 0x06000AB5 RID: 2741 RVA: 0x000045D0 File Offset: 0x000027D0
	private void HideFaceDisk()
	{
	}

	// Token: 0x06000AB6 RID: 2742 RVA: 0x000045D4 File Offset: 0x000027D4
	private void ShowFaceDisk(float delay)
	{
	}

	// Token: 0x06000AB7 RID: 2743 RVA: 0x000045D8 File Offset: 0x000027D8
	[DebuggerHidden]
	private IEnumerator Capture()
	{
	}

	// Token: 0x06000AB8 RID: 2744 RVA: 0x000045DC File Offset: 0x000027DC
	private void OnSwitchNormalClick()
	{
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x000045E0 File Offset: 0x000027E0
	private void OnSwitchNewClick()
	{
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x000045E4 File Offset: 0x000027E4
	private void LockSwitchButtons()
	{
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x000045E8 File Offset: 0x000027E8
	private void UnlockSwitchButtons()
	{
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x000045EC File Offset: 0x000027EC
	public void ResetDisks(int version = 0)
	{
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x000045F0 File Offset: 0x000027F0
	private DjDiskTop MakeDisk(GameObject prefab, GameObject old, Transform pa)
	{
	}

	// Token: 0x040006BF RID: 1727
	private const string IMAGE_NAME = "screenshot.png";

	// Token: 0x040006C0 RID: 1728
	[SerializeField]
	private GameObject[] djDiskFacePrefab;

	// Token: 0x040006C1 RID: 1729
	[SerializeField]
	private GameObject[] djDiskPosePrefab;

	// Token: 0x040006C2 RID: 1730
	public DJDisk.item_change_delegate onFaceItemChange;

	// Token: 0x040006C3 RID: 1731
	public DJDisk.item_change_delegate onPoseItemChange;

	// Token: 0x040006C4 RID: 1732
	public PoController _poCtrl;

	// Token: 0x040006C5 RID: 1733
	public Color normalButtonColor;

	// Token: 0x040006C6 RID: 1734
	public Color selectButtonColor;

	// Token: 0x040006C7 RID: 1735
	public Transform _panel1_1;

	// Token: 0x040006C8 RID: 1736
	public Transform _panel2_1;

	// Token: 0x040006C9 RID: 1737
	public Transform _shield;

	// Token: 0x040006CA RID: 1738
	public UIImageButton _faceButton;

	// Token: 0x040006CB RID: 1739
	public UIImageButton _poseButton;

	// Token: 0x040006CC RID: 1740
	public DjDiskTop _djDiskFace;

	// Token: 0x040006CD RID: 1741
	public DjDiskTop _djDiskPose;

	// Token: 0x040006CE RID: 1742
	public GameObject _captureScreen;

	// Token: 0x040006CF RID: 1743
	public UIWidget _flash;

	// Token: 0x040006D0 RID: 1744
	public UISprite _logo;

	// Token: 0x040006D1 RID: 1745
	public ArNavi _banner;

	// Token: 0x040006D2 RID: 1746
	public Guide _guide;

	// Token: 0x040006D3 RID: 1747
	public Aim _aim;

	// Token: 0x040006D4 RID: 1748
	private DjDiskTop _currentDisk;

	// Token: 0x040006D5 RID: 1749
	private Texture2D _screenTex;

	// Token: 0x040006D6 RID: 1750
	private MSpecialPose _specialData;

	// Token: 0x040006D7 RID: 1751
	private int _curFace;

	// Token: 0x040006D8 RID: 1752
	public ArNavi _btnNormal;

	// Token: 0x040006D9 RID: 1753
	public ArNavi _btnNew;
}
