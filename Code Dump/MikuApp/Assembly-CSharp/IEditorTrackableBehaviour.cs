using UnityEngine;

public interface IEditorTrackableBehaviour
{
	string TrackableName
	{
		get;
	}

	Trackable Trackable
	{
		get;
	}

	Vector3 PreviousScale
	{
		get;
	}

	bool PreserveChildSize
	{
		get;
	}

	bool InitializedInEditor
	{
		get;
	}

	bool enabled
	{
		get;
		set;
	}

	Transform transform
	{
		get;
	}

	GameObject gameObject
	{
		get;
	}

	Renderer renderer
	{
		get;
	}

	bool CorrectScale();

	bool SetNameForTrackable(string name);

	bool SetPreviousScale(Vector3 previousScale);

	bool SetPreserveChildSize(bool preserveChildSize);

	bool SetInitializedInEditor(bool initializedInEditor);

	void UnregisterTrackable();
}
