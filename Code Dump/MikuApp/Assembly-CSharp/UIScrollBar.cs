using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Scroll Bar")]
public class UIScrollBar : MonoBehaviour
{
	public enum Direction
	{
		Horizontal,
		Vertical
	}

	public delegate void OnScrollBarChange(UIScrollBar sb);

	[SerializeField]
	[HideInInspector]
	private UISprite mBG;

	[HideInInspector]
	[SerializeField]
	private UISprite mFG;

	[HideInInspector]
	[SerializeField]
	private Direction mDir;

	[SerializeField]
	[HideInInspector]
	private bool mInverted;

	[SerializeField]
	[HideInInspector]
	private float mScroll;

	[SerializeField]
	[HideInInspector]
	private float mSize;

	private Transform mTrans;

	private bool mIsDirty;

	private Camera mCam;

	private Vector2 mScreenPos;

	public OnScrollBarChange onChange;

	public Transform cachedTransform => (Transform)/*Error near IL_0001: Stack underflow*/;

	public Camera cachedCamera => (Camera)/*Error near IL_0001: Stack underflow*/;

	public UISprite background
	{
		get
		{
			return (UISprite)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public UISprite foreground
	{
		get
		{
			return (UISprite)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Direction direction
	{
		get
		{
			return (Direction)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool inverted
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public float scrollValue
	{
		get
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public float barSize
	{
		get
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public float alpha
	{
		get
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	private void CenterOnPos(Vector2 localPos)
	{
	}

	private void Reposition(Vector2 screenPos)
	{
	}

	private void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	private void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	private void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	private void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ForceUpdate()
	{
	}
}
