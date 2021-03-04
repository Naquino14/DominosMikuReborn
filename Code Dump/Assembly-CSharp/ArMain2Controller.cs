using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200012D RID: 301
public class ArMain2Controller : MonoBehaviour
{
	// Token: 0x0600099A RID: 2458 RVA: 0x00004164 File Offset: 0x00002364
	private void Awake()
	{
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00004168 File Offset: 0x00002368
	private void Update()
	{
	}

	// Token: 0x0600099C RID: 2460 RVA: 0x0000416C File Offset: 0x0000236C
	private void OnEnable()
	{
	}

	// Token: 0x0600099D RID: 2461 RVA: 0x00004170 File Offset: 0x00002370
	private void OnDisable()
	{
	}

	// Token: 0x0600099E RID: 2462 RVA: 0x00004174 File Offset: 0x00002374
	private void OnCloseClick()
	{
	}

	// Token: 0x0600099F RID: 2463 RVA: 0x00004178 File Offset: 0x00002378
	private void OnDownloadCompleted()
	{
	}

	// Token: 0x060009A0 RID: 2464 RVA: 0x0000417C File Offset: 0x0000237C
	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
	}

	// Token: 0x060009A1 RID: 2465 RVA: 0x00004180 File Offset: 0x00002380
	private void OnArInited()
	{
	}

	// Token: 0x060009A2 RID: 2466 RVA: 0x00004184 File Offset: 0x00002384
	private void OnTrackingFound(string obj)
	{
	}

	// Token: 0x060009A3 RID: 2467 RVA: 0x00004188 File Offset: 0x00002388
	[DebuggerHidden]
	private IEnumerator PlaySound()
	{
	}

	// Token: 0x060009A4 RID: 2468 RVA: 0x0000418C File Offset: 0x0000238C
	private void ShowRootAfterFound()
	{
	}

	// Token: 0x060009A5 RID: 2469 RVA: 0x00004190 File Offset: 0x00002390
	private void OnTrackingLost()
	{
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00004194 File Offset: 0x00002394
	private void PlayMiku()
	{
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x00004198 File Offset: 0x00002398
	private void ResumeMiku()
	{
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x0000419C File Offset: 0x0000239C
	private void PauseMiku()
	{
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x000041A0 File Offset: 0x000023A0
	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
	}

	// Token: 0x04000643 RID: 1603
	private const string MIKU_ANIM = "Take 001";

	// Token: 0x04000644 RID: 1604
	private const string ASHI_ANIM = "Take 001";

	// Token: 0x04000645 RID: 1605
	private const string EFFECT_ANIM = "MasterEffectAnim";

	// Token: 0x04000646 RID: 1606
	private float deltaTime;

	// Token: 0x04000647 RID: 1607
	public ArController _arCtrl;

	// Token: 0x04000648 RID: 1608
	public ArUIController _arUICtrl;

	// Token: 0x04000649 RID: 1609
	public ArDL2Controller _arDlCtrl;

	// Token: 0x0400064A RID: 1610
	public ArBlinkController _arBlinkCtrl;

	// Token: 0x0400064B RID: 1611
	public ArBlinkScriptController _arBlinkScriptCtrl;

	// Token: 0x0400064C RID: 1612
	[SerializeField]
	private GameObject alphaShield;

	// Token: 0x0400064D RID: 1613
	private bool _IsFirstFound;

	// Token: 0x0400064E RID: 1614
	private bool _IsFinished;

	// Token: 0x0400064F RID: 1615
	private bool _IsSoundPlayed;

	// Token: 0x04000650 RID: 1616
	private GameObject _miku;

	// Token: 0x04000651 RID: 1617
	private GameObject _ashi;

	// Token: 0x04000652 RID: 1618
	private GameObject _effect;

	// Token: 0x04000653 RID: 1619
	private bool _IsClosed;
}
