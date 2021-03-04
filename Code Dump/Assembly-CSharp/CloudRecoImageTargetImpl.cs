using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000A0 RID: 160
public class CloudRecoImageTargetImpl : TrackableImpl, ImageTarget, Trackable
{
	// Token: 0x0600045C RID: 1116 RVA: 0x0000309C File Offset: 0x0000129C
	public CloudRecoImageTargetImpl(string name, int id, Vector2 size)
	{
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x0600045D RID: 1117 RVA: 0x000030A0 File Offset: 0x000012A0
	public ImageTargetType ImageTargetType
	{
		get
		{
		}
	}

	// Token: 0x0600045E RID: 1118 RVA: 0x000030A4 File Offset: 0x000012A4
	public Vector2 GetSize()
	{
	}

	// Token: 0x0600045F RID: 1119 RVA: 0x000030A8 File Offset: 0x000012A8
	public void SetSize(Vector2 size)
	{
	}

	// Token: 0x06000460 RID: 1120 RVA: 0x000030AC File Offset: 0x000012AC
	public VirtualButton CreateVirtualButton(string name, VirtualButton.RectangleData area)
	{
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x000030B0 File Offset: 0x000012B0
	public VirtualButton GetVirtualButtonByName(string name)
	{
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x000030B4 File Offset: 0x000012B4
	public IEnumerable<VirtualButton> GetVirtualButtons()
	{
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x000030B8 File Offset: 0x000012B8
	public bool DestroyVirtualButton(VirtualButton vb)
	{
	}

	// Token: 0x040003BD RID: 957
	private readonly Vector2 mSize;
}
