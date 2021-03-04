using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Draggable Panel")]
[RequireComponent(typeof(UIPanel))]
[ExecuteInEditMode]
public class UIDraggablePanel : IgnoreTimeScale
{
	public enum DragEffect
	{
		None,
		Momentum,
		MomentumAndSpring
	}

	public enum ShowCondition
	{
		Always,
		OnlyIfNeeded,
		WhenDragging
	}

	public delegate void OnDragFinished();

	public bool restrictWithinPanel;

	public bool disableDragIfFits;

	public DragEffect dragEffect;

	public Vector3 scale;

	public float scrollWheelFactor;

	public float momentumAmount;

	public Vector2 relativePositionOnReset;

	public bool repositionClipping;

	public UIScrollBar horizontalScrollBar;

	public UIScrollBar verticalScrollBar;

	public ShowCondition showScrollBars;

	public OnDragFinished onDragFinished;

	private Transform mTrans;

	private UIPanel mPanel;

	private Plane mPlane;

	private Vector3 mLastPos;

	private bool mPressed;

	private Vector3 mMomentum;

	private float mScroll;

	private Bounds mBounds;

	private bool mCalculatedBounds;

	private bool mShouldMove;

	private bool mIgnoreCallbacks;

	private int mDragID;

	public UIPanel panel => (UIPanel)/*Error near IL_0001: Stack underflow*/;

	public Bounds bounds => (Bounds)/*Error near IL_0001: Stack underflow*/;

	public bool shouldMoveHorizontally => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public bool shouldMoveVertically => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	private bool shouldMove => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public Vector3 currentMomentum
	{
		get
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public bool RestrictWithinBounds(bool instant)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void DisableSpring()
	{
	}

	public void UpdateScrollbars(bool recalculateBounds)
	{
	}

	public void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	public void ResetPosition()
	{
	}

	private void OnHorizontalBar(UIScrollBar sb)
	{
	}

	private void OnVerticalBar(UIScrollBar sb)
	{
	}

	public void MoveRelative(Vector3 relative)
	{
	}

	public void MoveAbsolute(Vector3 absolute)
	{
	}

	public void Press(bool pressed)
	{
	}

	public void Drag(Vector2 delta)
	{
	}

	public void Scroll(float delta)
	{
	}

	private void LateUpdate()
	{
	}
}
