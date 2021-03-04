using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ArUIController : MonoBehaviour
{
	public Transform _panel;

	public Aim _aim;

	public Guide _guide;

	public ArNavi _back;

	public ArNavi _help;

	public Credit _credit;

	public GameObject _logo;

	public GameObject _warning;

	public Camera _uiCam;

	public BoxCollider _shield;

	private bool IsFoundOneTime;

	private bool IsLostOneTime;

	public event Action onCloseClick
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void OnCreditFinish()
	{
	}

	public void OnCloseClick()
	{
	}

	public void OnHelpClick()
	{
	}

	[DebuggerHidden]
	public IEnumerator ShowHelp()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnHelpClose()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Found()
	{
	}

	public void Found2nd()
	{
	}

	public void Lost()
	{
	}

	public void RunCredit()
	{
	}

	public bool IsRunningCredit()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void Lock()
	{
	}

	public void Unlock()
	{
	}

	[DebuggerHidden]
	private IEnumerator IEfound()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator IElost()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	public void TrackerStart()
	{
	}

	public void TrackerStop()
	{
	}
}
