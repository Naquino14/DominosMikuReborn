using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000143 RID: 323
public class TestBlinkController : MonoBehaviour
{
	// Token: 0x06000AF5 RID: 2805 RVA: 0x000046D0 File Offset: 0x000028D0
	private void Awake()
	{
	}

	// Token: 0x06000AF6 RID: 2806 RVA: 0x000046D4 File Offset: 0x000028D4
	private void Start()
	{
	}

	// Token: 0x06000AF7 RID: 2807 RVA: 0x000046D8 File Offset: 0x000028D8
	private void UpdateSquares()
	{
	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x000046DC File Offset: 0x000028DC
	private void DeactiveOldSquares()
	{
	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x000046E0 File Offset: 0x000028E0
	private void DoubleLines()
	{
	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x000046E4 File Offset: 0x000028E4
	private void CreateSquares()
	{
	}

	// Token: 0x06000AFB RID: 2811 RVA: 0x000046E8 File Offset: 0x000028E8
	private void CreatePosList()
	{
	}

	// Token: 0x06000AFC RID: 2812 RVA: 0x000046EC File Offset: 0x000028EC
	private void CreateSquare(float x, float z)
	{
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x000046F0 File Offset: 0x000028F0
	private Color RandomColor()
	{
	}

	// Token: 0x040006FA RID: 1786
	private const int MAX_SQUARE = 40;

	// Token: 0x040006FB RID: 1787
	public Transform polySurface;

	// Token: 0x040006FC RID: 1788
	public GameObject surfacePrefab;

	// Token: 0x040006FD RID: 1789
	private List<GameObject> _squares;

	// Token: 0x040006FE RID: 1790
	private List<Vector2> _posList;

	// Token: 0x040006FF RID: 1791
	private int[] _lines;

	// Token: 0x04000700 RID: 1792
	private float _originZ;

	// Token: 0x04000701 RID: 1793
	private float _originW;

	// Token: 0x04000702 RID: 1794
	private float _originD;

	// Token: 0x04000703 RID: 1795
	public Material whiteMat;
}
