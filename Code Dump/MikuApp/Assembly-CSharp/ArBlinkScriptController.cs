using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class ArBlinkScriptController : MonoBehaviour
{
	protected float _startTime;

	protected float _pauseTime;

	protected bool _isPause;

	protected float _curPhaseTime;

	private void Update()
	{
	}

	protected virtual void OnUpdate()
	{
	}

	public void Run()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
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
