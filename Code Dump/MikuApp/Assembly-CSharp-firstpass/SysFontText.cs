using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("SysFont/Text")]
public class SysFontText : MonoBehaviour, ISysFontTexturable
{
	public enum PivotAlignment
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
	protected SysFontTexture _texture;

	[SerializeField]
	protected Color _fontColor;

	[SerializeField]
	protected PivotAlignment _pivot;

	protected Color _lastFontColor;

	protected PivotAlignment _lastPivot;

	protected Transform _transform;

	protected Material _createdMaterial;

	protected Material _material;

	protected Vector3[] _vertices;

	protected Vector2[] _uv;

	protected int[] _triangles;

	protected Mesh _mesh;

	protected MeshFilter _filter;

	protected MeshRenderer _renderer;

	protected static Shader _shader;

	public string Text
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string AppleFontName
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string AndroidFontName
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string FontName
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int FontSize
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool IsBold
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public bool IsItalic
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public SysFont.Alignment Alignment
	{
		get
		{
			return (SysFont.Alignment)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool IsMultiLine
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public int MaxWidthPixels
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int MaxHeightPixels
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int WidthPixels => (int)/*Error near IL_0001: Stack underflow*/;

	public int HeightPixels => (int)/*Error near IL_0001: Stack underflow*/;

	public int TextWidthPixels => (int)/*Error near IL_0001: Stack underflow*/;

	public int TextHeightPixels => (int)/*Error near IL_0001: Stack underflow*/;

	public Texture Texture => (Texture)/*Error near IL_0001: Stack underflow*/;

	public Color FontColor
	{
		get
		{
			return (Color)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public PivotAlignment Pivot
	{
		get
		{
			return (PivotAlignment)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	protected void UpdateMesh()
	{
	}

	protected void UpdatePivot()
	{
	}

	public void UpdateScale()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Update()
	{
	}

	protected void OnDestroy()
	{
	}
}
