using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000123 RID: 291
public class ArBlinkScript3Controller : ArBlinkScriptController
{
	// Token: 0x06000906 RID: 2310 RVA: 0x00003F14 File Offset: 0x00002114
	public void Start()
	{
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x00003F18 File Offset: 0x00002118
	protected override void OnUpdate()
	{
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x00003F1C File Offset: 0x0000211C
	[DebuggerHidden]
	private IEnumerator Finish()
	{
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x00003F20 File Offset: 0x00002120
	private void MusicVisualization()
	{
	}

	// Token: 0x040005B1 RID: 1457
	private const int SAMPLE_NUMBER = 8;

	// Token: 0x040005B2 RID: 1458
	private const float MAX_VALUE = 3.5f;

	// Token: 0x040005B3 RID: 1459
	public ArBlinkController _blinkCtrl;

	// Token: 0x040005B4 RID: 1460
	public TextAsset[] _files;

	// Token: 0x040005B5 RID: 1461
	private StageAnimModel[] _data;

	// Token: 0x040005B6 RID: 1462
	public TextAsset _dominoFile;

	// Token: 0x040005B7 RID: 1463
	private StageAnimModel _dominoData;

	// Token: 0x040005B8 RID: 1464
	private float[] samples;

	// Token: 0x040005B9 RID: 1465
	private float[] curValues;

	// Token: 0x040005BA RID: 1466
	private int _maxSquare;

	// Token: 0x040005BB RID: 1467
	private bool _isFinished;
}
