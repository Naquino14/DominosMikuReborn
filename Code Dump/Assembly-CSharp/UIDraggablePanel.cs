using System;
using UnityEngine;

// Token: 0x02000022 RID: 34
[AddComponentMenu("NGUI/Interaction/Draggable Panel")]
[RequireComponent(typeof(UIPanel))]
[ExecuteInEditMode]
public class UIDraggablePanel : IgnoreTimeScale
{
	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000238C File Offset: 0x0000058C
	public UIPanel panel
	{
		get
		{
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x00002390 File Offset: 0x00000590
	public Bounds bounds
	{
		get
		{
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002394 File Offset: 0x00000594
	public bool shouldMoveHorizontally
	{
		get
		{
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x00002398 File Offset: 0x00000598
	public bool shouldMoveVertically
	{
		get
		{
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000239C File Offset: 0x0000059C
	private bool shouldMove
	{
		get
		{
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x000023A0 File Offset: 0x000005A0
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x000023A4 File Offset: 0x000005A4
	public Vector3 currentMomentum
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x000023A8 File Offset: 0x000005A8
	private void Awake()
	{
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x000023AC File Offset: 0x000005AC
	private void Start()
	{
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x000023B0 File Offset: 0x000005B0
	public bool RestrictWithinBounds(bool instant)
	{
	}

	// Token: 0x060000DA RID: 218 RVA: 0x000023B4 File Offset: 0x000005B4
	public void DisableSpring()
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x000023B8 File Offset: 0x000005B8
	public void UpdateScrollbars(bool recalculateBounds)
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x000023BC File Offset: 0x000005BC
	public void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	// Token: 0x060000DD RID: 221 RVA: 0x000023C0 File Offset: 0x000005C0
	public void ResetPosition()
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x000023C4 File Offset: 0x000005C4
	private void OnHorizontalBar(UIScrollBar sb)
	{
	}

	// Token: 0x060000DF RID: 223 RVA: 0x000023C8 File Offset: 0x000005C8
	private void OnVerticalBar(UIScrollBar sb)
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000023CC File Offset: 0x000005CC
	public void MoveRelative(Vector3 relative)
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000023D0 File Offset: 0x000005D0
	public void MoveAbsolute(Vector3 absolute)
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x000023D4 File Offset: 0x000005D4
	public void Press(bool pressed)
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000023D8 File Offset: 0x000005D8
	public void Drag(Vector2 delta)
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x000023DC File Offset: 0x000005DC
	public void Scroll(float delta)
	{
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x000023E0 File Offset: 0x000005E0
	private void LateUpdate()
	{
	}

	// Token: 0x040000BD RID: 189
	public bool restrictWithinPanel;

	// Token: 0x040000BE RID: 190
	public bool disableDragIfFits;

	// Token: 0x040000BF RID: 191
	public UIDraggablePanel.DragEffect dragEffect;

	// Token: 0x040000C0 RID: 192
	public Vector3 scale;

	// Token: 0x040000C1 RID: 193
	public float scrollWheelFactor;

	// Token: 0x040000C2 RID: 194
	public float momentumAmount;

	// Token: 0x040000C3 RID: 195
	public Vector2 relativePositionOnReset;

	// Token: 0x040000C4 RID: 196
	public bool repositionClipping;

	// Token: 0x040000C5 RID: 197
	public UIScrollBar horizontalScrollBar;

	// Token: 0x040000C6 RID: 198
	public UIScrollBar verticalScrollBar;

	// Token: 0x040000C7 RID: 199
	public UIDraggablePanel.ShowCondition showScrollBars;

	// Token: 0x040000C8 RID: 200
	public UIDraggablePanel.OnDragFinished onDragFinished;

	// Token: 0x040000C9 RID: 201
	private Transform mTrans;

	// Token: 0x040000CA RID: 202
	private UIPanel mPanel;

	// Token: 0x040000CB RID: 203
	private Plane mPlane;

	// Token: 0x040000CC RID: 204
	private Vector3 mLastPos;

	// Token: 0x040000CD RID: 205
	private bool mPressed;

	// Token: 0x040000CE RID: 206
	private Vector3 mMomentum;

	// Token: 0x040000CF RID: 207
	private float mScroll;

	// Token: 0x040000D0 RID: 208
	private Bounds mBounds;

	// Token: 0x040000D1 RID: 209
	private bool mCalculatedBounds;

	// Token: 0x040000D2 RID: 210
	private bool mShouldMove;

	// Token: 0x040000D3 RID: 211
	private bool mIgnoreCallbacks;

	// Token: 0x040000D4 RID: 212
	private int mDragID;

	// Token: 0x02000023 RID: 35
	public enum DragEffect
	{
		// Token: 0x040000D6 RID: 214
		None,
		// Token: 0x040000D7 RID: 215
		Momentum,
		// Token: 0x040000D8 RID: 216
		MomentumAndSpring
	}

	// Token: 0x02000024 RID: 36
	public enum ShowCondition
	{
		// Token: 0x040000DA RID: 218
		Always,
		// Token: 0x040000DB RID: 219
		OnlyIfNeeded,
		// Token: 0x040000DC RID: 220
		WhenDragging
	}

	// Token: 0x0200014F RID: 335
	// (Invoke) Token: 0x06000B31 RID: 2865
	public delegate void OnDragFinished();
}
