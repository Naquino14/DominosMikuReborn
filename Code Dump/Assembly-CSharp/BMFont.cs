using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200003C RID: 60
[Serializable]
public class BMFont
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600015A RID: 346 RVA: 0x000025B4 File Offset: 0x000007B4
	public bool isValid
	{
		get
		{
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600015B RID: 347 RVA: 0x000025B8 File Offset: 0x000007B8
	// (set) Token: 0x0600015C RID: 348 RVA: 0x000025BC File Offset: 0x000007BC
	public int charSize
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x0600015D RID: 349 RVA: 0x000025C0 File Offset: 0x000007C0
	// (set) Token: 0x0600015E RID: 350 RVA: 0x000025C4 File Offset: 0x000007C4
	public int baseOffset
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x0600015F RID: 351 RVA: 0x000025C8 File Offset: 0x000007C8
	// (set) Token: 0x06000160 RID: 352 RVA: 0x000025CC File Offset: 0x000007CC
	public int texWidth
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000161 RID: 353 RVA: 0x000025D0 File Offset: 0x000007D0
	// (set) Token: 0x06000162 RID: 354 RVA: 0x000025D4 File Offset: 0x000007D4
	public int texHeight
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000163 RID: 355 RVA: 0x000025D8 File Offset: 0x000007D8
	public int glyphCount
	{
		get
		{
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x06000164 RID: 356 RVA: 0x000025DC File Offset: 0x000007DC
	// (set) Token: 0x06000165 RID: 357 RVA: 0x000025E0 File Offset: 0x000007E0
	public string spriteName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000166 RID: 358 RVA: 0x000025E4 File Offset: 0x000007E4
	public List<BMSymbol> symbols
	{
		get
		{
		}
	}

	// Token: 0x06000167 RID: 359 RVA: 0x000025E8 File Offset: 0x000007E8
	public bool LegacyCheck()
	{
	}

	// Token: 0x06000168 RID: 360 RVA: 0x000025EC File Offset: 0x000007EC
	private int GetArraySize(int index)
	{
	}

	// Token: 0x06000169 RID: 361 RVA: 0x000025F0 File Offset: 0x000007F0
	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
	}

	// Token: 0x0600016A RID: 362 RVA: 0x000025F4 File Offset: 0x000007F4
	public BMGlyph GetGlyph(int index)
	{
	}

	// Token: 0x0600016B RID: 363 RVA: 0x000025F8 File Offset: 0x000007F8
	public BMSymbol GetSymbol(string sequence, bool createIfMissing)
	{
	}

	// Token: 0x0600016C RID: 364 RVA: 0x000025FC File Offset: 0x000007FC
	public BMSymbol MatchSymbol(string text, int offset, int textLength)
	{
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00002600 File Offset: 0x00000800
	public void Clear()
	{
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00002604 File Offset: 0x00000804
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	// Token: 0x0400017D RID: 381
	[HideInInspector]
	[SerializeField]
	private BMGlyph[] mGlyphs;

	// Token: 0x0400017E RID: 382
	[SerializeField]
	[HideInInspector]
	private int mSize;

	// Token: 0x0400017F RID: 383
	[SerializeField]
	[HideInInspector]
	private int mBase;

	// Token: 0x04000180 RID: 384
	[HideInInspector]
	[SerializeField]
	private int mWidth;

	// Token: 0x04000181 RID: 385
	[SerializeField]
	[HideInInspector]
	private int mHeight;

	// Token: 0x04000182 RID: 386
	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	// Token: 0x04000183 RID: 387
	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved;

	// Token: 0x04000184 RID: 388
	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols;

	// Token: 0x04000185 RID: 389
	private Dictionary<int, BMGlyph> mDict;
}
