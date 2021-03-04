using System;
using System.Collections.Generic;

// Token: 0x0200009D RID: 157
public abstract class ImageTracker : Tracker
{
	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000435 RID: 1077
	public abstract ImageTargetBuilder ImageTargetBuilder { get; }

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000436 RID: 1078
	public abstract TargetFinder TargetFinder { get; }

	// Token: 0x06000437 RID: 1079
	public abstract DataSet CreateDataSet();

	// Token: 0x06000438 RID: 1080
	public abstract bool DestroyDataSet(DataSet dataSet, bool destroyTrackables);

	// Token: 0x06000439 RID: 1081
	public abstract bool ActivateDataSet(DataSet dataSet);

	// Token: 0x0600043A RID: 1082
	public abstract bool DeactivateDataSet(DataSet dataSet);

	// Token: 0x0600043B RID: 1083
	public abstract IEnumerable<DataSet> GetActiveDataSets();

	// Token: 0x0600043C RID: 1084
	public abstract IEnumerable<DataSet> GetDataSets();

	// Token: 0x0600043D RID: 1085
	public abstract void DestroyAllDataSets(bool destroyTrackables);
}
