using System;
using UnityEngine;

// Token: 0x02000002 RID: 2
[AddComponentMenu("Kayac/Components/Touch To Mouse Converter")]
[Serializable]
public class TouchToMouseConverter : MonoBehaviour
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	public static Vector3 GetMousePosition()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
	public static TouchToMouseConverter GetInstance()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000205C File Offset: 0x0000025C
	public static void SetCamera(Camera c)
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002060 File Offset: 0x00000260
	public virtual void Awake()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002064 File Offset: 0x00000264
	public virtual void Start()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
	public virtual void Update()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000206C File Offset: 0x0000026C
	private void singleTouch()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002070 File Offset: 0x00000270
	private void multiTouch()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002074 File Offset: 0x00000274
	private void noTouch()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002078 File Offset: 0x00000278
	private void toDown()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000207C File Offset: 0x0000027C
	private void toDrag()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002080 File Offset: 0x00000280
	private void toUp()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002084 File Offset: 0x00000284
	private void toOldDrag()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002088 File Offset: 0x00000288
	private void toOldUp()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000208C File Offset: 0x0000028C
	private void toPinchStart()
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002090 File Offset: 0x00000290
	private void toPinch(float rate)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002094 File Offset: 0x00000294
	private void toPinchEnd()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002098 File Offset: 0x00000298
	public virtual void Main()
	{
	}

	// Token: 0x04000001 RID: 1
	public bool isOn;

	// Token: 0x04000002 RID: 2
	private TouchToMouseConverter.TouchToMouseState touchState;

	// Token: 0x04000003 RID: 3
	private RaycastHit hit;

	// Token: 0x04000004 RID: 4
	private Transform beforeTransform;

	// Token: 0x04000005 RID: 5
	private float DRAGGING_DISTANSE;

	// Token: 0x04000006 RID: 6
	[NonSerialized]
	private static TouchToMouseConverter instance;

	// Token: 0x04000007 RID: 7
	public Camera cam;

	// Token: 0x04000008 RID: 8
	private float _touchesDistance;

	// Token: 0x04000009 RID: 9
	private Touch _pre_a;

	// Token: 0x0400000A RID: 10
	private Touch _pre_b;

	// Token: 0x02000003 RID: 3
	[Serializable]
	private enum TouchToMouseState
	{
		// Token: 0x0400000C RID: 12
		Down,
		// Token: 0x0400000D RID: 13
		Drag,
		// Token: 0x0400000E RID: 14
		Up,
		// Token: 0x0400000F RID: 15
		Pinching,
		// Token: 0x04000010 RID: 16
		PinchEnd
	}
}
