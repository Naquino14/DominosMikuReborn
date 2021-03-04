using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000035 RID: 53
[AddComponentMenu("NGUI/Interaction/Table")]
[ExecuteInEditMode]
public class UITable : MonoBehaviour
{
	// Token: 0x0600014C RID: 332 RVA: 0x0000257C File Offset: 0x0000077C
	public static int SortByName(Transform a, Transform b)
	{
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600014D RID: 333 RVA: 0x00002580 File Offset: 0x00000780
	public List<Transform> children
	{
		get
		{
		}
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00002584 File Offset: 0x00000784
	private void RepositionVariableSize(List<Transform> children)
	{
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00002588 File Offset: 0x00000788
	public void Reposition()
	{
	}

	// Token: 0x06000150 RID: 336 RVA: 0x0000258C File Offset: 0x0000078C
	private void Start()
	{
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00002590 File Offset: 0x00000790
	private void LateUpdate()
	{
	}

	// Token: 0x0400014D RID: 333
	public int columns;

	// Token: 0x0400014E RID: 334
	public UITable.Direction direction;

	// Token: 0x0400014F RID: 335
	public Vector2 padding;

	// Token: 0x04000150 RID: 336
	public bool sorted;

	// Token: 0x04000151 RID: 337
	public bool hideInactive;

	// Token: 0x04000152 RID: 338
	public bool repositionNow;

	// Token: 0x04000153 RID: 339
	public bool keepWithinPanel;

	// Token: 0x04000154 RID: 340
	public UITable.OnReposition onReposition;

	// Token: 0x04000155 RID: 341
	private UIPanel mPanel;

	// Token: 0x04000156 RID: 342
	private UIDraggablePanel mDrag;

	// Token: 0x04000157 RID: 343
	private bool mStarted;

	// Token: 0x04000158 RID: 344
	private List<Transform> mChildren;

	// Token: 0x02000036 RID: 54
	public enum Direction
	{
		// Token: 0x0400015A RID: 346
		Down,
		// Token: 0x0400015B RID: 347
		Up
	}

	// Token: 0x02000153 RID: 339
	// (Invoke) Token: 0x06000B41 RID: 2881
	public delegate void OnReposition();
}
