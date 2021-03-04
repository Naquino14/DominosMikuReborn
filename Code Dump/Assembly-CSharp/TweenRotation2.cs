using System;
using UnityEngine;

// Token: 0x020000FB RID: 251
public class TweenRotation2 : TweenRotation
{
	// Token: 0x060007A7 RID: 1959 RVA: 0x0000399C File Offset: 0x00001B9C
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x000039A0 File Offset: 0x00001BA0
	public static TweenRotation Begin(GameObject go, float duration, Vector3 eulerAngles)
	{
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x000039A4 File Offset: 0x00001BA4
	public static TweenRotation Begin(GameObject go, float duration, Vector3 eulerAngles, GameObject eventReceiver, string updateFunction)
	{
	}

	// Token: 0x040004CE RID: 1230
	public string updateFunction;
}
