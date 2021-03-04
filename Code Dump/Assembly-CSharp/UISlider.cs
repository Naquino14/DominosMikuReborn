using System;
using UnityEngine;

// Token: 0x02000031 RID: 49
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Slider")]
public class UISlider : IgnoreTimeScale
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000138 RID: 312 RVA: 0x0000252C File Offset: 0x0000072C
	// (set) Token: 0x06000139 RID: 313 RVA: 0x00002530 File Offset: 0x00000730
	public float sliderValue
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00002534 File Offset: 0x00000734
	private void Init()
	{
	}

	// Token: 0x0600013B RID: 315 RVA: 0x00002538 File Offset: 0x00000738
	private void Awake()
	{
	}

	// Token: 0x0600013C RID: 316 RVA: 0x0000253C File Offset: 0x0000073C
	private void Start()
	{
	}

	// Token: 0x0600013D RID: 317 RVA: 0x00002540 File Offset: 0x00000740
	private void OnPress(bool pressed)
	{
	}

	// Token: 0x0600013E RID: 318 RVA: 0x00002544 File Offset: 0x00000744
	private void OnDrag(Vector2 delta)
	{
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00002548 File Offset: 0x00000748
	private void OnPressThumb(GameObject go, bool pressed)
	{
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0000254C File Offset: 0x0000074C
	private void OnDragThumb(GameObject go, Vector2 delta)
	{
	}

	// Token: 0x06000141 RID: 321 RVA: 0x00002550 File Offset: 0x00000750
	private void OnKey(KeyCode key)
	{
	}

	// Token: 0x06000142 RID: 322 RVA: 0x00002554 File Offset: 0x00000754
	private void UpdateDrag()
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00002558 File Offset: 0x00000758
	private void Set(float input, bool force)
	{
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0000255C File Offset: 0x0000075C
	public void ForceUpdate()
	{
	}

	// Token: 0x04000135 RID: 309
	public static UISlider current;

	// Token: 0x04000136 RID: 310
	public Transform foreground;

	// Token: 0x04000137 RID: 311
	public Transform thumb;

	// Token: 0x04000138 RID: 312
	public UISlider.Direction direction;

	// Token: 0x04000139 RID: 313
	public Vector2 fullSize;

	// Token: 0x0400013A RID: 314
	public GameObject eventReceiver;

	// Token: 0x0400013B RID: 315
	public string functionName;

	// Token: 0x0400013C RID: 316
	public UISlider.OnValueChange onValueChange;

	// Token: 0x0400013D RID: 317
	public int numberOfSteps;

	// Token: 0x0400013E RID: 318
	[SerializeField]
	[HideInInspector]
	private float rawValue;

	// Token: 0x0400013F RID: 319
	private float mStepValue;

	// Token: 0x04000140 RID: 320
	private BoxCollider mCol;

	// Token: 0x04000141 RID: 321
	private Transform mTrans;

	// Token: 0x04000142 RID: 322
	private Transform mFGTrans;

	// Token: 0x04000143 RID: 323
	private UIWidget mFGWidget;

	// Token: 0x04000144 RID: 324
	private UIFilledSprite mFGFilled;

	// Token: 0x04000145 RID: 325
	private bool mInitDone;

	// Token: 0x02000032 RID: 50
	public enum Direction
	{
		// Token: 0x04000147 RID: 327
		Horizontal,
		// Token: 0x04000148 RID: 328
		Vertical
	}

	// Token: 0x02000152 RID: 338
	// (Invoke) Token: 0x06000B3D RID: 2877
	public delegate void OnValueChange(float val);
}
