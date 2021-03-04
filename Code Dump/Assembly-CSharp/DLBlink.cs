using System;
using UnityEngine;

// Token: 0x02000117 RID: 279
public class DLBlink : MonoBehaviour
{
	// Token: 0x0600085A RID: 2138 RVA: 0x00003C64 File Offset: 0x00001E64
	private void Awake()
	{
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x00003C68 File Offset: 0x00001E68
	public void Run()
	{
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x00003C6C File Offset: 0x00001E6C
	private void OnDestroy()
	{
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x00003C70 File Offset: 0x00001E70
	private void Start()
	{
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x00003C74 File Offset: 0x00001E74
	private void Blink()
	{
	}

	// Token: 0x0400054B RID: 1355
	public UISprite _uiSprite;

	// Token: 0x0400054C RID: 1356
	public string _onSprite;

	// Token: 0x0400054D RID: 1357
	public string _offSprite;

	// Token: 0x0400054E RID: 1358
	public float _blinkDuration;

	// Token: 0x0400054F RID: 1359
	private float _curTime;

	// Token: 0x04000550 RID: 1360
	private bool _isOn;

	// Token: 0x04000551 RID: 1361
	private int _count;
}
