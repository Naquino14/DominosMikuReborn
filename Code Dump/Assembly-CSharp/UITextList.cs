using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200007B RID: 123
[AddComponentMenu("NGUI/UI/Text List")]
public class UITextList : MonoBehaviour
{
	// Token: 0x0600038F RID: 911 RVA: 0x00002E84 File Offset: 0x00001084
	public void Clear()
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002E88 File Offset: 0x00001088
	public void Add(string text)
	{
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00002E8C File Offset: 0x0000108C
	protected void Add(string text, bool updateVisible)
	{
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00002E90 File Offset: 0x00001090
	private void Awake()
	{
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00002E94 File Offset: 0x00001094
	private void OnSelect(bool selected)
	{
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00002E98 File Offset: 0x00001098
	protected void UpdateVisibleText()
	{
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00002E9C File Offset: 0x0000109C
	private void OnScroll(float val)
	{
	}

	// Token: 0x0400034D RID: 845
	public UITextList.Style style;

	// Token: 0x0400034E RID: 846
	public UILabel textLabel;

	// Token: 0x0400034F RID: 847
	public float maxWidth;

	// Token: 0x04000350 RID: 848
	public float maxHeight;

	// Token: 0x04000351 RID: 849
	public int maxEntries;

	// Token: 0x04000352 RID: 850
	public bool supportScrollWheel;

	// Token: 0x04000353 RID: 851
	protected char[] mSeparator;

	// Token: 0x04000354 RID: 852
	protected List<UITextList.Paragraph> mParagraphs;

	// Token: 0x04000355 RID: 853
	protected float mScroll;

	// Token: 0x04000356 RID: 854
	protected bool mSelected;

	// Token: 0x04000357 RID: 855
	protected int mTotalLines;

	// Token: 0x0200007C RID: 124
	public enum Style
	{
		// Token: 0x04000359 RID: 857
		Text,
		// Token: 0x0400035A RID: 858
		Chat
	}

	// Token: 0x0200007D RID: 125
	protected class Paragraph
	{
		// Token: 0x0400035B RID: 859
		public string text;

		// Token: 0x0400035C RID: 860
		public string[] lines;
	}
}
