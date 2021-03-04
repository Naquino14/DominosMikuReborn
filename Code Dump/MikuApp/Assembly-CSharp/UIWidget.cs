using UnityEngine;

public abstract class UIWidget : MonoBehaviour
{
	public enum Pivot
	{
		TopLeft,
		Top,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight
	}

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Texture mTex;

	[SerializeField]
	[HideInInspector]
	private Color mColor;

	[HideInInspector]
	[SerializeField]
	private Pivot mPivot;

	[HideInInspector]
	[SerializeField]
	private int mDepth;

	private Transform mTrans;

	private UIPanel mPanel;

	protected bool mChanged;

	protected bool mPlayMode;

	private Vector3 mDiffPos;

	private Quaternion mDiffRot;

	private Vector3 mDiffScale;

	private int mVisibleFlag;

	private UIGeometry mGeom;

	public Color color
	{
		get
		{
			return (Color)/*Error near IL_0001: Stack underflow*/;
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

	public Pivot pivot
	{
		get
		{
			return (Pivot)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int depth
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Transform cachedTransform => (Transform)/*Error near IL_0001: Stack underflow*/;

	public virtual Material material
	{
		get
		{
			return (Material)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public virtual Texture mainTexture
	{
		get
		{
			return (Texture)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public UIPanel panel
	{
		get
		{
			return (UIPanel)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int visibleFlag
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public virtual Vector2 pivotOffset => (Vector2)/*Error near IL_0001: Stack underflow*/;

	public virtual Vector2 relativeSize => (Vector2)/*Error near IL_0001: Stack underflow*/;

	public virtual bool keepMaterial => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public static int CompareFunc(UIWidget left, UIWidget right)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public virtual void MarkAsChanged()
	{
	}

	private void CreatePanel()
	{
	}

	public void CheckLayer()
	{
	}

	public void CheckParent()
	{
	}

	protected virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	public void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public bool UpdateGeometry(ref Matrix4x4 worldToPanel, bool parentMoved, bool generateNormals)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	public virtual void MakePixelPerfect()
	{
	}

	protected virtual void OnStart()
	{
	}

	public virtual bool OnUpdate()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
