using UnityEngine;

public interface IEditorImageTargetBehaviour : IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	float AspectRatio
	{
		get;
	}

	ImageTargetType ImageTargetType
	{
		get;
	}

	bool SetAspectRatio(float aspectRatio);

	bool SetImageTargetType(ImageTargetType imageTargetType);

	Vector2 GetSize();

	void InitializeImageTarget(ImageTarget imageTarget);

	void CreateMissingVirtualButtonBehaviours();

	bool TryGetVirtualButtonBehaviourByID(int id, out VirtualButtonBehaviour virtualButtonBehaviour);

	void AssociateExistingVirtualButtonBehaviour(VirtualButtonBehaviour virtualButtonBehaviour);
}
