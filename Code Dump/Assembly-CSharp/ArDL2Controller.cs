using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200012C RID: 300
public class ArDL2Controller : MonoBehaviour
{
	// Token: 0x14000008 RID: 8
	// (add) Token: 0x0600097B RID: 2427 RVA: 0x000040E8 File Offset: 0x000022E8
	// (remove) Token: 0x0600097C RID: 2428 RVA: 0x000040EC File Offset: 0x000022EC
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

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x0600097D RID: 2429 RVA: 0x000040F0 File Offset: 0x000022F0
	public static ArDL2Controller Instance
	{
		get
		{
		}
	}

	// Token: 0x0600097E RID: 2430 RVA: 0x000040F4 File Offset: 0x000022F4
	public GameObject GetMiku()
	{
	}

	// Token: 0x0600097F RID: 2431 RVA: 0x000040F8 File Offset: 0x000022F8
	public GameObject GetAshi()
	{
	}

	// Token: 0x06000980 RID: 2432 RVA: 0x000040FC File Offset: 0x000022FC
	public Texture GetShareTicket()
	{
	}

	// Token: 0x06000981 RID: 2433 RVA: 0x00004100 File Offset: 0x00002300
	public GameObject GetEffect()
	{
	}

	// Token: 0x06000982 RID: 2434 RVA: 0x00004104 File Offset: 0x00002304
	private void Awake()
	{
	}

	// Token: 0x06000983 RID: 2435 RVA: 0x00004108 File Offset: 0x00002308
	private void OnDestroy()
	{
	}

	// Token: 0x06000984 RID: 2436 RVA: 0x0000410C File Offset: 0x0000230C
	[DebuggerHidden]
	private IEnumerator Start()
	{
	}

	// Token: 0x06000985 RID: 2437 RVA: 0x00004110 File Offset: 0x00002310
	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
	}

	// Token: 0x06000986 RID: 2438 RVA: 0x00004114 File Offset: 0x00002314
	private void OnOKClick()
	{
	}

	// Token: 0x06000987 RID: 2439 RVA: 0x00004118 File Offset: 0x00002318
	private bool isCachedAll()
	{
	}

	// Token: 0x06000988 RID: 2440 RVA: 0x0000411C File Offset: 0x0000231C
	private bool isDownloadedAll()
	{
	}

	// Token: 0x06000989 RID: 2441 RVA: 0x00004120 File Offset: 0x00002320
	[DebuggerHidden]
	private IEnumerator Download()
	{
	}

	// Token: 0x0600098A RID: 2442 RVA: 0x00004124 File Offset: 0x00002324
	[DebuggerHidden]
	private IEnumerator AfterDownload()
	{
	}

	// Token: 0x0600098B RID: 2443 RVA: 0x00004128 File Offset: 0x00002328
	private void SetMaterialTexture()
	{
	}

	// Token: 0x0600098C RID: 2444 RVA: 0x0000412C File Offset: 0x0000232C
	private UnityEngine.Object GetItemByName(string item)
	{
	}

	// Token: 0x0600098D RID: 2445 RVA: 0x00004130 File Offset: 0x00002330
	private GameObject InstantiateByName(string item, Transform parent)
	{
	}

	// Token: 0x0600098E RID: 2446 RVA: 0x00004134 File Offset: 0x00002334
	private GameObject InstantiateByName(string item, Transform parent, Vector3 pos)
	{
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00004138 File Offset: 0x00002338
	private GameObject InstantiateAshiByName(string item, Transform parent)
	{
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x0000413C File Offset: 0x0000233C
	private GameObject InstantiateEffectByName(string item, Transform parent)
	{
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00004140 File Offset: 0x00002340
	private void SetBase(Transform t, Transform parent)
	{
	}

	// Token: 0x06000992 RID: 2450 RVA: 0x00004144 File Offset: 0x00002344
	private void SetMikuBase(Transform t, Transform parent)
	{
	}

	// Token: 0x06000993 RID: 2451 RVA: 0x00004148 File Offset: 0x00002348
	private void ActiveTransformArray(Transform[] ts, bool active)
	{
	}

	// Token: 0x06000994 RID: 2452 RVA: 0x0000414C File Offset: 0x0000234C
	private void SetAshiBase(Transform t, Transform parent)
	{
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00004150 File Offset: 0x00002350
	private void SetStageBase(Transform t, Transform parent)
	{
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00004154 File Offset: 0x00002354
	private void Update()
	{
	}

	// Token: 0x06000997 RID: 2455 RVA: 0x00004158 File Offset: 0x00002358
	private void TutorialProgressCheck()
	{
	}

	// Token: 0x06000998 RID: 2456 RVA: 0x0000415C File Offset: 0x0000235C
	public void TrackerStop()
	{
	}

	// Token: 0x04000620 RID: 1568
	private const string EFFECT_ANIM = "MasterEffectAnim";

	// Token: 0x04000621 RID: 1569
	private const string MIKU_URL = "Model/Dance/Miku/miku2";

	// Token: 0x04000622 RID: 1570
	private const string STAGE_URL = "Model/Dance/Stage/stage2";

	// Token: 0x04000623 RID: 1571
	private const string ASHI_URL = "Model/Dance/Stage/ashi2";

	// Token: 0x04000624 RID: 1572
	private const string SONG_URL = "Sound/Ar/StrawberryShort";

	// Token: 0x04000625 RID: 1573
	private const string AR_ATLAS_URL = "Texture/Ar/Ar2Atlas";

	// Token: 0x04000626 RID: 1574
	private const string AR_FINISH_ATLAS_URL = "Texture/Ar/ArFinishAtlas";

	// Token: 0x04000627 RID: 1575
	private const string AR_HELP_ATLAS_URL = "Texture/Ar/Ar2HelpAtlas";

	// Token: 0x04000628 RID: 1576
	private const string AR_BANNER_ATLAS_URL = "Texture/Ar/Ar2BannerAtlas";

	// Token: 0x04000629 RID: 1577
	private const string AR_SHARE_TICKET_URL = "Texture/Ar/ShareTicket";

	// Token: 0x0400062A RID: 1578
	private const string AR_EFFECT = "Model/Dance/Stage/effect2";

	// Token: 0x0400062B RID: 1579
	private const int UV_WIDTH = 3;

	// Token: 0x0400062C RID: 1580
	private const int UV_TOTAL = 15;

	// Token: 0x0400062D RID: 1581
	private const float MONITOR_WIDTH = 0.314f;

	// Token: 0x0400062E RID: 1582
	private const float MONITOR_HEIGHT = -0.176f;

	// Token: 0x0400062F RID: 1583
	private static ArDL2Controller _instance;

	// Token: 0x04000630 RID: 1584
	public Camera _arCam;

	// Token: 0x04000631 RID: 1585
	public Camera _modelCam;

	// Token: 0x04000632 RID: 1586
	public Transform _mikuContainer;

	// Token: 0x04000633 RID: 1587
	public Transform _stageContainer;

	// Token: 0x04000634 RID: 1588
	public Transform _arSurface;

	// Token: 0x04000635 RID: 1589
	public Material _ar2Mat;

	// Token: 0x04000636 RID: 1590
	public Material _shareMat;

	// Token: 0x04000637 RID: 1591
	public Material _arHelpMat;

	// Token: 0x04000638 RID: 1592
	public Material _arBannerMat;

	// Token: 0x04000639 RID: 1593
	private GameObject _miku;

	// Token: 0x0400063A RID: 1594
	private GameObject _stage;

	// Token: 0x0400063B RID: 1595
	private GameObject _ashi;

	// Token: 0x0400063C RID: 1596
	private Texture2D _shareTicket;

	// Token: 0x0400063D RID: 1597
	private GameObject _effect;

	// Token: 0x0400063E RID: 1598
	private float _curTime;

	// Token: 0x0400063F RID: 1599
	private int _curIndex;

	// Token: 0x04000640 RID: 1600
	private string[] _downloadList;

	// Token: 0x04000641 RID: 1601
	private bool _isStartedDownload;
}
