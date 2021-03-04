using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000138 RID: 312
public class PoDLController : MonoBehaviour
{
	// Token: 0x14000011 RID: 17
	// (add) Token: 0x06000A3E RID: 2622 RVA: 0x000043F4 File Offset: 0x000025F4
	// (remove) Token: 0x06000A3F RID: 2623 RVA: 0x000043F8 File Offset: 0x000025F8
	public event Action onDownloadCompleted
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

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000A40 RID: 2624 RVA: 0x000043FC File Offset: 0x000025FC
	public bool IsFinishedDownload
	{
		get
		{
		}
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x00004400 File Offset: 0x00002600
	public GameObject GetMiku()
	{
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00004404 File Offset: 0x00002604
	public GameObject GetNeko()
	{
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00004408 File Offset: 0x00002608
	public GameObject GetMiku2()
	{
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x0000440C File Offset: 0x0000260C
	public GameObject GetNeko2()
	{
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00004410 File Offset: 0x00002610
	private GameObject GetMikuByURL(GameObject prefab)
	{
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00004414 File Offset: 0x00002614
	private GameObject GetNekoByURL(GameObject prefab)
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00004418 File Offset: 0x00002618
	private void Awake()
	{
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x0000441C File Offset: 0x0000261C
	[DebuggerHidden]
	private IEnumerator Start()
	{
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x00004420 File Offset: 0x00002620
	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x00004424 File Offset: 0x00002624
	private void OnOKClick()
	{
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x00004428 File Offset: 0x00002628
	private bool isCachedAll()
	{
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0000442C File Offset: 0x0000262C
	[DebuggerHidden]
	private IEnumerator Download()
	{
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00004430 File Offset: 0x00002630
	private void SetMaterialTexture()
	{
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00004434 File Offset: 0x00002634
	private UnityEngine.Object GetItemByName(string item)
	{
	}

	// Token: 0x06000A4F RID: 2639 RVA: 0x00004438 File Offset: 0x00002638
	private GameObject InstantiateByName(string name, string item)
	{
	}

	// Token: 0x06000A50 RID: 2640 RVA: 0x0000443C File Offset: 0x0000263C
	private GameObject InstantiateByPrefab(GameObject prefab)
	{
	}

	// Token: 0x06000A51 RID: 2641 RVA: 0x00004440 File Offset: 0x00002640
	public void ResetCenter(GameObject go, string spinePath)
	{
	}

	// Token: 0x06000A52 RID: 2642 RVA: 0x00004444 File Offset: 0x00002644
	private void Update()
	{
	}

	// Token: 0x04000699 RID: 1689
	private const string MIKU_URL = "Model/Portrait/Miku/miku_fix";

	// Token: 0x0400069A RID: 1690
	private const string NEKO_URL = "Model/Portrait/Miku/miku_neko_fix";

	// Token: 0x0400069B RID: 1691
	private const string MIKU_2_URL = "Model/Portrait/Miku/miku2_fix";

	// Token: 0x0400069C RID: 1692
	private const string PO_DIALOG_ATLAS_URL = "Texture/Portrait/DialogAtlas";

	// Token: 0x0400069D RID: 1693
	private const string PO_DISK_URL = "Texture/Portrait/DiskAtlas";

	// Token: 0x0400069E RID: 1694
	private const string PO_HELP_ATLAS_URL = "Texture/Portrait/PoHelpAtlas";

	// Token: 0x0400069F RID: 1695
	private const string PO_URL = "Texture/Portrait/PortraitAtlas";

	// Token: 0x040006A0 RID: 1696
	public CacheController cache;

	// Token: 0x040006A1 RID: 1697
	public Material _poDialogMat;

	// Token: 0x040006A2 RID: 1698
	public Material _poDiskMat;

	// Token: 0x040006A3 RID: 1699
	public Material _poHelpMat;

	// Token: 0x040006A4 RID: 1700
	public Material _poMat;

	// Token: 0x040006A5 RID: 1701
	public Camera _arCam;

	// Token: 0x040006A6 RID: 1702
	public Camera _modelCam;

	// Token: 0x040006A7 RID: 1703
	public Transform _mikuContainer;

	// Token: 0x040006A8 RID: 1704
	public Transform _modelCenter;

	// Token: 0x040006A9 RID: 1705
	private GameObject _miku;

	// Token: 0x040006AA RID: 1706
	private GameObject _neko;

	// Token: 0x040006AB RID: 1707
	private bool _isStartedDownload;

	// Token: 0x040006AC RID: 1708
	private bool _isFinishedDownload;

	// Token: 0x040006AD RID: 1709
	private string[] _downloadList;
}
