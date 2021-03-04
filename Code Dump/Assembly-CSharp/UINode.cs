using System;
using UnityEngine;

// Token: 0x0200004C RID: 76
public class UINode
{
	// Token: 0x06000211 RID: 529 RVA: 0x00002890 File Offset: 0x00000A90
	public UINode(Transform t)
	{
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000212 RID: 530 RVA: 0x00002894 File Offset: 0x00000A94
	// (set) Token: 0x06000213 RID: 531 RVA: 0x00002898 File Offset: 0x00000A98
	public int visibleFlag
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000214 RID: 532 RVA: 0x0000289C File Offset: 0x00000A9C
	public bool HasChanged()
	{
	}

	// Token: 0x040001D7 RID: 471
	private int mVisibleFlag;

	// Token: 0x040001D8 RID: 472
	public Transform trans;

	// Token: 0x040001D9 RID: 473
	public UIWidget widget;

	// Token: 0x040001DA RID: 474
	public bool lastActive;

	// Token: 0x040001DB RID: 475
	public Vector3 lastPos;

	// Token: 0x040001DC RID: 476
	public Quaternion lastRot;

	// Token: 0x040001DD RID: 477
	public Vector3 lastScale;

	// Token: 0x040001DE RID: 478
	public int changeFlag;

	// Token: 0x040001DF RID: 479
	private GameObject mGo;
}
