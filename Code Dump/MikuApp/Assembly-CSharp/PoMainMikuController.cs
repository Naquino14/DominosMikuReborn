using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PoMainMikuController : PoMainController
{
	private const string MIKU_SPINE_PATH = "Reference/Hips/Spine";

	private const string NEKO_SPINE_PATH = "neko_pose:Reference/neko_pose:Hips/neko_pose:Spine";

	private GameObject _miku;

	private GameObject _neko;

	private bool _isAnimCheck;

	private bool _isInitedMiku;

	private GameObject _prevModel;

	private Vector3 _prevSpinePos;

	private Transform _itemBone;

	private void Update()
	{
	}

	protected override void OnDownloadCompleted()
	{
	}

	public override void Init()
	{
	}

	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void InitMiku()
	{
	}

	private void InitNeko()
	{
	}

	private void DeactiveNeko()
	{
	}

	protected override void OnFaceItemChange(int itemId)
	{
	}

	protected override void OnPoseItemChange(int itemId)
	{
	}

	protected override void OnGoToAr()
	{
	}

	private void OnAnimFinish()
	{
	}

	private void ResetCenter()
	{
	}

	private string GetSpinePath()
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	private string GetSpinePath(GameObject go)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	private void SetMixing(GameObject go, Transform faceBone, Transform allBone)
	{
	}

	private void SetFaceMixing(GameObject go, bool recursive, Transform faceBone)
	{
	}

	private void SetPoseMixing(GameObject go, bool recursive, Transform faceBone, Transform allBone)
	{
	}

	private void SetPoseItemMixing(GameObject go, Transform itemBone)
	{
	}

	private void Mix(GameObject go, string anim, List<Transform> boneList, bool recursive)
	{
	}

	private void ActiveModel(GameObject go)
	{
	}
}
