using System;
using UnityEngine;

// Token: 0x02000118 RID: 280
public class DLLabelBlink : MonoBehaviour
{
	// Token: 0x06000860 RID: 2144 RVA: 0x00003C7C File Offset: 0x00001E7C
	private void Awake()
	{
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x00003C80 File Offset: 0x00001E80
	public void Run()
	{
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x00003C84 File Offset: 0x00001E84
	private void OnDestroy()
	{
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x00003C88 File Offset: 0x00001E88
	private void Start()
	{
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x00003C8C File Offset: 0x00001E8C
	private void Blink()
	{
	}

	// Token: 0x04000552 RID: 1362
	public UILabel _uiSprite;

	// Token: 0x04000553 RID: 1363
	public Color _onColor;

	// Token: 0x04000554 RID: 1364
	public Color _offColor;

	// Token: 0x04000555 RID: 1365
	public float _blinkDuration;

	// Token: 0x04000556 RID: 1366
	private float _curTime;

	// Token: 0x04000557 RID: 1367
	private bool _isOn;

	// Token: 0x04000558 RID: 1368
	private int _count;
}
