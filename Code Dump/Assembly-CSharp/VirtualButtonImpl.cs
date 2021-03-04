using System;

// Token: 0x020000C1 RID: 193
public class VirtualButtonImpl : VirtualButton
{
	// Token: 0x0600054D RID: 1357 RVA: 0x00003394 File Offset: 0x00001594
	public VirtualButtonImpl(string name, int id, VirtualButton.RectangleData area, ImageTarget imageTarget, DataSet dataSet)
	{
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600054E RID: 1358 RVA: 0x00003398 File Offset: 0x00001598
	public override string Name
	{
		get
		{
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600054F RID: 1359 RVA: 0x0000339C File Offset: 0x0000159C
	public override int ID
	{
		get
		{
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000550 RID: 1360 RVA: 0x000033A0 File Offset: 0x000015A0
	public override bool Enabled
	{
		get
		{
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000551 RID: 1361 RVA: 0x000033A4 File Offset: 0x000015A4
	public override VirtualButton.RectangleData Area
	{
		get
		{
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x000033A8 File Offset: 0x000015A8
	public override bool SetArea(VirtualButton.RectangleData area)
	{
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x000033AC File Offset: 0x000015AC
	public override bool SetSensitivity(VirtualButton.Sensitivity sensitivity)
	{
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x000033B0 File Offset: 0x000015B0
	public override bool SetEnabled(bool enabled)
	{
	}

	// Token: 0x04000419 RID: 1049
	private string mName;

	// Token: 0x0400041A RID: 1050
	private int mID;

	// Token: 0x0400041B RID: 1051
	private VirtualButton.RectangleData mArea;

	// Token: 0x0400041C RID: 1052
	private bool mIsEnabled;

	// Token: 0x0400041D RID: 1053
	private ImageTarget mParentImageTarget;

	// Token: 0x0400041E RID: 1054
	private DataSetImpl mParentDataSet;
}
