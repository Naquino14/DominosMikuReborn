using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/SysFont Label")]
public class UISysFontLabel : UIWidget, ISysFontTexturable
{
	[SerializeField]
	public bool hack;

	[SerializeField]
	protected SysFontTexture _texture;

	protected static Shader _shader;

	protected Material _createdMaterial;

	protected Vector3[] _vertices;

	protected Vector2 _uv;

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

	public override bool keepMaterial => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	private void Start()
	{
	}

	public override bool OnUpdate()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override void MakePixelPerfect()
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDestroy()
	{
	}
}
