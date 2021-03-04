using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PoDLController : MonoBehaviour
{
	private const string MIKU_URL = "Model/Portrait/Miku/miku_fix";

	private const string NEKO_URL = "Model/Portrait/Miku/miku_neko_fix";

	private const string MIKU_2_URL = "Model/Portrait/Miku/miku2_fix";

	private const string PO_DIALOG_ATLAS_URL = "Texture/Portrait/DialogAtlas";

	private const string PO_DISK_URL = "Texture/Portrait/DiskAtlas";

	private const string PO_HELP_ATLAS_URL = "Texture/Portrait/PoHelpAtlas";

	private const string PO_URL = "Texture/Portrait/PortraitAtlas";

	public CacheController cache;

	public Material _poDialogMat;

	public Material _poDiskMat;

	public Material _poHelpMat;

	public Material _poMat;

	public Camera _arCam;

	public Camera _modelCam;

	public Transform _mikuContainer;

	public Transform _modelCenter;

	private GameObject _miku;

	private GameObject _neko;

	private bool _isStartedDownload;

	private bool _isFinishedDownload;

	private string[] _downloadList;

	public bool IsFinishedDownload => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

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

	public GameObject GetNeko()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	public GameObject GetMiku2()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	public GameObject GetNeko2()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private GameObject GetMikuByURL(GameObject prefab)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private GameObject GetNekoByURL(GameObject prefab)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private void Awake()
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

	[DebuggerHidden]
	private IEnumerator Download()
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

	private GameObject InstantiateByName(string name, string item)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	private GameObject InstantiateByPrefab(GameObject prefab)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	public void ResetCenter(GameObject go, string spinePath)
	{
	}

	private void Update()
	{
	}
}
