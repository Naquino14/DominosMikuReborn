using System;
using UnityEngine;

[Serializable]
public class SysFontTexture : ISysFontTexturable
{
	[SerializeField]
	protected string _text;

	[SerializeField]
	protected string _appleFontName;

	[SerializeField]
	protected string _androidFontName;

	[SerializeField]
	protected int _fontSize;

	[SerializeField]
	protected bool _isBold;

	[SerializeField]
	protected bool _isItalic;

	[SerializeField]
	protected SysFont.Alignment _alignment;

	[SerializeField]
	protected bool _isMultiLine;

	[SerializeField]
	protected int _maxWidthPixels;

	[SerializeField]
	protected int _maxHeightPixels;

	protected string _lastText;

	protected string _lastFontName;

	protected int _lastFontSize;

	protected bool _lastIsBold;

	protected bool _lastIsItalic;

	protected SysFont.Alignment _lastAlignment;

	protected bool _lastIsMultiLine;

	protected int _lastMaxWidthPixels;

	protected int _lastMaxHeightPixels;

	protected int _widthPixels;

	protected int _heightPixels;

	protected int _textWidthPixels;

	protected int _textHeightPixels;

	protected Texture _texture;

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

	public bool NeedsRedraw => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public void Update()
	{
	}

	public void Destroy()
	{
	}
}
