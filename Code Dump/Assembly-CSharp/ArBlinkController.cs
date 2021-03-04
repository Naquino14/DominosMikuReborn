using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200011F RID: 287
public class ArBlinkController : MonoBehaviour
{
	// Token: 0x060008BF RID: 2239 RVA: 0x00003DF8 File Offset: 0x00001FF8
	public void Play()
	{
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00003DFC File Offset: 0x00001FFC
	private void Awake()
	{
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00003E00 File Offset: 0x00002000
	public int LoadFromFile(TextAsset file, ref StageAnimModel data)
	{
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00003E04 File Offset: 0x00002004
	public void LoadStage(StageAnimModel data, int index)
	{
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00003E08 File Offset: 0x00002008
	public void LoadStage(List<int> list)
	{
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x00003E0C File Offset: 0x0000200C
	public void AddColumn(List<int> column, float percent, ref List<int> list)
	{
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x00003E10 File Offset: 0x00002010
	public void OffAllSquare()
	{
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x00003E14 File Offset: 0x00002014
	private void DoubleLines()
	{
	}

	// Token: 0x060008C7 RID: 2247 RVA: 0x00003E18 File Offset: 0x00002018
	public void CreateSquares(int maxSquare)
	{
	}

	// Token: 0x060008C8 RID: 2248 RVA: 0x00003E1C File Offset: 0x0000201C
	private void CreatePosList()
	{
	}

	// Token: 0x060008C9 RID: 2249 RVA: 0x00003E20 File Offset: 0x00002020
	private void CreateSquare(float x, float z)
	{
	}

	// Token: 0x04000585 RID: 1413
	public Transform polySurface;

	// Token: 0x04000586 RID: 1414
	public GameObject surfacePrefab;

	// Token: 0x04000587 RID: 1415
	private List<GameObject> _squares;

	// Token: 0x04000588 RID: 1416
	private List<Vector2> _posList;

	// Token: 0x04000589 RID: 1417
	public float frameRate;

	// Token: 0x0400058A RID: 1418
	private int[] _lines;

	// Token: 0x0400058B RID: 1419
	private float _originZ;

	// Token: 0x0400058C RID: 1420
	private float _originW;

	// Token: 0x0400058D RID: 1421
	private float _originD;

	// Token: 0x0400058E RID: 1422
	public Material whiteMat;
}
