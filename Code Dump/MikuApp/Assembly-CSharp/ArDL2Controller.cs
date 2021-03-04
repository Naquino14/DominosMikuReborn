using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ArDL2Controller : MonoBehaviour
{
	private const string EFFECT_ANIM = "MasterEffectAnim";

	private const string MIKU_URL = "Model/Dance/Miku/miku2";

	private const string STAGE_URL = "Model/Dance/Stage/stage2";

	private const string ASHI_URL = "Model/Dance/Stage/ashi2";

	private const string SONG_URL = "Sound/Ar/StrawberryShort";

	private const string AR_ATLAS_URL = "Texture/Ar/Ar2Atlas";

	private const string AR_FINISH_ATLAS_URL = "Texture/Ar/ArFinishAtlas";

	private const string AR_HELP_ATLAS_URL = "Texture/Ar/Ar2HelpAtlas";

	private const string AR_BANNER_ATLAS_URL = "Texture/Ar/Ar2BannerAtlas";

	private const string AR_SHARE_TICKET_URL = "Texture/Ar/ShareTicket";

	private const string AR_EFFECT = "Model/Dance/Stage/effect2";

	private const int UV_WIDTH = 3;

	private const int UV_TOTAL = 15;

	private const float MONITOR_WIDTH = 0.314f;

	private const float MONITOR_HEIGHT = -0.176f;

	private static ArDL2Controller _instance;

	public Camera _arCam;

	public Camera _modelCam;

	public Transform _mikuContainer;

	public Transform _stageContainer;

	public Transform _arSurface;

	public Material _ar2Mat;

	public Material _shareMat;

	public Material _arHelpMat;

	public Material _arBannerMat;

	private GameObject _miku;

	private GameObject _stage;

	private GameObject _ashi;

	private Texture2D _shareTicket;

	private GameObject _effect;

	private float _curTime;

	private int _curIndex;

	private string[] _downloadList;

	private bool _isStartedDownload;

	public static ArDL2Controller Instance => (ArDL2Controller)/*Error near IL_0001: Stack underflow*/;

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

	public GameObject GetMiku()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	public GameObject GetAshi()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	public Texture GetShareTicket()
	{
		return (Texture)/*Error near IL_0001: Stack underflow*/;
	}

	public GameObject GetEffect()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnOKClick()
	{
	}

	private bool isCachedAll()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private bool isDownloadedAll()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	[DebuggerHidden]
	private IEnumerator Download()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator AfterDownload()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void SetMaterialTexture()
	{
	}

	private UnityEngine.Object GetItemByName(string item)
	{
		return (UnityEngine.Object)/*Error near IL_0001: Stack underflow*/;
	}

	private GameObject InstantiateByName(string item, Transform parent)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private GameObject InstantiateByName(string item, Transform parent, Vector3 pos)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private GameObject InstantiateAshiByName(string item, Transform parent)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private GameObject InstantiateEffectByName(string item, Transform parent)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private void SetBase(Transform t, Transform parent)
	{
	}

	private void SetMikuBase(Transform t, Transform parent)
	{
	}

	private void ActiveTransformArray(Transform[] ts, bool active)
	{
	}

	private void SetAshiBase(Transform t, Transform parent)
	{
	}

	private void SetStageBase(Transform t, Transform parent)
	{
	}

	private void Update()
	{
	}

	private void TutorialProgressCheck()
	{
	}

	public void TrackerStop()
	{
	}
}
