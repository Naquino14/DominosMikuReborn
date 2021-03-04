using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class SpecialController : MonoBehaviour
{
	protected PoController _poCtrl;

	protected PoUIController _poUICtrl;

	protected PoDLController _poDlCtrl;

	protected TouchScriptForMaxCam _poModelCtrl;

	protected PoMainController _poMainCtrl;

	public virtual void Setup(PoController poCtrl, PoUIController poUICtrl, PoDLController poDlCtrl, TouchScriptForMaxCam poModelCtrl)
	{
	}

	private void OnDisable()
	{
	}

	public void Run(float delay)
	{
	}

	[DebuggerHidden]
	public virtual IEnumerator IErun(float delay)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	protected virtual void Init()
	{
	}

	[DebuggerHidden]
	protected virtual IEnumerator ShowPose()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	protected virtual IEnumerator ShowPortraitUI()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	protected virtual IEnumerator ShowDiskAnim()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	protected virtual void OnRotationFinish()
	{
	}
}
