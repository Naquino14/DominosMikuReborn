using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BMFont
{
	[HideInInspector]
	[SerializeField]
	private BMGlyph[] mGlyphs;

	[SerializeField]
	[HideInInspector]
	private int mSize;

	[SerializeField]
	[HideInInspector]
	private int mBase;

	[HideInInspector]
	[SerializeField]
	private int mWidth;

	[SerializeField]
	[HideInInspector]
	private int mHeight;

	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved;

	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols;

	private Dictionary<int, BMGlyph> mDict;

	public bool isValid => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public int charSize
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int baseOffset
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int texWidth
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int texHeight
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public int glyphCount => (int)/*Error near IL_0001: Stack underflow*/;

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

	public List<BMSymbol> symbols => (List<BMSymbol>)/*Error near IL_0001: Stack underflow*/;

	public bool LegacyCheck()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private int GetArraySize(int index)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		return (BMGlyph)/*Error near IL_0001: Stack underflow*/;
	}

	public BMGlyph GetGlyph(int index)
	{
		return (BMGlyph)/*Error near IL_0001: Stack underflow*/;
	}

	public BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
		return (BMSymbol)/*Error near IL_0001: Stack underflow*/;
	}

	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
		return (BMSymbol)/*Error near IL_0001: Stack underflow*/;
	}

	public void Clear()
	{
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
