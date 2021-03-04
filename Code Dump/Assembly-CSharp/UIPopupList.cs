using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002C RID: 44
[AddComponentMenu("NGUI/Interaction/Popup List")]
[ExecuteInEditMode]
public class UIPopupList : MonoBehaviour
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000103 RID: 259 RVA: 0x00002458 File Offset: 0x00000658
	public bool isOpen
	{
		get
		{
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000104 RID: 260 RVA: 0x0000245C File Offset: 0x0000065C
	// (set) Token: 0x06000105 RID: 261 RVA: 0x00002460 File Offset: 0x00000660
	public string selection
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000106 RID: 262 RVA: 0x00002464 File Offset: 0x00000664
	// (set) Token: 0x06000107 RID: 263 RVA: 0x00002468 File Offset: 0x00000668
	private bool handleEvents
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0000246C File Offset: 0x0000066C
	private void Start()
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002470 File Offset: 0x00000670
	private void OnLocalize(Localization loc)
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00002474 File Offset: 0x00000674
	private void Highlight(UILabel lbl, bool instant)
	{
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00002478 File Offset: 0x00000678
	private void OnItemHover(GameObject go, bool isOver)
	{
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000247C File Offset: 0x0000067C
	private void Select(UILabel lbl, bool instant)
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002480 File Offset: 0x00000680
	private void OnItemPress(GameObject go, bool isPressed)
	{
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00002484 File Offset: 0x00000684
	private void OnKey(KeyCode key)
	{
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002488 File Offset: 0x00000688
	private void OnSelect(bool isSelected)
	{
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000248C File Offset: 0x0000068C
	private void AnimateColor(UIWidget widget)
	{
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00002490 File Offset: 0x00000690
	private void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00002494 File Offset: 0x00000694
	private void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00002498 File Offset: 0x00000698
	private void Animate(UIWidget widget, bool placeAbove, float bottom)
	{
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000249C File Offset: 0x0000069C
	private void OnClick()
	{
	}

	// Token: 0x04000105 RID: 261
	private const float animSpeed = 0.15f;

	// Token: 0x04000106 RID: 262
	public static UIPopupList current;

	// Token: 0x04000107 RID: 263
	public UIAtlas atlas;

	// Token: 0x04000108 RID: 264
	public UIFont font;

	// Token: 0x04000109 RID: 265
	public UILabel textLabel;

	// Token: 0x0400010A RID: 266
	public string backgroundSprite;

	// Token: 0x0400010B RID: 267
	public string highlightSprite;

	// Token: 0x0400010C RID: 268
	public UIPopupList.Position position;

	// Token: 0x0400010D RID: 269
	public List<string> items;

	// Token: 0x0400010E RID: 270
	public Vector2 padding;

	// Token: 0x0400010F RID: 271
	public float textScale;

	// Token: 0x04000110 RID: 272
	public Color textColor;

	// Token: 0x04000111 RID: 273
	public Color backgroundColor;

	// Token: 0x04000112 RID: 274
	public Color highlightColor;

	// Token: 0x04000113 RID: 275
	public bool isAnimated;

	// Token: 0x04000114 RID: 276
	public bool isLocalized;

	// Token: 0x04000115 RID: 277
	public GameObject eventReceiver;

	// Token: 0x04000116 RID: 278
	public string functionName;

	// Token: 0x04000117 RID: 279
	public UIPopupList.OnSelectionChange onSelectionChange;

	// Token: 0x04000118 RID: 280
	[HideInInspector]
	[SerializeField]
	private string mSelectedItem;

	// Token: 0x04000119 RID: 281
	private UIPanel mPanel;

	// Token: 0x0400011A RID: 282
	private GameObject mChild;

	// Token: 0x0400011B RID: 283
	private UISprite mBackground;

	// Token: 0x0400011C RID: 284
	private UISprite mHighlight;

	// Token: 0x0400011D RID: 285
	private UILabel mHighlightedLabel;

	// Token: 0x0400011E RID: 286
	private List<UILabel> mLabelList;

	// Token: 0x0400011F RID: 287
	private float mBgBorder;

	// Token: 0x0200002D RID: 45
	public enum Position
	{
		// Token: 0x04000121 RID: 289
		Auto,
		// Token: 0x04000122 RID: 290
		Above,
		// Token: 0x04000123 RID: 291
		Below
	}

	// Token: 0x02000150 RID: 336
	// (Invoke) Token: 0x06000B35 RID: 2869
	public delegate void OnSelectionChange(string item);
}
