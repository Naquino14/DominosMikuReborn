using System;
using UnityEngine;

// Token: 0x02000021 RID: 33
[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Interaction/Draggable Camera")]
public class UIDraggableCamera : IgnoreTimeScale
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002360 File Offset: 0x00000560
	// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002364 File Offset: 0x00000564
	public Vector2 currentMomentum
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002368 File Offset: 0x00000568
	private void Awake()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x0000236C File Offset: 0x0000056C
	private void Start()
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00002370 File Offset: 0x00000570
	private Vector3 CalculateConstrainOffset()
	{
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00002374 File Offset: 0x00000574
	public bool ConstrainToBounds(bool immediate)
	{
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002378 File Offset: 0x00000578
	public void Press(bool isPressed)
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x0000237C File Offset: 0x0000057C
	public void Drag(Vector2 delta)
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002380 File Offset: 0x00000580
	public void Scroll(float delta)
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002384 File Offset: 0x00000584
	private void Update()
	{
	}

	// Token: 0x040000B1 RID: 177
	public Transform rootForBounds;

	// Token: 0x040000B2 RID: 178
	public Vector2 scale;

	// Token: 0x040000B3 RID: 179
	public float scrollWheelFactor;

	// Token: 0x040000B4 RID: 180
	public UIDragObject.DragEffect dragEffect;

	// Token: 0x040000B5 RID: 181
	public float momentumAmount;

	// Token: 0x040000B6 RID: 182
	private Camera mCam;

	// Token: 0x040000B7 RID: 183
	private Transform mTrans;

	// Token: 0x040000B8 RID: 184
	private bool mPressed;

	// Token: 0x040000B9 RID: 185
	private Vector2 mMomentum;

	// Token: 0x040000BA RID: 186
	private Bounds mBounds;

	// Token: 0x040000BB RID: 187
	private float mScroll;

	// Token: 0x040000BC RID: 188
	private UIRoot mRoot;
}
