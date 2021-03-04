using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x02000069 RID: 105
[AddComponentMenu("NGUI/UI/Font")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour
{
	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060002D2 RID: 722 RVA: 0x00002B90 File Offset: 0x00000D90
	public BMFont bmFont
	{
		get
		{
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060002D3 RID: 723 RVA: 0x00002B94 File Offset: 0x00000D94
	public int texWidth
	{
		get
		{
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060002D4 RID: 724 RVA: 0x00002B98 File Offset: 0x00000D98
	public int texHeight
	{
		get
		{
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002B9C File Offset: 0x00000D9C
	// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002BA0 File Offset: 0x00000DA0
	public UIAtlas atlas
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x00002BA4 File Offset: 0x00000DA4
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002BA8 File Offset: 0x00000DA8
	public Material material
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x00002BAC File Offset: 0x00000DAC
	public Texture2D texture
	{
		get
		{
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060002DA RID: 730 RVA: 0x00002BB0 File Offset: 0x00000DB0
	// (set) Token: 0x060002DB RID: 731 RVA: 0x00002BB4 File Offset: 0x00000DB4
	public Rect uvRect
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060002DC RID: 732 RVA: 0x00002BB8 File Offset: 0x00000DB8
	// (set) Token: 0x060002DD RID: 733 RVA: 0x00002BBC File Offset: 0x00000DBC
	public string spriteName
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060002DE RID: 734 RVA: 0x00002BC0 File Offset: 0x00000DC0
	// (set) Token: 0x060002DF RID: 735 RVA: 0x00002BC4 File Offset: 0x00000DC4
	public int horizontalSpacing
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060002E0 RID: 736 RVA: 0x00002BC8 File Offset: 0x00000DC8
	// (set) Token: 0x060002E1 RID: 737 RVA: 0x00002BCC File Offset: 0x00000DCC
	public int verticalSpacing
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060002E2 RID: 738 RVA: 0x00002BD0 File Offset: 0x00000DD0
	public int size
	{
		get
		{
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060002E3 RID: 739 RVA: 0x00002BD4 File Offset: 0x00000DD4
	public UIAtlas.Sprite sprite
	{
		get
		{
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060002E4 RID: 740 RVA: 0x00002BD8 File Offset: 0x00000DD8
	// (set) Token: 0x060002E5 RID: 741 RVA: 0x00002BDC File Offset: 0x00000DDC
	public UIFont replacement
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060002E6 RID: 742 RVA: 0x00002BE0 File Offset: 0x00000DE0
	private void Trim()
	{
	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00002BE4 File Offset: 0x00000DE4
	private bool References(UIFont font)
	{
	}

	// Token: 0x060002E8 RID: 744 RVA: 0x00002BE8 File Offset: 0x00000DE8
	public static bool CheckIfRelated(UIFont a, UIFont b)
	{
	}

	// Token: 0x060002E9 RID: 745 RVA: 0x00002BEC File Offset: 0x00000DEC
	public void MarkAsDirty()
	{
	}

	// Token: 0x060002EA RID: 746 RVA: 0x00002BF0 File Offset: 0x00000DF0
	public Vector2 CalculatePrintedSize(string text, bool encoding, UIFont.SymbolStyle symbolStyle)
	{
	}

	// Token: 0x060002EB RID: 747 RVA: 0x00002BF4 File Offset: 0x00000DF4
	private static void EndLine(ref StringBuilder s)
	{
	}

	// Token: 0x060002EC RID: 748 RVA: 0x00002BF8 File Offset: 0x00000DF8
	public string GetEndOfLineThatFits(string text, float maxWidth, bool encoding, UIFont.SymbolStyle symbolStyle)
	{
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00002BFC File Offset: 0x00000DFC
	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding, UIFont.SymbolStyle symbolStyle)
	{
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00002C00 File Offset: 0x00000E00
	public string WrapText(string text, float maxWidth, int maxLineCount, bool encoding)
	{
	}

	// Token: 0x060002EF RID: 751 RVA: 0x00002C04 File Offset: 0x00000E04
	public string WrapText(string text, float maxWidth, int maxLineCount)
	{
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x00002C08 File Offset: 0x00000E08
	private void Align(BetterList<Vector3> verts, int indexOffset, UIFont.Alignment alignment, int x, int lineWidth)
	{
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x00002C0C File Offset: 0x00000E0C
	public void Print(string text, Color32 color, BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, bool encoding, UIFont.SymbolStyle symbolStyle, UIFont.Alignment alignment, int lineWidth)
	{
	}

	// Token: 0x040002B1 RID: 689
	[SerializeField]
	[HideInInspector]
	private Material mMat;

	// Token: 0x040002B2 RID: 690
	[SerializeField]
	[HideInInspector]
	private Rect mUVRect;

	// Token: 0x040002B3 RID: 691
	[SerializeField]
	[HideInInspector]
	private BMFont mFont;

	// Token: 0x040002B4 RID: 692
	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	// Token: 0x040002B5 RID: 693
	[SerializeField]
	[HideInInspector]
	private int mSpacingY;

	// Token: 0x040002B6 RID: 694
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	// Token: 0x040002B7 RID: 695
	[HideInInspector]
	[SerializeField]
	private UIFont mReplacement;

	// Token: 0x040002B8 RID: 696
	private UIAtlas.Sprite mSprite;

	// Token: 0x040002B9 RID: 697
	private bool mSpriteSet;

	// Token: 0x040002BA RID: 698
	private List<Color> mColors;

	// Token: 0x0200006A RID: 106
	public enum Alignment
	{
		// Token: 0x040002BC RID: 700
		Left,
		// Token: 0x040002BD RID: 701
		Center,
		// Token: 0x040002BE RID: 702
		Right
	}

	// Token: 0x0200006B RID: 107
	public enum SymbolStyle
	{
		// Token: 0x040002C0 RID: 704
		None,
		// Token: 0x040002C1 RID: 705
		Uncolored,
		// Token: 0x040002C2 RID: 706
		Colored
	}
}
