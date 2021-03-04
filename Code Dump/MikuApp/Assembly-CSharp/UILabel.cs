using UnityEngine;

[AddComponentMenu("NGUI/UI/Label")]
[ExecuteInEditMode]
public class UILabel : UIWidget
{
	public enum Effect
	{
		None,
		Shadow,
		Outline
	}

	[HideInInspector]
	[SerializeField]
	private UIFont mFont;

	[SerializeField]
	[HideInInspector]
	private string mText;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	[SerializeField]
	[HideInInspector]
	private bool mEncoding;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineCount;

	[SerializeField]
	[HideInInspector]
	private bool mPassword;

	[HideInInspector]
	[SerializeField]
	private bool mShowLastChar;

	[SerializeField]
	[HideInInspector]
	private Effect mEffectStyle;

	[SerializeField]
	[HideInInspector]
	private Color mEffectColor;

	[SerializeField]
	[HideInInspector]
	private UIFont.SymbolStyle mSymbols;

	[SerializeField]
	[HideInInspector]
	private Vector2 mEffectDistance;

	[SerializeField]
	[HideInInspector]
	private float mLineWidth;

	[SerializeField]
	[HideInInspector]
	private bool mMultiline;

	private bool mShouldBeProcessed;

	private string mProcessedText;

	private Vector3 mLastScale;

	private string mLastText;

	private int mLastWidth;

	private bool mLastEncoding;

	private int mLastCount;

	private bool mLastPass;

	private bool mLastShow;

	private Effect mLastEffect;

	private Vector3 mSize;

	private bool hasChanged
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public UIFont font
	{
		get
		{
			return (UIFont)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string text
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool supportEncoding
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public UIFont.SymbolStyle symbolStyle
	{
		get
		{
			return (UIFont.SymbolStyle)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int lineWidth
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool multiLine
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public int maxLineCount
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool password
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public bool showLastPasswordChar
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public Effect effectStyle
	{
		get
		{
			return (Effect)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Color effectColor
	{
		get
		{
			return (Color)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Vector2 effectDistance
	{
		get
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string processedText => (string)/*Error near IL_0001: Stack underflow*/;

	public override Material material => (Material)/*Error near IL_0001: Stack underflow*/;

	public override Vector2 relativeSize => (Vector2)/*Error near IL_0001: Stack underflow*/;

	protected override void OnStart()
	{
	}

	public override void MarkAsChanged()
	{
	}

	private void ProcessText()
	{
	}

	public void MakePositionPerfect()
	{
	}

	public override void MakePixelPerfect()
	{
	}

	private void ApplyShadow(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, int start, int end, float x, float y)
	{
	}

	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}
}
