using System;
using System.Collections.Generic;

// Token: 0x0200003D RID: 61
[Serializable]
public class BMGlyph
{
	// Token: 0x06000170 RID: 368 RVA: 0x0000260C File Offset: 0x0000080C
	public int GetKerning(int previousChar)
	{
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00002610 File Offset: 0x00000810
	public void SetKerning(int previousChar, int amount)
	{
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00002614 File Offset: 0x00000814
	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}

	// Token: 0x04000186 RID: 390
	public int index;

	// Token: 0x04000187 RID: 391
	public int x;

	// Token: 0x04000188 RID: 392
	public int y;

	// Token: 0x04000189 RID: 393
	public int width;

	// Token: 0x0400018A RID: 394
	public int height;

	// Token: 0x0400018B RID: 395
	public int offsetX;

	// Token: 0x0400018C RID: 396
	public int offsetY;

	// Token: 0x0400018D RID: 397
	public int advance;

	// Token: 0x0400018E RID: 398
	public int channel;

	// Token: 0x0400018F RID: 399
	public List<BMGlyph.Kerning> kerning;

	// Token: 0x0200003E RID: 62
	public struct Kerning
	{
		// Token: 0x04000190 RID: 400
		public int previousChar;

		// Token: 0x04000191 RID: 401
		public int amount;
	}
}
