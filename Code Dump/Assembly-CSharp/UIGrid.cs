using System;
using UnityEngine;

// Token: 0x02000026 RID: 38
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : MonoBehaviour
{
	// Token: 0x060000F2 RID: 242 RVA: 0x00002414 File Offset: 0x00000614
	private void Start()
	{
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002418 File Offset: 0x00000618
	private void Update()
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x0000241C File Offset: 0x0000061C
	public static int SortByName(Transform a, Transform b)
	{
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002420 File Offset: 0x00000620
	public void Reposition()
	{
	}

	// Token: 0x040000E8 RID: 232
	public UIGrid.Arrangement arrangement;

	// Token: 0x040000E9 RID: 233
	public int maxPerLine;

	// Token: 0x040000EA RID: 234
	public float cellWidth;

	// Token: 0x040000EB RID: 235
	public float cellHeight;

	// Token: 0x040000EC RID: 236
	public bool repositionNow;

	// Token: 0x040000ED RID: 237
	public bool sorted;

	// Token: 0x040000EE RID: 238
	public bool hideInactive;

	// Token: 0x040000EF RID: 239
	private bool mStarted;

	// Token: 0x02000027 RID: 39
	public enum Arrangement
	{
		// Token: 0x040000F1 RID: 241
		Horizontal,
		// Token: 0x040000F2 RID: 242
		Vertical
	}
}
