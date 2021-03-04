using System.Collections.Generic;
using System.Text;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Font")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour
{
	public enum Alignment
	{
		Left,
		Center,
		Right
	}

	public enum SymbolStyle
	{
		None,
		Uncolored,
		Colored
	}

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Rect mUVRect;

	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	[SerializeField]
	[HideInInspector]
	private int mSpacingY;

	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private UIFont mReplacement;

	private UIAtlas.Sprite mSprite;

	private bool mSpriteSet;

	private List<Color> mColors;

	public BMFont bmFont => (BMFont)/*Error near IL_0001: Stack underflow*/;

	public int texWidth => (int)/*Error near IL_0001: Stack underflow*/;

	public int texHeight => (int)/*Error near IL_0001: Stack underflow*/;

	public UIAtlas atlas
	{
		get
		{
			return (UIAtlas)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Material material
	{
		get
		{
			return (Material)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Texture2D texture => (Texture2D)/*Error near IL_0001: Stack underflow*/;

	public Rect uvRect
	{
		get
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string spriteName
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int horizontalSpacing
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int verticalSpacing
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int size => (int)/*Error near IL_0001: Stack underflow*/;

	public UIAtlas.Sprite sprite => (UIAtlas.Sprite)/*Error near IL_0001: Stack underflow*/;

	public UIFont replacement
	{
		get
		{
			return (UIFont)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	private void Trim()
	{
	}

	private bool References(UIFont font)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void MarkAsDirty()
	{
	}

	public Vector2 CalculatePrintedSize(string text, bool encoding, SymbolStyle symbolStyle)
	{
		return (Vector2)/*Error near IL_0001: Stack underflow*/;
	}

	private static void EndLine(ref StringBuilder s)
	{
	}

	public string GetEndOfLineThatFits(string text, float maxWidth, bool encoding, SymbolStyle symbolStyle)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding, SymbolStyle symbolStyle)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public string WrapText(string text, float maxWidth, int maxLineCount)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	private void Align(BetterList<Vector3> verts, int indexOffset, Alignment alignment, int x, int lineWidth)
	{
	}

	public void Print(string text, Color32 color, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, bool encoding, SymbolStyle symbolStyle, Alignment alignment, int lineWidth)
	{
	}
}
