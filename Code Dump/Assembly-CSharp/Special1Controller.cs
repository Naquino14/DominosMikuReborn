using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200013C RID: 316
public class Special1Controller : SpecialController
{
	// Token: 0x06000ABF RID: 2751 RVA: 0x000045F8 File Offset: 0x000027F8
	protected override void Init()
	{
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x000045FC File Offset: 0x000027FC
	[DebuggerHidden]
	protected override IEnumerator ShowPose()
	{
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00004600 File Offset: 0x00002800
	[DebuggerHidden]
	protected override IEnumerator ShowDiskAnim()
	{
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00004604 File Offset: 0x00002804
	protected override void OnRotationFinish()
	{
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00004608 File Offset: 0x00002808
	[DebuggerHidden]
	private IEnumerator Capture()
	{
	}

	// Token: 0x040006DE RID: 1758
	private GameObject _miku;

	// Token: 0x040006DF RID: 1759
	private GameObject _neko;

	// Token: 0x040006E0 RID: 1760
	private ArNavi _mask;
}
