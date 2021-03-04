using System;
using UnityEngine;

// Token: 0x0200001E RID: 30
[AddComponentMenu("NGUI/Interaction/Drag Object")]
public class UIDragObject : IgnoreTimeScale
{
	// Token: 0x060000B9 RID: 185 RVA: 0x00002330 File Offset: 0x00000530
	private void FindPanel()
	{
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002334 File Offset: 0x00000534
	private void OnPress(bool pressed)
	{
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002338 File Offset: 0x00000538
	private void OnDrag(Vector2 delta)
	{
	}

	// Token: 0x060000BC RID: 188 RVA: 0x0000233C File Offset: 0x0000053C
	private void LateUpdate()
	{
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002340 File Offset: 0x00000540
	private void OnScroll(float delta)
	{
	}

	// Token: 0x0400009E RID: 158
	public Transform target;

	// Token: 0x0400009F RID: 159
	public Vector3 scale;

	// Token: 0x040000A0 RID: 160
	public float scrollWheelFactor;

	// Token: 0x040000A1 RID: 161
	public bool restrictWithinPanel;

	// Token: 0x040000A2 RID: 162
	public UIDragObject.DragEffect dragEffect;

	// Token: 0x040000A3 RID: 163
	public float momentumAmount;

	// Token: 0x040000A4 RID: 164
	private Plane mPlane;

	// Token: 0x040000A5 RID: 165
	private Vector3 mLastPos;

	// Token: 0x040000A6 RID: 166
	private UIPanel mPanel;

	// Token: 0x040000A7 RID: 167
	private bool mPressed;

	// Token: 0x040000A8 RID: 168
	private Vector3 mMomentum;

	// Token: 0x040000A9 RID: 169
	private float mScroll;

	// Token: 0x040000AA RID: 170
	private Bounds mBounds;

	// Token: 0x0200001F RID: 31
	public enum DragEffect
	{
		// Token: 0x040000AC RID: 172
		None,
		// Token: 0x040000AD RID: 173
		Momentum,
		// Token: 0x040000AE RID: 174
		MomentumAndSpring
	}
}
