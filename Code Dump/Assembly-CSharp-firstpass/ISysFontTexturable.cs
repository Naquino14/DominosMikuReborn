using System;
using UnityEngine;

// Token: 0x0200002C RID: 44
public interface ISysFontTexturable
{
	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060002C5 RID: 709
	// (set) Token: 0x060002C6 RID: 710
	string Text { get; set; }

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060002C7 RID: 711
	// (set) Token: 0x060002C8 RID: 712
	string AppleFontName { get; set; }

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060002C9 RID: 713
	// (set) Token: 0x060002CA RID: 714
	string AndroidFontName { get; set; }

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060002CB RID: 715
	// (set) Token: 0x060002CC RID: 716
	string FontName { get; set; }

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060002CD RID: 717
	// (set) Token: 0x060002CE RID: 718
	int FontSize { get; set; }

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060002CF RID: 719
	// (set) Token: 0x060002D0 RID: 720
	bool IsBold { get; set; }

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060002D1 RID: 721
	// (set) Token: 0x060002D2 RID: 722
	bool IsItalic { get; set; }

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060002D3 RID: 723
	// (set) Token: 0x060002D4 RID: 724
	SysFont.Alignment Alignment { get; set; }

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060002D5 RID: 725
	// (set) Token: 0x060002D6 RID: 726
	bool IsMultiLine { get; set; }

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060002D7 RID: 727
	// (set) Token: 0x060002D8 RID: 728
	int MaxWidthPixels { get; set; }

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060002D9 RID: 729
	// (set) Token: 0x060002DA RID: 730
	int MaxHeightPixels { get; set; }

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060002DB RID: 731
	int WidthPixels { get; }

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060002DC RID: 732
	int HeightPixels { get; }

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060002DD RID: 733
	int TextWidthPixels { get; }

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060002DE RID: 734
	int TextHeightPixels { get; }

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060002DF RID: 735
	Texture Texture { get; }
}
