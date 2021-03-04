using System;
using UnityEngine;

// Token: 0x0200014A RID: 330
public class TestUV : MonoBehaviour
{
	// Token: 0x06000B19 RID: 2841 RVA: 0x00004760 File Offset: 0x00002960
	private void Update()
	{
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x00004764 File Offset: 0x00002964
	private void ThreeMonitorAnimation()
	{
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x00004768 File Offset: 0x00002968
	private void DominoTextAnimation()
	{
	}

	// Token: 0x04000714 RID: 1812
	private const int UV_WIDTH = 3;

	// Token: 0x04000715 RID: 1813
	private const int UV_TOTAL = 15;

	// Token: 0x04000716 RID: 1814
	private const float MONITOR_WIDTH = 0.314f;

	// Token: 0x04000717 RID: 1815
	private const float MONITOR_HEIGHT = -0.176f;

	// Token: 0x04000718 RID: 1816
	public GameObject _runText;

	// Token: 0x04000719 RID: 1817
	public GameObject[] _monitors;

	// Token: 0x0400071A RID: 1818
	public float _monitorChangeTime;

	// Token: 0x0400071B RID: 1819
	private float _curTime;

	// Token: 0x0400071C RID: 1820
	private int _curIndex;
}
