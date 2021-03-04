using UnityEngine;

public interface IEditorVirtualButtonBehaviour
{
	string VirtualButtonName
	{
		get;
	}

	VirtualButton.Sensitivity SensitivitySetting
	{
		get;
	}

	Matrix4x4 PreviousTransform
	{
		get;
	}

	GameObject PreviousParent
	{
		get;
	}

	bool UnregisterOnDestroy
	{
		get;
		set;
	}

	bool HasUpdatedPose
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

	bool SetVirtualButtonName(string virtualButtonName);

	bool SetSensitivitySetting(VirtualButton.Sensitivity sensibility);

	bool SetPreviousTransform(Matrix4x4 transform);

	bool SetPreviousParent(GameObject parent);

	void InitializeVirtualButton(VirtualButton virtualButton);

	bool SetPosAndScaleFromButtonArea(Vector2 topLeft, Vector2 bottomRight);

	bool UpdatePose();
}
