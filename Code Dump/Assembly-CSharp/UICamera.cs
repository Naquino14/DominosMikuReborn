using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000063 RID: 99
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Camera")]
public class UICamera : MonoBehaviour
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002AE4 File Offset: 0x00000CE4
	private bool handlesEvents
	{
		get
		{
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060002A8 RID: 680 RVA: 0x00002AE8 File Offset: 0x00000CE8
	public Camera cachedCamera
	{
		get
		{
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060002A9 RID: 681 RVA: 0x00002AEC File Offset: 0x00000CEC
	public static GameObject hoveredObject
	{
		get
		{
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060002AA RID: 682 RVA: 0x00002AF0 File Offset: 0x00000CF0
	// (set) Token: 0x060002AB RID: 683 RVA: 0x00002AF4 File Offset: 0x00000CF4
	public static GameObject selectedObject
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00002AF8 File Offset: 0x00000CF8
	private void OnApplicationQuit()
	{
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060002AD RID: 685 RVA: 0x00002AFC File Offset: 0x00000CFC
	public static Camera mainCamera
	{
		get
		{
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060002AE RID: 686 RVA: 0x00002B00 File Offset: 0x00000D00
	public static UICamera eventHandler
	{
		get
		{
		}
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00002B04 File Offset: 0x00000D04
	private static int CompareFunc(UICamera a, UICamera b)
	{
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002B08 File Offset: 0x00000D08
	private static bool Raycast(Vector3 inPos, ref RaycastHit hit)
	{
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002B0C File Offset: 0x00000D0C
	private static bool IsVisible(ref RaycastHit hit)
	{
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00002B10 File Offset: 0x00000D10
	public static UICamera FindCameraForLayer(int layer)
	{
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002B14 File Offset: 0x00000D14
	private static int GetDirection(KeyCode up, KeyCode down)
	{
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00002B18 File Offset: 0x00000D18
	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1)
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00002B1C File Offset: 0x00000D1C
	private static int GetDirection(string axis)
	{
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002B20 File Offset: 0x00000D20
	public static bool IsHighlighted(GameObject go)
	{
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002B24 File Offset: 0x00000D24
	private static void Highlight(GameObject go, bool highlighted)
	{
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00002B28 File Offset: 0x00000D28
	private static void Notify(GameObject go, string funcName, object obj)
	{
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00002B2C File Offset: 0x00000D2C
	private UICamera.MouseOrTouch GetTouch(int id)
	{
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00002B30 File Offset: 0x00000D30
	private void RemoveTouch(int id)
	{
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00002B34 File Offset: 0x00000D34
	private void Awake()
	{
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002B38 File Offset: 0x00000D38
	private void OnDestroy()
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002B3C File Offset: 0x00000D3C
	private void FixedUpdate()
	{
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002B40 File Offset: 0x00000D40
	private void Update()
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002B44 File Offset: 0x00000D44
	private void ProcessMouse()
	{
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002B48 File Offset: 0x00000D48
	private void ProcessTouches()
	{
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002B4C File Offset: 0x00000D4C
	private void ProcessOthers()
	{
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002B50 File Offset: 0x00000D50
	private void ProcessTouch(bool pressed, bool unpressed)
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002B54 File Offset: 0x00000D54
	public void ShowTooltip(bool val)
	{
	}

	// Token: 0x0400026B RID: 619
	public bool useMouse;

	// Token: 0x0400026C RID: 620
	public bool useTouch;

	// Token: 0x0400026D RID: 621
	public bool allowMultiTouch;

	// Token: 0x0400026E RID: 622
	public bool useKeyboard;

	// Token: 0x0400026F RID: 623
	public bool useController;

	// Token: 0x04000270 RID: 624
	public LayerMask eventReceiverMask;

	// Token: 0x04000271 RID: 625
	public bool clipRaycasts;

	// Token: 0x04000272 RID: 626
	public float tooltipDelay;

	// Token: 0x04000273 RID: 627
	public bool stickyTooltip;

	// Token: 0x04000274 RID: 628
	public float mouseDragThreshold;

	// Token: 0x04000275 RID: 629
	public float mouseClickThreshold;

	// Token: 0x04000276 RID: 630
	public float touchDragThreshold;

	// Token: 0x04000277 RID: 631
	public float touchClickThreshold;

	// Token: 0x04000278 RID: 632
	public float rangeDistance;

	// Token: 0x04000279 RID: 633
	public string scrollAxisName;

	// Token: 0x0400027A RID: 634
	public string verticalAxisName;

	// Token: 0x0400027B RID: 635
	public string horizontalAxisName;

	// Token: 0x0400027C RID: 636
	public KeyCode submitKey0;

	// Token: 0x0400027D RID: 637
	public KeyCode submitKey1;

	// Token: 0x0400027E RID: 638
	public KeyCode cancelKey0;

	// Token: 0x0400027F RID: 639
	public KeyCode cancelKey1;

	// Token: 0x04000280 RID: 640
	public static bool showTooltips;

	// Token: 0x04000281 RID: 641
	public static Vector2 lastTouchPosition;

	// Token: 0x04000282 RID: 642
	public static RaycastHit lastHit;

	// Token: 0x04000283 RID: 643
	public static UICamera current;

	// Token: 0x04000284 RID: 644
	public static Camera currentCamera;

	// Token: 0x04000285 RID: 645
	public static int currentTouchID;

	// Token: 0x04000286 RID: 646
	public static UICamera.MouseOrTouch currentTouch;

	// Token: 0x04000287 RID: 647
	public static bool inputHasFocus;

	// Token: 0x04000288 RID: 648
	public static GameObject genericEventHandler;

	// Token: 0x04000289 RID: 649
	public static GameObject fallThrough;

	// Token: 0x0400028A RID: 650
	private static List<UICamera> mList;

	// Token: 0x0400028B RID: 651
	private static List<UICamera.Highlighted> mHighlighted;

	// Token: 0x0400028C RID: 652
	private static GameObject mSel;

	// Token: 0x0400028D RID: 653
	private static UICamera.MouseOrTouch[] mMouse;

	// Token: 0x0400028E RID: 654
	private static GameObject mHover;

	// Token: 0x0400028F RID: 655
	private static UICamera.MouseOrTouch mController;

	// Token: 0x04000290 RID: 656
	private static float mNextEvent;

	// Token: 0x04000291 RID: 657
	private Dictionary<int, UICamera.MouseOrTouch> mTouches;

	// Token: 0x04000292 RID: 658
	private GameObject mTooltip;

	// Token: 0x04000293 RID: 659
	private Camera mCam;

	// Token: 0x04000294 RID: 660
	private LayerMask mLayerMask;

	// Token: 0x04000295 RID: 661
	private float mTooltipTime;

	// Token: 0x04000296 RID: 662
	private bool mIsEditor;

	// Token: 0x02000064 RID: 100
	public enum ClickNotification
	{
		// Token: 0x04000299 RID: 665
		None,
		// Token: 0x0400029A RID: 666
		Always,
		// Token: 0x0400029B RID: 667
		BasedOnDelta
	}

	// Token: 0x02000065 RID: 101
	public class MouseOrTouch
	{
		// Token: 0x0400029C RID: 668
		public Vector2 pos;

		// Token: 0x0400029D RID: 669
		public Vector2 delta;

		// Token: 0x0400029E RID: 670
		public Vector2 totalDelta;

		// Token: 0x0400029F RID: 671
		public Camera pressedCam;

		// Token: 0x040002A0 RID: 672
		public GameObject current;

		// Token: 0x040002A1 RID: 673
		public GameObject pressed;

		// Token: 0x040002A2 RID: 674
		public float clickTime;

		// Token: 0x040002A3 RID: 675
		public UICamera.ClickNotification clickNotification;

		// Token: 0x040002A4 RID: 676
		public bool touchBegan;

		// Token: 0x040002A5 RID: 677
		public bool dragStarted;
	}

	// Token: 0x02000066 RID: 102
	private class Highlighted
	{
		// Token: 0x040002A6 RID: 678
		public GameObject go;

		// Token: 0x040002A7 RID: 679
		public int counter;
	}
}
