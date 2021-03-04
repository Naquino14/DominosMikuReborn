using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ArMainController : MonoBehaviour
{
	private const string MIKU_ANIM = "Take 001";

	private const string ASHI_ANIM = "Take 001";

	private const string FLOOR_ANIM = "FloorAnimation";

	public float deltaTime;

	public ArController _arCtrl;

	public ArUIController _arUICtrl;

	public ArDLController _arDlCtrl;

	public ArBlinkController _arBlinkCtrl;

	public ArBlinkScriptController _arBlinkScriptCtrl;

	private bool _IsFirstFound;

	private bool _IsFinished;

	private bool _IsSoundPlayed;

	private GameObject _miku;

	private GameObject _floor;

	private GameObject _ashi;

	private bool _IsClosed;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnDownloadCompleted()
	{
	}

	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnArInited()
	{
	}

	private void OnTrackingFound(string obj)
	{
	}

	private void ShowRootAfterFound()
	{
	}

	private void OnTrackingLost()
	{
	}

	private void PlayMiku()
	{
	}

	private void ResumeMiku()
	{
	}

	private void PauseMiku()
	{
	}

	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}
}
