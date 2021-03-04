using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000120 RID: 288
public class ArBlinkScriptController : MonoBehaviour
{
	// Token: 0x060008CB RID: 2251 RVA: 0x00003E28 File Offset: 0x00002028
	private void Update()
	{
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00003E2C File Offset: 0x0000202C
	protected virtual void OnUpdate()
	{
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00003E30 File Offset: 0x00002030
	public void Run()
	{
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00003E34 File Offset: 0x00002034
	public void Pause()
	{
	}

	// Token: 0x060008CF RID: 2255 RVA: 0x00003E38 File Offset: 0x00002038
	public void Resume()
	{
	}

	// Token: 0x060008D0 RID: 2256 RVA: 0x00003E3C File Offset: 0x0000203C
	public Coroutine Sync()
	{
	}

	// Token: 0x060008D1 RID: 2257 RVA: 0x00003E40 File Offset: 0x00002040
	[DebuggerHidden]
	public IEnumerator PauseRoutine()
	{
	}

	// Token: 0x0400058F RID: 1423
	protected float _startTime;

	// Token: 0x04000590 RID: 1424
	protected float _pauseTime;

	// Token: 0x04000591 RID: 1425
	protected bool _isPause;

	// Token: 0x04000592 RID: 1426
	protected float _curPhaseTime;
}
