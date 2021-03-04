using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200013E RID: 318
public class TutUIController : MonoBehaviour
{
	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00004638 File Offset: 0x00002838
	public bool IsReady
	{
		get
		{
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0000463C File Offset: 0x0000283C
	public static TutUIController Instance
	{
		get
		{
		}
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00004640 File Offset: 0x00002840
	private void Awake()
	{
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00004644 File Offset: 0x00002844
	private void ResetZero()
	{
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00004648 File Offset: 0x00002848
	[DebuggerHidden]
	private IEnumerator Start()
	{
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x0000464C File Offset: 0x0000284C
	private void SetReady()
	{
	}

	// Token: 0x06000AD5 RID: 2773 RVA: 0x00004650 File Offset: 0x00002850
	private void DestroyScene()
	{
	}

	// Token: 0x06000AD6 RID: 2774 RVA: 0x00004654 File Offset: 0x00002854
	public void Show()
	{
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00004658 File Offset: 0x00002858
	public void Hide()
	{
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x0000465C File Offset: 0x0000285C
	public void SetDownloadPercent(float percent)
	{
	}

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00004660 File Offset: 0x00002860
	private void SetTextPercent(float percent)
	{
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00004664 File Offset: 0x00002864
	private void SetBarPercent(float percent)
	{
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00004668 File Offset: 0x00002868
	protected virtual void OnPercentChanged(float percent)
	{
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x0000466C File Offset: 0x0000286C
	public void OnBackClick()
	{
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00004670 File Offset: 0x00002870
	public void SetCameraToDepthOnly()
	{
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00004674 File Offset: 0x00002874
	public void SetIsLoading()
	{
	}

	// Token: 0x06000ADF RID: 2783 RVA: 0x00004678 File Offset: 0x00002878
	public void SetIsDownloading()
	{
	}

	// Token: 0x06000AE0 RID: 2784 RVA: 0x0000467C File Offset: 0x0000287C
	private void RunFlash()
	{
	}

	// Token: 0x06000AE1 RID: 2785 RVA: 0x00004680 File Offset: 0x00002880
	private void BlinkLoading()
	{
	}

	// Token: 0x040006E6 RID: 1766
	private const float MAX_BAR_WIDTH = 560f;

	// Token: 0x040006E7 RID: 1767
	public GameObject _root;

	// Token: 0x040006E8 RID: 1768
	public Camera _camera;

	// Token: 0x040006E9 RID: 1769
	public UILabel _textPer;

	// Token: 0x040006EA RID: 1770
	public UISlicedSprite _barPer;

	// Token: 0x040006EB RID: 1771
	public UISprite _loading;

	// Token: 0x040006EC RID: 1772
	public FlashProgress _flash;

	// Token: 0x040006ED RID: 1773
	public Transform[] _panels;

	// Token: 0x040006EE RID: 1774
	private int _type;

	// Token: 0x040006EF RID: 1775
	private bool _isStartedBlink;

	// Token: 0x040006F0 RID: 1776
	private bool _isReady;

	// Token: 0x040006F1 RID: 1777
	private static TutUIController _instance;
}
