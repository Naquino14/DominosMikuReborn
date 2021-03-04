using System;
using UnityEngine;

// Token: 0x02000121 RID: 289
public class ArBlinkScript1Controller : ArBlinkScriptController
{
	// Token: 0x060008D3 RID: 2259 RVA: 0x00003E48 File Offset: 0x00002048
	public void Start()
	{
	}

	// Token: 0x060008D4 RID: 2260 RVA: 0x00003E4C File Offset: 0x0000204C
	protected override void OnUpdate()
	{
	}

	// Token: 0x060008D5 RID: 2261 RVA: 0x00003E50 File Offset: 0x00002050
	private void Phase1_1()
	{
	}

	// Token: 0x060008D6 RID: 2262 RVA: 0x00003E54 File Offset: 0x00002054
	private void Phase1_1_1()
	{
	}

	// Token: 0x060008D7 RID: 2263 RVA: 0x00003E58 File Offset: 0x00002058
	private void Phase1_2()
	{
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x00003E5C File Offset: 0x0000205C
	private void Phase1_3()
	{
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x00003E60 File Offset: 0x00002060
	private void Phase1_4()
	{
	}

	// Token: 0x060008DA RID: 2266 RVA: 0x00003E64 File Offset: 0x00002064
	private void Phase1_5()
	{
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x00003E68 File Offset: 0x00002068
	private void Phase2_1()
	{
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x00003E6C File Offset: 0x0000206C
	private void Phase3_1()
	{
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x00003E70 File Offset: 0x00002070
	private void Phase4_1()
	{
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x00003E74 File Offset: 0x00002074
	private void Phase4_2()
	{
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x00003E78 File Offset: 0x00002078
	private void Phase5_1()
	{
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x00003E7C File Offset: 0x0000207C
	private void Phase5_2()
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x00003E80 File Offset: 0x00002080
	private void Phase6_1()
	{
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x00003E84 File Offset: 0x00002084
	private void Phase6_2()
	{
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x00003E88 File Offset: 0x00002088
	private void Phase6_3()
	{
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x00003E8C File Offset: 0x0000208C
	private void Phase7_1()
	{
	}

	// Token: 0x060008E5 RID: 2277 RVA: 0x00003E90 File Offset: 0x00002090
	private void Phase8_1()
	{
	}

	// Token: 0x060008E6 RID: 2278 RVA: 0x00003E94 File Offset: 0x00002094
	private bool IsInitedPhase(string phaseName)
	{
	}

	// Token: 0x060008E7 RID: 2279 RVA: 0x00003E98 File Offset: 0x00002098
	private void ResetPhase()
	{
	}

	// Token: 0x060008E8 RID: 2280 RVA: 0x00003E9C File Offset: 0x0000209C
	private void Expand()
	{
	}

	// Token: 0x060008E9 RID: 2281 RVA: 0x00003EA0 File Offset: 0x000020A0
	private void LoopImages(float delay)
	{
	}

	// Token: 0x060008EA RID: 2282 RVA: 0x00003EA4 File Offset: 0x000020A4
	private void BlinkAnImage(int index)
	{
	}

	// Token: 0x060008EB RID: 2283 RVA: 0x00003EA8 File Offset: 0x000020A8
	private void LoopMiku(float delay)
	{
	}

	// Token: 0x060008EC RID: 2284 RVA: 0x00003EAC File Offset: 0x000020AC
	private void LoopDomino(float delay)
	{
	}

	// Token: 0x060008ED RID: 2285 RVA: 0x00003EB0 File Offset: 0x000020B0
	private void LoopDomino2(float delay)
	{
	}

	// Token: 0x04000593 RID: 1427
	private const float SPEED_FAST = 0.05f;

	// Token: 0x04000594 RID: 1428
	private const float SPEED_NOT_VERY_FAST = 0.1f;

	// Token: 0x04000595 RID: 1429
	private const float SPEED_SLOW = 0.2f;

	// Token: 0x04000596 RID: 1430
	private const float SPEED_SUPER_SLOW = 0.4f;

	// Token: 0x04000597 RID: 1431
	public ArBlinkController _blinkCtrl;

	// Token: 0x04000598 RID: 1432
	public TextAsset _expandFile;

	// Token: 0x04000599 RID: 1433
	public TextAsset _mikuFile;

	// Token: 0x0400059A RID: 1434
	public TextAsset _dominoFile;

	// Token: 0x0400059B RID: 1435
	public TextAsset _domino2File;

	// Token: 0x0400059C RID: 1436
	public TextAsset _imagesFile;

	// Token: 0x0400059D RID: 1437
	private StageAnimModel _expandData;

	// Token: 0x0400059E RID: 1438
	private StageAnimModel _mikuData;

	// Token: 0x0400059F RID: 1439
	private StageAnimModel _dominoData;

	// Token: 0x040005A0 RID: 1440
	private StageAnimModel _domino2Data;

	// Token: 0x040005A1 RID: 1441
	private StageAnimModel _imagesData;

	// Token: 0x040005A2 RID: 1442
	private int _maxSquare;

	// Token: 0x040005A3 RID: 1443
	private string _phase;

	// Token: 0x040005A4 RID: 1444
	private int _phaseCount;

	// Token: 0x040005A5 RID: 1445
	private bool _isFinished;
}
