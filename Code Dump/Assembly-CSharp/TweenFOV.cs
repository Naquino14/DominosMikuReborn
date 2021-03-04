using System;
using UnityEngine;

// Token: 0x02000055 RID: 85
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Field of View")]
public class TweenFOV : UITweener
{
	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600025D RID: 605 RVA: 0x000029C0 File Offset: 0x00000BC0
	public Camera cachedCamera
	{
		get
		{
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600025E RID: 606 RVA: 0x000029C4 File Offset: 0x00000BC4
	// (set) Token: 0x0600025F RID: 607 RVA: 0x000029C8 File Offset: 0x00000BC8
	public float fov
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x000029CC File Offset: 0x00000BCC
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	// Token: 0x06000261 RID: 609 RVA: 0x000029D0 File Offset: 0x00000BD0
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
	}

	// Token: 0x04000217 RID: 535
	public float from;

	// Token: 0x04000218 RID: 536
	public float to;

	// Token: 0x04000219 RID: 537
	private Camera mCam;
}
