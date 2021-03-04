using System.Collections.Generic;
using UnityEngine;

public class ImageTargetBehaviour : DataSetTrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorImageTargetBehaviour, IEditorTrackableBehaviour
{
	[SerializeField]
	[HideInInspector]
	private float mAspectRatio;

	[SerializeField]
	[HideInInspector]
	private ImageTargetType mImageTargetType;

	private ImageTarget mImageTarget;

	private Dictionary<int, VirtualButtonBehaviour> mVirtualButtonBehaviours;

	float IEditorImageTargetBehaviour.AspectRatio => (float)/*Error near IL_0001: Stack underflow*/;

	ImageTargetType IEditorImageTargetBehaviour.ImageTargetType => (ImageTargetType)/*Error near IL_0001: Stack underflow*/;

	public ImageTarget ImageTarget => (ImageTarget)/*Error near IL_0001: Stack underflow*/;

	bool IEditorImageTargetBehaviour.SetAspectRatio(float aspectRatio)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorImageTargetBehaviour.SetImageTargetType(ImageTargetType imageTargetType)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	void IEditorImageTargetBehaviour.InitializeImageTarget(ImageTarget imageTarget)
	{
	}

	void IEditorImageTargetBehaviour.AssociateExistingVirtualButtonBehaviour(VirtualButtonBehaviour virtualButtonBehaviour)
	{
	}

	void IEditorImageTargetBehaviour.CreateMissingVirtualButtonBehaviours()
	{
	}

	bool IEditorImageTargetBehaviour.TryGetVirtualButtonBehaviourByID(int id, out VirtualButtonBehaviour virtualButtonBehaviour)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	protected override bool CorrectScaleImpl()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	protected override void InternalUnregisterTrackable()
	{
	}

	public VirtualButtonBehaviour CreateVirtualButton(string vbName, Vector2 position, Vector2 size)
	{
		return (VirtualButtonBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public static VirtualButtonBehaviour CreateVirtualButton(string vbName, Vector2 localScale, GameObject immediateParent)
	{
		return (VirtualButtonBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	public IEnumerable<VirtualButtonBehaviour> GetVirtualButtonBehaviours()
	{
		return (IEnumerable<VirtualButtonBehaviour>)/*Error near IL_0001: Stack underflow*/;
	}

	public void DestroyVirtualButton(string vbName)
	{
	}

	public Vector2 GetSize()
	{
		return (Vector2)/*Error near IL_0001: Stack underflow*/;
	}

	private void CreateVirtualButtonFromNative(VirtualButton virtualButton)
	{
	}

	private bool CreateNewVirtualButtonFromBehaviour(VirtualButtonBehaviour newVBB)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
