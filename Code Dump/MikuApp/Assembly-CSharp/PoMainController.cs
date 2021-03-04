using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PoMainController : MonoBehaviour
{
	public PoController _poCtrl;

	public PoUIController _poUICtrl;

	public PoDLController _poDlCtrl;

	public TouchScriptForMaxCam _poModelCtrl;

	public QCARBehaviour2 _qcarCtrl;

	public Transform _mikuContainer;

	[HideInInspector]
	public GameObject _curModel;

	[HideInInspector]
	public MSpecialPose _specialData;

	[HideInInspector]
	public List<string> faceList;

	[HideInInspector]
	public List<string> poseList;

	private bool isStarted;

	public virtual void Init()
	{
	}

	public void GetProperties(PoMainController other)
	{
	}

	private void Start()
	{
	}

	protected void ResetCenter(GameObject go, string spinePath)
	{
	}

	protected void ResetCenter(Vector3 prevSpinePos, GameObject go, string spinePath)
	{
	}

	private void OnEnable()
	{
	}

	private void AddDelegates()
	{
	}

	private void OnDisable()
	{
	}

	private void RemoveDelegates()
	{
	}

	protected virtual void OnDownloadCompleted()
	{
	}

	protected virtual void OnFaceItemChange(int itemId)
	{
	}

	protected virtual void OnPoseItemChange(int itemId)
	{
	}

	[DebuggerHidden]
	protected IEnumerator ShowSpecialDialog()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	protected virtual void OnGoToAr()
	{
	}

	private void OnSpecialDialogClose()
	{
	}

	private void OnSpecialDialogGoar()
	{
	}

	private void ToPortrait()
	{
	}

	private void RunSpecial()
	{
	}

	private void GoToAr()
	{
	}

	private void UnlockUI()
	{
	}

	private void OnBannerClick()
	{
	}

	private void OnArBackClick()
	{
	}

	private void OnTrackingFound(string obj)
	{
	}

	private void OnTrackingLost()
	{
	}

	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnSwitchNormalClick()
	{
	}

	private void OnSwitchNewClick()
	{
	}
}
