using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200013D RID: 317
public class SpecialController : MonoBehaviour
{
	// Token: 0x06000AC5 RID: 2757 RVA: 0x00004610 File Offset: 0x00002810
	public virtual void Setup(PoController poCtrl, PoUIController poUICtrl, PoDLController poDlCtrl, TouchScriptForMaxCam poModelCtrl)
	{
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00004614 File Offset: 0x00002814
	private void OnDisable()
	{
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00004618 File Offset: 0x00002818
	public void Run(float delay)
	{
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x0000461C File Offset: 0x0000281C
	[DebuggerHidden]
	public virtual IEnumerator IErun(float delay)
	{
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00004620 File Offset: 0x00002820
	protected virtual void Init()
	{
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00004624 File Offset: 0x00002824
	[DebuggerHidden]
	protected virtual IEnumerator ShowPose()
	{
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00004628 File Offset: 0x00002828
	[DebuggerHidden]
	protected virtual IEnumerator ShowPortraitUI()
	{
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x0000462C File Offset: 0x0000282C
	[DebuggerHidden]
	protected virtual IEnumerator ShowDiskAnim()
	{
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00004630 File Offset: 0x00002830
	protected virtual void OnRotationFinish()
	{
	}

	// Token: 0x040006E1 RID: 1761
	protected PoController _poCtrl;

	// Token: 0x040006E2 RID: 1762
	protected PoUIController _poUICtrl;

	// Token: 0x040006E3 RID: 1763
	protected PoDLController _poDlCtrl;

	// Token: 0x040006E4 RID: 1764
	protected TouchScriptForMaxCam _poModelCtrl;

	// Token: 0x040006E5 RID: 1765
	protected PoMainController _poMainCtrl;
}
