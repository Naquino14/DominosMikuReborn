using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000112 RID: 274
public class Aim : MonoBehaviour
{
	// Token: 0x06000834 RID: 2100 RVA: 0x00003BCC File Offset: 0x00001DCC
	public void Hide()
	{
	}

	// Token: 0x06000835 RID: 2101 RVA: 0x00003BD0 File Offset: 0x00001DD0
	public void HideOnly2()
	{
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x00003BD4 File Offset: 0x00001DD4
	public void HideOnly()
	{
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x00003BD8 File Offset: 0x00001DD8
	public void Show()
	{
	}

	// Token: 0x06000838 RID: 2104 RVA: 0x00003BDC File Offset: 0x00001DDC
	[DebuggerHidden]
	private IEnumerator IEblink()
	{
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x00003BE0 File Offset: 0x00001DE0
	[DebuggerHidden]
	private IEnumerator IEhide()
	{
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00003BE4 File Offset: 0x00001DE4
	[DebuggerHidden]
	private IEnumerator IEhideOnly()
	{
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00003BE8 File Offset: 0x00001DE8
	[DebuggerHidden]
	private IEnumerator IEshow()
	{
	}

	// Token: 0x0400053A RID: 1338
	public UISprite[] _imgs;
}
