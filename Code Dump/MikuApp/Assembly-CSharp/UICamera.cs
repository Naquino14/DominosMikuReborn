using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Camera")]
public class UICamera : MonoBehaviour
{
	public enum ClickNotification
	{
		None,
		Always,
		BasedOnDelta
	}

	public class MouseOrTouch
	{
		public Vector2 pos;

		public Vector2 delta;

		public Vector2 totalDelta;

		public Camera pressedCam;

		public GameObject current;

		public GameObject pressed;

		public float clickTime;

		public ClickNotification clickNotification;

		public bool touchBegan;

		public bool dragStarted;
	}

	private class Highlighted
	{
		public GameObject go;

		public int counter;
	}

	public bool useMouse;

	public bool useTouch;

	public bool allowMultiTouch;

	public bool useKeyboard;

	public bool useController;

	public LayerMask eventReceiverMask;

	public bool clipRaycasts;

	public float tooltipDelay;

	public bool stickyTooltip;

	public float mouseDragThreshold;

	public float mouseClickThreshold;

	public float touchDragThreshold;

	public float touchClickThreshold;

	public float rangeDistance;

	public string scrollAxisName;

	public string verticalAxisName;

	public string horizontalAxisName;

	public KeyCode submitKey0;

	public KeyCode submitKey1;

	public KeyCode cancelKey0;

	public KeyCode cancelKey1;

	public static bool showTooltips;

	public static Vector2 lastTouchPosition;

	public static RaycastHit lastHit;

	public static UICamera current;

	public static Camera currentCamera;

	public static int currentTouchID;

	public static MouseOrTouch currentTouch;

	public static bool inputHasFocus;

	public static GameObject genericEventHandler;

	public static GameObject fallThrough;

	private static List<UICamera> mList;

	private static List<Highlighted> mHighlighted;

	private static GameObject mSel;

	private static MouseOrTouch[] mMouse;

	private static GameObject mHover;

	private static MouseOrTouch mController;

	private static float mNextEvent;

	private Dictionary<int, MouseOrTouch> mTouches;

	private GameObject mTooltip;

	private Camera mCam;

	private LayerMask mLayerMask;

	private float mTooltipTime;

	private bool mIsEditor;

	private bool handlesEvents => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public Camera cachedCamera => (Camera)/*Error near IL_0001: Stack underflow*/;

	public static GameObject hoveredObject => (GameObject)/*Error near IL_0001: Stack underflow*/;

	public static GameObject selectedObject
	{
		get
		{
			return (GameObject)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public static Camera mainCamera => (Camera)/*Error near IL_0001: Stack underflow*/;

	public static UICamera eventHandler => (UICamera)/*Error near IL_0001: Stack underflow*/;

	private void OnApplicationQuit()
	{
	}

	private static int CompareFunc(UICamera a, UICamera b)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private static bool Raycast(Vector3 inPos, ref RaycastHit hit)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private static bool IsVisible(ref RaycastHit hit)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static UICamera FindCameraForLayer(int layer)
	{
		return (UICamera)/*Error near IL_0001: Stack underflow*/;
	}

	private static int GetDirection(KeyCode up, KeyCode down)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private static int GetDirection(string axis)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static bool IsHighlighted(GameObject go)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private static void Highlight(GameObject go, bool highlighted)
	{
	}

	private static void Notify(GameObject go, string funcName, object obj)
	{
	}

	private MouseOrTouch GetTouch(int id)
	{
		return (MouseOrTouch)/*Error near IL_0001: Stack underflow*/;
	}

	private void RemoveTouch(int id)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void ProcessMouse()
	{
	}

	private void ProcessTouches()
	{
	}

	private void ProcessOthers()
	{
	}

	private void ProcessTouch(bool pressed, bool unpressed)
	{
	}

	public void ShowTooltip(bool val)
	{
	}
}
