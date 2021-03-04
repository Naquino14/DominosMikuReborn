using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Panel")]
public class UIPanel : MonoBehaviour
{
	public enum DebugInfo
	{
		None,
		Gizmos,
		Geometry
	}

	public bool showInPanelTool;

	public bool generateNormals;

	public bool depthPass;

	public bool widgetsAreStatic;

	[SerializeField]
	[HideInInspector]
	private DebugInfo mDebugInfo;

	[SerializeField]
	[HideInInspector]
	private UIDrawCall.Clipping mClipping;

	[SerializeField]
	[HideInInspector]
	private Vector4 mClipRange;

	[SerializeField]
	[HideInInspector]
	private Vector2 mClipSoftness;

	private OrderedDictionary mChildren;

	private BetterList<UIWidget> mWidgets;

	private BetterList<Material> mChanged;

	private BetterList<UIDrawCall> mDrawCalls;

	private BetterList<Vector3> mVerts;

	private BetterList<Vector3> mNorms;

	private BetterList<Vector4> mTans;

	private BetterList<Vector2> mUvs;

	private BetterList<Color32> mCols;

	private Transform mTrans;

	private Camera mCam;

	private int mLayer;

	private bool mDepthChanged;

	private bool mRebuildAll;

	private bool mChangedLastFrame;

	private bool mWidgetsAdded;

	private float mMatrixTime;

	private Matrix4x4 mWorldToLocal;

	private static float[] mTemp;

	private Vector2 mMin;

	private Vector2 mMax;

	private List<Transform> mRemoved;

	private bool mCheckVisibility;

	private float mCullTime;

	private bool mCulled;

	private static BetterList<UINode> mHierarchy;

	public Transform cachedTransform => (Transform)/*Error near IL_0001: Stack underflow*/;

	public bool changedLastFrame => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public DebugInfo debugInfo
	{
		get
		{
			return (DebugInfo)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public UIDrawCall.Clipping clipping
	{
		get
		{
			return (UIDrawCall.Clipping)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Vector4 clipRange
	{
		get
		{
			return (Vector4)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Vector2 clipSoftness
	{
		get
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public BetterList<UIWidget> widgets => (BetterList<UIWidget>)/*Error near IL_0001: Stack underflow*/;

	public BetterList<UIDrawCall> drawCalls => (BetterList<UIDrawCall>)/*Error near IL_0001: Stack underflow*/;

	private UINode GetNode(Transform t)
	{
		return (UINode)/*Error near IL_0001: Stack underflow*/;
	}

	private bool IsVisible(Vector3 a, Vector3 b, Vector3 c, Vector3 d)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool IsVisible(Vector3 worldPos)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool IsVisible(UIWidget w)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void MarkMaterialAsChanged(Material mat, bool sort)
	{
	}

	public bool WatchesTransform(Transform t)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private UINode AddTransform(Transform t)
	{
		return (UINode)/*Error near IL_0001: Stack underflow*/;
	}

	private void RemoveTransform(Transform t)
	{
	}

	public void AddWidget(UIWidget w)
	{
	}

	public void RemoveWidget(UIWidget w)
	{
	}

	private UIDrawCall GetDrawCall(Material mat, bool createIfMissing)
	{
		return (UIDrawCall)/*Error near IL_0001: Stack underflow*/;
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private int GetChangeFlag(UINode start)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private void UpdateTransformMatrix()
	{
	}

	private void UpdateTransforms()
	{
	}

	private void UpdateWidgets()
	{
	}

	public void UpdateDrawcalls()
	{
	}

	private void Fill(Material mat)
	{
	}

	private void LateUpdate()
	{
	}

	public void Refresh()
	{
	}

	public Vector3 CalculateConstrainOffset(Vector2 min, Vector2 max)
	{
		return (Vector3)/*Error near IL_0001: Stack underflow*/;
	}

	public bool ConstrainTargetToBounds(Transform target, ref Bounds targetBounds, bool immediate)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool ConstrainTargetToBounds(Transform target, bool immediate)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private static void SetChildLayer(Transform t, int layer)
	{
	}

	public static UIPanel Find(Transform trans, bool createIfMissing)
	{
		return (UIPanel)/*Error near IL_0001: Stack underflow*/;
	}

	public static UIPanel Find(Transform trans)
	{
		return (UIPanel)/*Error near IL_0001: Stack underflow*/;
	}
}
