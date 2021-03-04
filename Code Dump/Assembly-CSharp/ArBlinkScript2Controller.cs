using System;
using UnityEngine;

// Token: 0x02000122 RID: 290
public class ArBlinkScript2Controller : ArBlinkScriptController
{
	// Token: 0x060008EF RID: 2287 RVA: 0x00003EB8 File Offset: 0x000020B8
	public void Start()
	{
	}

	// Token: 0x060008F0 RID: 2288 RVA: 0x00003EBC File Offset: 0x000020BC
	protected override void OnUpdate()
	{
	}

	// Token: 0x060008F1 RID: 2289 RVA: 0x00003EC0 File Offset: 0x000020C0
	private void Phase1_1()
	{
	}

	// Token: 0x060008F2 RID: 2290 RVA: 0x00003EC4 File Offset: 0x000020C4
	private void Phase1_1_1()
	{
	}

	// Token: 0x060008F3 RID: 2291 RVA: 0x00003EC8 File Offset: 0x000020C8
	private void Phase1_2()
	{
	}

	// Token: 0x060008F4 RID: 2292 RVA: 0x00003ECC File Offset: 0x000020CC
	private void Phase1_3()
	{
	}

	// Token: 0x060008F5 RID: 2293 RVA: 0x00003ED0 File Offset: 0x000020D0
	private void Phase1_4()
	{
	}

	// Token: 0x060008F6 RID: 2294 RVA: 0x00003ED4 File Offset: 0x000020D4
	private void Phase1_5()
	{
	}

	// Token: 0x060008F7 RID: 2295 RVA: 0x00003ED8 File Offset: 0x000020D8
	private void Phase2_1()
	{
	}

	// Token: 0x060008F8 RID: 2296 RVA: 0x00003EDC File Offset: 0x000020DC
	private void Phase3_1()
	{
	}

	// Token: 0x060008F9 RID: 2297 RVA: 0x00003EE0 File Offset: 0x000020E0
	private void Phase4_1()
	{
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x00003EE4 File Offset: 0x000020E4
	private void Phase4_2()
	{
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x00003EE8 File Offset: 0x000020E8
	private void Phase5_1()
	{
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x00003EEC File Offset: 0x000020EC
	private void Phase5_2()
	{
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x00003EF0 File Offset: 0x000020F0
	private void Phase6_1()
	{
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x00003EF4 File Offset: 0x000020F4
	private void Phase6_2()
	{
	}

	// Token: 0x060008FF RID: 2303 RVA: 0x00003EF8 File Offset: 0x000020F8
	private void Phase6_3()
	{
	}

	// Token: 0x06000900 RID: 2304 RVA: 0x00003EFC File Offset: 0x000020FC
	private void Phase7_1()
	{
	}

	// Token: 0x06000901 RID: 2305 RVA: 0x00003F00 File Offset: 0x00002100
	private void Phase8_1()
	{
	}

	// Token: 0x06000902 RID: 2306 RVA: 0x00003F04 File Offset: 0x00002104
	private bool IsInitedPhase(string phaseName)
	{
	}

	// Token: 0x06000903 RID: 2307 RVA: 0x00003F08 File Offset: 0x00002108
	private void ResetPhase()
	{
	}

	// Token: 0x06000904 RID: 2308 RVA: 0x00003F0C File Offset: 0x0000210C
	private void RandomSix(float delay)
	{
	}

	// Token: 0x040005A6 RID: 1446
	private const float SPEED_FAST = 0.05f;

	// Token: 0x040005A7 RID: 1447
	private const float SPEED_NOT_VERY_FAST = 0.1f;

	// Token: 0x040005A8 RID: 1448
	private const float SPEED_SLOW = 0.2f;

	// Token: 0x040005A9 RID: 1449
	private const float SPEED_SUPER_SLOW = 0.4f;

	// Token: 0x040005AA RID: 1450
	public ArBlinkController _blinkCtrl;

	// Token: 0x040005AB RID: 1451
	public TextAsset _randSixFile;

	// Token: 0x040005AC RID: 1452
	private StageAnimModel _randSixData;

	// Token: 0x040005AD RID: 1453
	private int _maxSquare;

	// Token: 0x040005AE RID: 1454
	private string _phase;

	// Token: 0x040005AF RID: 1455
	private int _phaseCount;

	// Token: 0x040005B0 RID: 1456
	private bool _isFinished;
}
