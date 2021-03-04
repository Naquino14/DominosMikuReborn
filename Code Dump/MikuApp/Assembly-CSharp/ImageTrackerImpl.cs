using System.Collections.Generic;

public class ImageTrackerImpl : ImageTracker
{
	private List<DataSetImpl> mActiveDataSets;

	private List<DataSet> mDataSets;

	private ImageTargetBuilder mImageTargetBuilder;

	private TargetFinder mTargetFinder;

	public override ImageTargetBuilder ImageTargetBuilder => (ImageTargetBuilder)/*Error near IL_0001: Stack underflow*/;

	public override TargetFinder TargetFinder => (TargetFinder)/*Error near IL_0001: Stack underflow*/;

	public override bool Start()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override void Stop()
	{
	}

	public override DataSet CreateDataSet()
	{
		return (DataSet)/*Error near IL_0001: Stack underflow*/;
	}

	public override bool DestroyDataSet(DataSet dataSet, bool destroyTrackables)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool ActivateDataSet(DataSet dataSet)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool DeactivateDataSet(DataSet dataSet)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override IEnumerable<DataSet> GetActiveDataSets()
	{
		return (IEnumerable<DataSet>)/*Error near IL_0001: Stack underflow*/;
	}

	public override IEnumerable<DataSet> GetDataSets()
	{
		return (IEnumerable<DataSet>)/*Error near IL_0001: Stack underflow*/;
	}

	public override void DestroyAllDataSets(bool destroyTrackables)
	{
	}
}
