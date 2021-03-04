using System;
using UnityEngine;

// Token: 0x0200004D RID: 77
public abstract class UIWidget : MonoBehaviour
{
	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000216 RID: 534 RVA: 0x000028A4 File Offset: 0x00000AA4
	// (set) Token: 0x06000217 RID: 535 RVA: 0x000028A8 File Offset: 0x00000AA8
	public Color color
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000218 RID: 536 RVA: 0x000028AC File Offset: 0x00000AAC
	// (set) Token: 0x06000219 RID: 537 RVA: 0x000028B0 File Offset: 0x00000AB0
	public float alpha
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x0600021A RID: 538 RVA: 0x000028B4 File Offset: 0x00000AB4
	// (set) Token: 0x0600021B RID: 539 RVA: 0x000028B8 File Offset: 0x00000AB8
	public UIWidget.Pivot pivot
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600021C RID: 540 RVA: 0x000028BC File Offset: 0x00000ABC
	// (set) Token: 0x0600021D RID: 541 RVA: 0x000028C0 File Offset: 0x00000AC0
	public int depth
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x0600021E RID: 542 RVA: 0x000028C4 File Offset: 0x00000AC4
	public Transform cachedTransform
	{
		get
		{
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600021F RID: 543 RVA: 0x000028C8 File Offset: 0x00000AC8
	// (set) Token: 0x06000220 RID: 544 RVA: 0x000028CC File Offset: 0x00000ACC
	public virtual Material material
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000221 RID: 545 RVA: 0x000028D0 File Offset: 0x00000AD0
	// (set) Token: 0x06000222 RID: 546 RVA: 0x000028D4 File Offset: 0x00000AD4
	public virtual Texture mainTexture
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06000223 RID: 547 RVA: 0x000028D8 File Offset: 0x00000AD8
	// (set) Token: 0x06000224 RID: 548 RVA: 0x000028DC File Offset: 0x00000ADC
	public UIPanel panel
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000225 RID: 549 RVA: 0x000028E0 File Offset: 0x00000AE0
	// (set) Token: 0x06000226 RID: 550 RVA: 0x000028E4 File Offset: 0x00000AE4
	public int visibleFlag
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000227 RID: 551 RVA: 0x000028E8 File Offset: 0x00000AE8
	public static int CompareFunc(UIWidget left, UIWidget right)
	{
	}

	// Token: 0x06000228 RID: 552 RVA: 0x000028EC File Offset: 0x00000AEC
	public virtual void MarkAsChanged()
	{
	}

	// Token: 0x06000229 RID: 553 RVA: 0x000028F0 File Offset: 0x00000AF0
	private void CreatePanel()
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x000028F4 File Offset: 0x00000AF4
	public void CheckLayer()
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x000028F8 File Offset: 0x00000AF8
	public void CheckParent()
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000028FC File Offset: 0x00000AFC
	protected virtual void Awake()
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002900 File Offset: 0x00000B00
	private void OnEnable()
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002904 File Offset: 0x00000B04
	private void Start()
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002908 File Offset: 0x00000B08
	public void Update()
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x0000290C File Offset: 0x00000B0C
	private void OnDisable()
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002910 File Offset: 0x00000B10
	private void OnDestroy()
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002914 File Offset: 0x00000B14
	public bool UpdateGeometry(ref Matrix4x4 worldToPanel, bool parentMoved, bool generateNormals)
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002918 File Offset: 0x00000B18
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	// Token: 0x06000234 RID: 564 RVA: 0x0000291C File Offset: 0x00000B1C
	public virtual void MakePixelPerfect()
	{
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000235 RID: 565 RVA: 0x00002920 File Offset: 0x00000B20
	public virtual Vector2 pivotOffset
	{
		get
		{
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x06000236 RID: 566 RVA: 0x00002924 File Offset: 0x00000B24
	public virtual Vector2 relativeSize
	{
		get
		{
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000237 RID: 567 RVA: 0x00002928 File Offset: 0x00000B28
	public virtual bool keepMaterial
	{
		get
		{
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x0000292C File Offset: 0x00000B2C
	protected virtual void OnStart()
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002930 File Offset: 0x00000B30
	public virtual bool OnUpdate()
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002934 File Offset: 0x00000B34
	public virtual void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	// Token: 0x040001E0 RID: 480
	[SerializeField]
	[HideInInspector]
	private Material mMat;

	// Token: 0x040001E1 RID: 481
	[SerializeField]
	[HideInInspector]
	private Texture mTex;

	// Token: 0x040001E2 RID: 482
	[SerializeField]
	[HideInInspector]
	private Color mColor;

	// Token: 0x040001E3 RID: 483
	[HideInInspector]
	[SerializeField]
	private UIWidget.Pivot mPivot;

	// Token: 0x040001E4 RID: 484
	[HideInInspector]
	[SerializeField]
	private int mDepth;

	// Token: 0x040001E5 RID: 485
	private Transform mTrans;

	// Token: 0x040001E6 RID: 486
	private UIPanel mPanel;

	// Token: 0x040001E7 RID: 487
	protected bool mChanged;

	// Token: 0x040001E8 RID: 488
	protected bool mPlayMode;

	// Token: 0x040001E9 RID: 489
	private Vector3 mDiffPos;

	// Token: 0x040001EA RID: 490
	private Quaternion mDiffRot;

	// Token: 0x040001EB RID: 491
	private Vector3 mDiffScale;

	// Token: 0x040001EC RID: 492
	private int mVisibleFlag;

	// Token: 0x040001ED RID: 493
	private UIGeometry mGeom;

	// Token: 0x0200004E RID: 78
	public enum Pivot
	{
		// Token: 0x040001EF RID: 495
		TopLeft,
		// Token: 0x040001F0 RID: 496
		Top,
		// Token: 0x040001F1 RID: 497
		TopRight,
		// Token: 0x040001F2 RID: 498
		Left,
		// Token: 0x040001F3 RID: 499
		Center,
		// Token: 0x040001F4 RID: 500
		Right,
		// Token: 0x040001F5 RID: 501
		BottomLeft,
		// Token: 0x040001F6 RID: 502
		Bottom,
		// Token: 0x040001F7 RID: 503
		BottomRight
	}
}
