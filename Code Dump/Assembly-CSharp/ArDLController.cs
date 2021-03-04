using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000125 RID: 293
public class ArDLController : MonoBehaviour
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x0600091F RID: 2335 RVA: 0x00003F78 File Offset: 0x00002178
	// (remove) Token: 0x06000920 RID: 2336 RVA: 0x00003F7C File Offset: 0x0000217C
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

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000921 RID: 2337 RVA: 0x00003F80 File Offset: 0x00002180
	public static ArDLController Instance
	{
		get
		{
		}
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00003F84 File Offset: 0x00002184
	public GameObject GetMiku()
	{
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00003F88 File Offset: 0x00002188
	public GameObject GetAshi()
	{
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00003F8C File Offset: 0x0000218C
	public GameObject GetFloor()
	{
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00003F90 File Offset: 0x00002190
	public GameObject GetMonitor()
	{
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00003F94 File Offset: 0x00002194
	public Texture GetShareTicket()
	{
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00003F98 File Offset: 0x00002198
	private void Awake()
	{
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00003F9C File Offset: 0x0000219C
	private void OnDestroy()
	{
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00003FA0 File Offset: 0x000021A0
	[DebuggerHidden]
	private IEnumerator Start()
	{
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00003FA4 File Offset: 0x000021A4
	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00003FA8 File Offset: 0x000021A8
	private void OnOKClick()
	{
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00003FAC File Offset: 0x000021AC
	private bool isCachedAll()
	{
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00003FB0 File Offset: 0x000021B0
	private bool isDownloadedAll()
	{
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00003FB4 File Offset: 0x000021B4
	[DebuggerHidden]
	private IEnumerator Download()
	{
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00003FB8 File Offset: 0x000021B8
	[DebuggerHidden]
	private IEnumerator AfterDownload()
	{
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00003FBC File Offset: 0x000021BC
	private void SetMaterialTexture()
	{
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00003FC0 File Offset: 0x000021C0
	private UnityEngine.Object GetItemByName(string item)
	{
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00003FC4 File Offset: 0x000021C4
	private GameObject InstantiateByName(string item, Transform parent)
	{
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00003FC8 File Offset: 0x000021C8
	private GameObject InstantiateByName(string item, Transform parent, Vector3 pos)
	{
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00003FCC File Offset: 0x000021CC
	private GameObject InstantiateAshiByName(string item, Transform parent)
	{
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00003FD0 File Offset: 0x000021D0
	private void SetBase(Transform t, Transform parent)
	{
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00003FD4 File Offset: 0x000021D4
	private void SetAshiBase(Transform t, Transform parent)
	{
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x00003FD8 File Offset: 0x000021D8
	private void Update()
	{
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00003FDC File Offset: 0x000021DC
	private void ThreeMonitorAnimation()
	{
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00003FE0 File Offset: 0x000021E0
	private void DominoTextAnimation()
	{
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00003FE4 File Offset: 0x000021E4
	private void TutorialProgressCheck()
	{
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x00003FE8 File Offset: 0x000021E8
	public void TrackerStop()
	{
	}

	// Token: 0x040005CA RID: 1482
	private const string MIKU_URL = "Model/Dance/Miku/miku1";

	// Token: 0x040005CB RID: 1483
	private const string STAGE_URL = "Model/Dance/Stage/stage1";

	// Token: 0x040005CC RID: 1484
	private const string ASHI_URL = "Model/Dance/Stage/ashi1";

	// Token: 0x040005CD RID: 1485
	private const string MONITOR_URL = "Model/Dance/Stage/alpha_monitor1";

	// Token: 0x040005CE RID: 1486
	private const string SONG_URL = "Sound/Ar/Luv4NightShort";

	// Token: 0x040005CF RID: 1487
	private const string AR_ATLAS_URL = "Texture/Ar/ArAtlas";

	// Token: 0x040005D0 RID: 1488
	private const string AR_FINISH_ATLAS_URL = "Texture/Ar/ArFinishAtlas";

	// Token: 0x040005D1 RID: 1489
	private const string AR_HELP_ATLAS_URL = "Texture/Ar/Ar2HelpAtlas";

	// Token: 0x040005D2 RID: 1490
	private const string AR_BANNER_ATLAS_URL = "Texture/Ar/Ar2BannerAtlas";

	// Token: 0x040005D3 RID: 1491
	private const string AR_SHARE_TICKET_URL = "Texture/Ar/ShareTicket";

	// Token: 0x040005D4 RID: 1492
	private const int UV_WIDTH = 3;

	// Token: 0x040005D5 RID: 1493
	private const int UV_TOTAL = 15;

	// Token: 0x040005D6 RID: 1494
	private const float MONITOR_WIDTH = 0.314f;

	// Token: 0x040005D7 RID: 1495
	private const float MONITOR_HEIGHT = -0.176f;

	// Token: 0x040005D8 RID: 1496
	private static ArDLController _instance;

	// Token: 0x040005D9 RID: 1497
	public Camera _arCam;

	// Token: 0x040005DA RID: 1498
	public Camera _modelCam;

	// Token: 0x040005DB RID: 1499
	public Transform _mikuContainer;

	// Token: 0x040005DC RID: 1500
	public Transform _stageContainer;

	// Token: 0x040005DD RID: 1501
	public Transform _arSurface;

	// Token: 0x040005DE RID: 1502
	public Material _ar2Mat;

	// Token: 0x040005DF RID: 1503
	public Material _shareMat;

	// Token: 0x040005E0 RID: 1504
	public Material _arHelpMat;

	// Token: 0x040005E1 RID: 1505
	public Material _arBannerMat;

	// Token: 0x040005E2 RID: 1506
	private GameObject _miku;

	// Token: 0x040005E3 RID: 1507
	private GameObject _stage;

	// Token: 0x040005E4 RID: 1508
	private GameObject _ashi;

	// Token: 0x040005E5 RID: 1509
	private GameObject _monitor;

	// Token: 0x040005E6 RID: 1510
	private GameObject _runText;

	// Token: 0x040005E7 RID: 1511
	private Texture2D _shareTicket;

	// Token: 0x040005E8 RID: 1512
	private GameObject[] _monitors;

	// Token: 0x040005E9 RID: 1513
	private float _monitorChangeTime;

	// Token: 0x040005EA RID: 1514
	private float _curTime;

	// Token: 0x040005EB RID: 1515
	private int _curIndex;

	// Token: 0x040005EC RID: 1516
	private string[] _downloadList;

	// Token: 0x040005ED RID: 1517
	private bool _isStartedDownload;
}
