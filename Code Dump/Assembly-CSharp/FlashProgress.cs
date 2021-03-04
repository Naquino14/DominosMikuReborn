using System;
using UnityEngine;

// Token: 0x02000116 RID: 278
public class FlashProgress : MonoBehaviour
{
	// Token: 0x06000856 RID: 2134 RVA: 0x00003C54 File Offset: 0x00001E54
	private void Awake()
	{
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x00003C58 File Offset: 0x00001E58
	public void Run()
	{
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x00003C5C File Offset: 0x00001E5C
	private void Update()
	{
	}

	// Token: 0x04000544 RID: 1348
	public UISprite _sprite;

	// Token: 0x04000545 RID: 1349
	public float _rate;

	// Token: 0x04000546 RID: 1350
	private float _delta;

	// Token: 0x04000547 RID: 1351
	public float _maxAlpha;

	// Token: 0x04000548 RID: 1352
	public float _minRate;

	// Token: 0x04000549 RID: 1353
	private float _curTime;

	// Token: 0x0400054A RID: 1354
	private bool _flag;
}
