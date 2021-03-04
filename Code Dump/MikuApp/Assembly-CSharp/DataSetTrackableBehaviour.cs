using UnityEngine;

public abstract class DataSetTrackableBehaviour : TrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	[SerializeField]
	[HideInInspector]
	protected string mDataSetPath;

	string IEditorDataSetTrackableBehaviour.DataSetName => (string)/*Error near IL_0001: Stack underflow*/;

	string IEditorDataSetTrackableBehaviour.DataSetPath => (string)/*Error near IL_0001: Stack underflow*/;

	bool IEditorDataSetTrackableBehaviour.SetDataSetPath(string dataSetPath)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
