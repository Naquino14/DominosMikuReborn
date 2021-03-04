using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200012A RID: 298
public class ArUIController : MonoBehaviour
{
	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000958 RID: 2392 RVA: 0x0000405C File Offset: 0x0000225C
	// (remove) Token: 0x06000959 RID: 2393 RVA: 0x00004060 File Offset: 0x00002260
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

	// Token: 0x0600095A RID: 2394 RVA: 0x00004064 File Offset: 0x00002264
	private void OnEnable()
	{
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x00004068 File Offset: 0x00002268
	private void OnDisable()
	{
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x0000406C File Offset: 0x0000226C
	private void Awake()
	{
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x00004070 File Offset: 0x00002270
	private void OnCreditFinish()
	{
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x00004074 File Offset: 0x00002274
	public void OnCloseClick()
	{
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00004078 File Offset: 0x00002278
	public void OnHelpClick()
	{
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x0000407C File Offset: 0x0000227C
	[DebuggerHidden]
	public IEnumerator ShowHelp()
	{
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00004080 File Offset: 0x00002280
	private void OnHelpClose()
	{
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00004084 File Offset: 0x00002284
	public void Show()
	{
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00004088 File Offset: 0x00002288
	public void Hide()
	{
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x0000408C File Offset: 0x0000228C
	public void Found()
	{
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00004090 File Offset: 0x00002290
	public void Found2nd()
	{
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00004094 File Offset: 0x00002294
	public void Lost()
	{
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00004098 File Offset: 0x00002298
	public void RunCredit()
	{
	}

	// Token: 0x06000968 RID: 2408 RVA: 0x0000409C File Offset: 0x0000229C
	public bool IsRunningCredit()
	{
	}

	// Token: 0x06000969 RID: 2409 RVA: 0x000040A0 File Offset: 0x000022A0
	public void Lock()
	{
	}

	// Token: 0x0600096A RID: 2410 RVA: 0x000040A4 File Offset: 0x000022A4
	public void Unlock()
	{
	}

	// Token: 0x0600096B RID: 2411 RVA: 0x000040A8 File Offset: 0x000022A8
	[DebuggerHidden]
	private IEnumerator IEfound()
	{
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x000040AC File Offset: 0x000022AC
	[DebuggerHidden]
	private IEnumerator IElost()
	{
	}

	// Token: 0x0600096D RID: 2413 RVA: 0x000040B0 File Offset: 0x000022B0
	public void TrackerStart()
	{
	}

	// Token: 0x0600096E RID: 2414 RVA: 0x000040B4 File Offset: 0x000022B4
	public void TrackerStop()
	{
	}

	// Token: 0x04000608 RID: 1544
	public Transform _panel;

	// Token: 0x04000609 RID: 1545
	public Aim _aim;

	// Token: 0x0400060A RID: 1546
	public Guide _guide;

	// Token: 0x0400060B RID: 1547
	public ArNavi _back;

	// Token: 0x0400060C RID: 1548
	public ArNavi _help;

	// Token: 0x0400060D RID: 1549
	public Credit _credit;

	// Token: 0x0400060E RID: 1550
	public GameObject _logo;

	// Token: 0x0400060F RID: 1551
	public GameObject _warning;

	// Token: 0x04000610 RID: 1552
	public Camera _uiCam;

	// Token: 0x04000611 RID: 1553
	public BoxCollider _shield;

	// Token: 0x04000612 RID: 1554
	private bool IsFoundOneTime;

	// Token: 0x04000613 RID: 1555
	private bool IsLostOneTime;
}
