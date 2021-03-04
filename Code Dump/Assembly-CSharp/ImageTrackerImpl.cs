using System;
using System.Collections.Generic;

// Token: 0x020000AB RID: 171
public class ImageTrackerImpl : ImageTracker
{
	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x060004CD RID: 1229 RVA: 0x00003194 File Offset: 0x00001394
	public override ImageTargetBuilder ImageTargetBuilder
	{
		get
		{
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x060004CE RID: 1230 RVA: 0x00003198 File Offset: 0x00001398
	public override TargetFinder TargetFinder
	{
		get
		{
		}
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x0000319C File Offset: 0x0000139C
	public override bool Start()
	{
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x000031A0 File Offset: 0x000013A0
	public override void Stop()
	{
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x000031A4 File Offset: 0x000013A4
	public override DataSet CreateDataSet()
	{
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x000031A8 File Offset: 0x000013A8
	public override bool DestroyDataSet(DataSet dataSet, bool destroyTrackables)
	{
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x000031AC File Offset: 0x000013AC
	public override bool ActivateDataSet(DataSet dataSet)
	{
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x000031B0 File Offset: 0x000013B0
	public override bool DeactivateDataSet(DataSet dataSet)
	{
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x000031B4 File Offset: 0x000013B4
	public override IEnumerable<DataSet> GetActiveDataSets()
	{
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x000031B8 File Offset: 0x000013B8
	public override IEnumerable<DataSet> GetDataSets()
	{
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x000031BC File Offset: 0x000013BC
	public override void DestroyAllDataSets(bool destroyTrackables)
	{
	}

	// Token: 0x040003D0 RID: 976
	private List<DataSetImpl> mActiveDataSets;

	// Token: 0x040003D1 RID: 977
	private List<DataSet> mDataSets;

	// Token: 0x040003D2 RID: 978
	private ImageTargetBuilder mImageTargetBuilder;

	// Token: 0x040003D3 RID: 979
	private TargetFinder mTargetFinder;
}
