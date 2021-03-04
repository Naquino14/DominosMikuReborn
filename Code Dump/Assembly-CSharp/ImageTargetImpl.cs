using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000AA RID: 170
public class ImageTargetImpl : TrackableImpl, ImageTarget, Trackable
{
	// Token: 0x060004C1 RID: 1217 RVA: 0x00003164 File Offset: 0x00001364
	public ImageTargetImpl(string name, int id, ImageTargetType imageTargetType, DataSet dataSet)
	{
	}

	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00003168 File Offset: 0x00001368
	public ImageTargetType ImageTargetType
	{
		get
		{
		}
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x0000316C File Offset: 0x0000136C
	public Vector2 GetSize()
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00003170 File Offset: 0x00001370
	public void SetSize(Vector2 size)
	{
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00003174 File Offset: 0x00001374
	public VirtualButton CreateVirtualButton(string name, VirtualButton.RectangleData area)
	{
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00003178 File Offset: 0x00001378
	public VirtualButton GetVirtualButtonByName(string name)
	{
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x0000317C File Offset: 0x0000137C
	public IEnumerable<VirtualButton> GetVirtualButtons()
	{
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00003180 File Offset: 0x00001380
	public bool DestroyVirtualButton(VirtualButton vb)
	{
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00003184 File Offset: 0x00001384
	private VirtualButton CreateNewVirtualButtonInNative(string name, VirtualButton.RectangleData rectangleData)
	{
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00003188 File Offset: 0x00001388
	private bool UnregisterVirtualButtonInNative(VirtualButton vb)
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0000318C File Offset: 0x0000138C
	private void CreateVirtualButtonsFromNative()
	{
	}

	// Token: 0x040003CC RID: 972
	private Vector2 mSize;

	// Token: 0x040003CD RID: 973
	private readonly DataSetImpl mDataSet;

	// Token: 0x040003CE RID: 974
	private readonly ImageTargetType mImageTargetType;

	// Token: 0x040003CF RID: 975
	private readonly Dictionary<int, VirtualButton> mVirtualButtons;
}
