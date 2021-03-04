using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Text List")]
public class UITextList : MonoBehaviour
{
	public enum Style
	{
		Text,
		Chat
	}

	protected class Paragraph
	{
		public string text;

		public string[] lines;
	}

	public Style style;

	public UILabel textLabel;

	public float maxWidth;

	public float maxHeight;

	public int maxEntries;

	public bool supportScrollWheel;

	protected char[] mSeparator;

	protected List<Paragraph> mParagraphs;

	protected float mScroll;

	protected bool mSelected;

	protected int mTotalLines;

	public void Clear()
	{
	}

	public void Add(string text)
	{
	}

	protected void Add(string text, bool updateVisible)
	{
	}

	private void Awake()
	{
	}

	private void OnSelect(bool selected)
	{
	}

	protected void UpdateVisibleText()
	{
	}

	private void OnScroll(float val)
	{
	}
}
