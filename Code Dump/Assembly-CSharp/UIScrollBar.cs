using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Scroll Bar")]
public class UIScrollBar : MonoBehaviour
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600011E RID: 286 RVA: 0x000024C4 File Offset: 0x000006C4
	public Transform cachedTransform
	{
		get
		{
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600011F RID: 287 RVA: 0x000024C8 File Offset: 0x000006C8
	public Camera cachedCamera
	{
		get
		{
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000120 RID: 288 RVA: 0x000024CC File Offset: 0x000006CC
	// (set) Token: 0x06000121 RID: 289 RVA: 0x000024D0 File Offset: 0x000006D0
	public UISprite background
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000122 RID: 290 RVA: 0x000024D4 File Offset: 0x000006D4
	// (set) Token: 0x06000123 RID: 291 RVA: 0x000024D8 File Offset: 0x000006D8
	public UISprite foreground
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000124 RID: 292 RVA: 0x000024DC File Offset: 0x000006DC
	// (set) Token: 0x06000125 RID: 293 RVA: 0x000024E0 File Offset: 0x000006E0
	public UIScrollBar.Direction direction
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000126 RID: 294 RVA: 0x000024E4 File Offset: 0x000006E4
	// (set) Token: 0x06000127 RID: 295 RVA: 0x000024E8 File Offset: 0x000006E8
	public bool inverted
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000128 RID: 296 RVA: 0x000024EC File Offset: 0x000006EC
	// (set) Token: 0x06000129 RID: 297 RVA: 0x000024F0 File Offset: 0x000006F0
	public float scrollValue
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x0600012A RID: 298 RVA: 0x000024F4 File Offset: 0x000006F4
	// (set) Token: 0x0600012B RID: 299 RVA: 0x000024F8 File Offset: 0x000006F8
	public float barSize
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600012C RID: 300 RVA: 0x000024FC File Offset: 0x000006FC
	// (set) Token: 0x0600012D RID: 301 RVA: 0x00002500 File Offset: 0x00000700
	public float alpha
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x00002504 File Offset: 0x00000704
	private void CenterOnPos(Vector2 localPos)
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00002508 File Offset: 0x00000708
	private void Reposition(Vector2 screenPos)
	{
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000250C File Offset: 0x0000070C
	private void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	// Token: 0x06000131 RID: 305 RVA: 0x00002510 File Offset: 0x00000710
	private void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00002514 File Offset: 0x00000714
	private void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00002518 File Offset: 0x00000718
	private void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000251C File Offset: 0x0000071C
	private void Start()
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002520 File Offset: 0x00000720
	private void Update()
	{
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002524 File Offset: 0x00000724
	public void ForceUpdate()
	{
	}

	// Token: 0x04000127 RID: 295
	[SerializeField]
	[HideInInspector]
	private UISprite mBG;

	// Token: 0x04000128 RID: 296
	[HideInInspector]
	[SerializeField]
	private UISprite mFG;

	// Token: 0x04000129 RID: 297
	[HideInInspector]
	[SerializeField]
	private UIScrollBar.Direction mDir;

	// Token: 0x0400012A RID: 298
	[SerializeField]
	[HideInInspector]
	private bool mInverted;

	// Token: 0x0400012B RID: 299
	[SerializeField]
	[HideInInspector]
	private float mScroll;

	// Token: 0x0400012C RID: 300
	[SerializeField]
	[HideInInspector]
	private float mSize;

	// Token: 0x0400012D RID: 301
	private Transform mTrans;

	// Token: 0x0400012E RID: 302
	private bool mIsDirty;

	// Token: 0x0400012F RID: 303
	private Camera mCam;

	// Token: 0x04000130 RID: 304
	private Vector2 mScreenPos;

	// Token: 0x04000131 RID: 305
	public UIScrollBar.OnScrollBarChange onChange;

	// Token: 0x02000030 RID: 48
	public enum Direction
	{
		// Token: 0x04000133 RID: 307
		Horizontal,
		// Token: 0x04000134 RID: 308
		Vertical
	}

	// Token: 0x02000151 RID: 337
	// (Invoke) Token: 0x06000B39 RID: 2873
	public delegate void OnScrollBarChange(UIScrollBar sb);
}
