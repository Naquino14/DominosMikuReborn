using System;
using UnityEngine;

// Token: 0x0200011E RID: 286
public class PoBlink : MonoBehaviour
{
	// Token: 0x060008B9 RID: 2233 RVA: 0x00003DE0 File Offset: 0x00001FE0
	private void Awake()
	{
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00003DE4 File Offset: 0x00001FE4
	public void Run()
	{
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00003DE8 File Offset: 0x00001FE8
	private void OnDestroy()
	{
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x00003DEC File Offset: 0x00001FEC
	private void Update()
	{
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00003DF0 File Offset: 0x00001FF0
	private void Blink()
	{
	}

	// Token: 0x0400057C RID: 1404
	public UISprite _uiSprite;

	// Token: 0x0400057D RID: 1405
	public string _onSprite;

	// Token: 0x0400057E RID: 1406
	public string _offSprite;

	// Token: 0x0400057F RID: 1407
	public float _restDuration;

	// Token: 0x04000580 RID: 1408
	public float _blinkDuration;

	// Token: 0x04000581 RID: 1409
	public float _blinkTimes;

	// Token: 0x04000582 RID: 1410
	private float _curTime;

	// Token: 0x04000583 RID: 1411
	private bool _isOn;

	// Token: 0x04000584 RID: 1412
	private int _count;
}
