public interface IEditorDataSetTrackableBehaviour : IEditorTrackableBehaviour
{
	string DataSetName
	{
		get;
	}

	string DataSetPath
	{
		get;
	}

	bool SetDataSetPath(string dataSetPath);
}
