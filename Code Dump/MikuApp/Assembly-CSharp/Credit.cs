using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Credit : MonoBehaviour
{
	public UISprite title;

	public UISprite content;

	public UISprite content2;

	[HideInInspector]
	public bool isRunning;

	public event Action onCreditFinish
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

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void ToX(Transform t, float x)
	{
	}

	public void Run()
	{
	}

	[DebuggerHidden]
	private IEnumerator IERun()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator IEShow()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator IEHide()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	public Coroutine Sync()
	{
		return (Coroutine)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	public IEnumerator PauseRoutine()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}
}
