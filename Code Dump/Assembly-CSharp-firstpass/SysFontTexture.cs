using System;
using UnityEngine;

// Token: 0x02000031 RID: 49
[Serializable]
public class SysFontTexture : ISysFontTexturable
{
	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000319 RID: 793 RVA: 0x00002AC0 File Offset: 0x00000CC0
	// (set) Token: 0x0600031A RID: 794 RVA: 0x00002AC4 File Offset: 0x00000CC4
	public string Text
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x0600031B RID: 795 RVA: 0x00002AC8 File Offset: 0x00000CC8
	// (set) Token: 0x0600031C RID: 796 RVA: 0x00002ACC File Offset: 0x00000CCC
	public string AppleFontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x0600031D RID: 797 RVA: 0x00002AD0 File Offset: 0x00000CD0
	// (set) Token: 0x0600031E RID: 798 RVA: 0x00002AD4 File Offset: 0x00000CD4
	public string AndroidFontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x0600031F RID: 799 RVA: 0x00002AD8 File Offset: 0x00000CD8
	// (set) Token: 0x06000320 RID: 800 RVA: 0x00002ADC File Offset: 0x00000CDC
	public string FontName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000321 RID: 801 RVA: 0x00002AE0 File Offset: 0x00000CE0
	// (set) Token: 0x06000322 RID: 802 RVA: 0x00002AE4 File Offset: 0x00000CE4
	public int FontSize
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000323 RID: 803 RVA: 0x00002AE8 File Offset: 0x00000CE8
	// (set) Token: 0x06000324 RID: 804 RVA: 0x00002AEC File Offset: 0x00000CEC
	public bool IsBold
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000325 RID: 805 RVA: 0x00002AF0 File Offset: 0x00000CF0
	// (set) Token: 0x06000326 RID: 806 RVA: 0x00002AF4 File Offset: 0x00000CF4
	public bool IsItalic
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000327 RID: 807 RVA: 0x00002AF8 File Offset: 0x00000CF8
	// (set) Token: 0x06000328 RID: 808 RVA: 0x00002AFC File Offset: 0x00000CFC
	public SysFont.Alignment Alignment
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x06000329 RID: 809 RVA: 0x00002B00 File Offset: 0x00000D00
	// (set) Token: 0x0600032A RID: 810 RVA: 0x00002B04 File Offset: 0x00000D04
	public bool IsMultiLine
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x0600032B RID: 811 RVA: 0x00002B08 File Offset: 0x00000D08
	// (set) Token: 0x0600032C RID: 812 RVA: 0x00002B0C File Offset: 0x00000D0C
	public int MaxWidthPixels
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600032D RID: 813 RVA: 0x00002B10 File Offset: 0x00000D10
	// (set) Token: 0x0600032E RID: 814 RVA: 0x00002B14 File Offset: 0x00000D14
	public int MaxHeightPixels
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x0600032F RID: 815 RVA: 0x00002B18 File Offset: 0x00000D18
	public int WidthPixels
	{
		get
		{
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000330 RID: 816 RVA: 0x00002B1C File Offset: 0x00000D1C
	public int HeightPixels
	{
		get
		{
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000331 RID: 817 RVA: 0x00002B20 File Offset: 0x00000D20
	public int TextWidthPixels
	{
		get
		{
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x06000332 RID: 818 RVA: 0x00002B24 File Offset: 0x00000D24
	public int TextHeightPixels
	{
		get
		{
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000333 RID: 819 RVA: 0x00002B28 File Offset: 0x00000D28
	public Texture Texture
	{
		get
		{
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000334 RID: 820 RVA: 0x00002B2C File Offset: 0x00000D2C
	public bool NeedsRedraw
	{
		get
		{
		}
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00002B30 File Offset: 0x00000D30
	public void Update()
	{
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00002B34 File Offset: 0x00000D34
	public void Destroy()
	{
	}

	// Token: 0x04000118 RID: 280
	[SerializeField]
	protected string _text;

	// Token: 0x04000119 RID: 281
	[SerializeField]
	protected string _appleFontName;

	// Token: 0x0400011A RID: 282
	[SerializeField]
	protected string _androidFontName;

	// Token: 0x0400011B RID: 283
	[SerializeField]
	protected int _fontSize;

	// Token: 0x0400011C RID: 284
	[SerializeField]
	protected bool _isBold;

	// Token: 0x0400011D RID: 285
	[SerializeField]
	protected bool _isItalic;

	// Token: 0x0400011E RID: 286
	[SerializeField]
	protected SysFont.Alignment _alignment;

	// Token: 0x0400011F RID: 287
	[SerializeField]
	protected bool _isMultiLine;

	// Token: 0x04000120 RID: 288
	[SerializeField]
	protected int _maxWidthPixels;

	// Token: 0x04000121 RID: 289
	[SerializeField]
	protected int _maxHeightPixels;

	// Token: 0x04000122 RID: 290
	protected string _lastText;

	// Token: 0x04000123 RID: 291
	protected string _lastFontName;

	// Token: 0x04000124 RID: 292
	protected int _lastFontSize;

	// Token: 0x04000125 RID: 293
	protected bool _lastIsBold;

	// Token: 0x04000126 RID: 294
	protected bool _lastIsItalic;

	// Token: 0x04000127 RID: 295
	protected SysFont.Alignment _lastAlignment;

	// Token: 0x04000128 RID: 296
	protected bool _lastIsMultiLine;

	// Token: 0x04000129 RID: 297
	protected int _lastMaxWidthPixels;

	// Token: 0x0400012A RID: 298
	protected int _lastMaxHeightPixels;

	// Token: 0x0400012B RID: 299
	protected int _widthPixels;

	// Token: 0x0400012C RID: 300
	protected int _heightPixels;

	// Token: 0x0400012D RID: 301
	protected int _textWidthPixels;

	// Token: 0x0400012E RID: 302
	protected int _textHeightPixels;

	// Token: 0x0400012F RID: 303
	protected Texture _texture;
}
