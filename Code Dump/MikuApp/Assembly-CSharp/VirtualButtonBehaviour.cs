using System.Collections.Generic;
using UnityEngine;

public class VirtualButtonBehaviour : MonoBehaviour, IEditorVirtualButtonBehaviour
{
	public const float TARGET_OFFSET = 0.001f;

	[SerializeField]
	[HideInInspector]
	private string mName;

	[HideInInspector]
	[SerializeField]
	private VirtualButton.Sensitivity mSensitivity;

	[HideInInspector]
	[SerializeField]
	private bool mHasUpdatedPose;

	[SerializeField]
	[HideInInspector]
	private Matrix4x4 mPrevTransform;

	[HideInInspector]
	[SerializeField]
	private GameObject mPrevParent;

	private bool mSensitivityDirty;

	private bool mPreviouslyEnabled;

	private bool mPressed;

	private List<IVirtualButtonEventHandler> mHandlers;

	private Vector2 mLeftTop;

	private Vector2 mRightBottom;

	private bool mUnregisterOnDestroy;

	private VirtualButton mVirtualButton;

	VirtualButton.Sensitivity IEditorVirtualButtonBehaviour.SensitivitySetting => (VirtualButton.Sensitivity)/*Error near IL_0001: Stack underflow*/;

	Matrix4x4 IEditorVirtualButtonBehaviour.PreviousTransform => (Matrix4x4)/*Error near IL_0001: Stack underflow*/;

	GameObject IEditorVirtualButtonBehaviour.PreviousParent => (GameObject)/*Error near IL_0001: Stack underflow*/;

	public string VirtualButtonName => (string)/*Error near IL_0001: Stack underflow*/;

	public bool Pressed => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public bool HasUpdatedPose => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public bool UnregisterOnDestroy
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public VirtualButton VirtualButton => (VirtualButton)/*Error near IL_0001: Stack underflow*/;

	bool IEditorVirtualButtonBehaviour.SetVirtualButtonName(string virtualButtonName)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorVirtualButtonBehaviour.SetSensitivitySetting(VirtualButton.Sensitivity sensibility)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorVirtualButtonBehaviour.SetPreviousTransform(Matrix4x4 transform)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorVirtualButtonBehaviour.SetPreviousParent(GameObject parent)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	void IEditorVirtualButtonBehaviour.InitializeVirtualButton(VirtualButton virtualButton)
	{
	}

	bool IEditorVirtualButtonBehaviour.SetPosAndScaleFromButtonArea(Vector2 topLeft, Vector2 bottomRight)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void RegisterEventHandler(IVirtualButtonEventHandler eventHandler)
	{
	}

	public bool UnregisterEventHandler(IVirtualButtonEventHandler eventHandler)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool CalculateButtonArea(out Vector2 topLeft, out Vector2 bottomRight)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool UpdateAreaRectangle()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool UpdateSensitivity()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private bool UpdateEnabled()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool UpdatePose()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void OnTrackerUpdated(bool pressed)
	{
	}

	public ImageTargetBehaviour GetImageTargetBehaviour()
	{
		return (ImageTargetBehaviour)/*Error near IL_0001: Stack underflow*/;
	}

	private void LateUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private static bool Equals(Vector2 vec1, Vector2 vec2, float threshold)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	virtual bool IEditorVirtualButtonBehaviour.get_enabled()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	virtual void IEditorVirtualButtonBehaviour.set_enabled(bool value)
	{
	}

	virtual Transform IEditorVirtualButtonBehaviour.get_transform()
	{
		return (Transform)/*Error near IL_0001: Stack underflow*/;
	}

	virtual GameObject IEditorVirtualButtonBehaviour.get_gameObject()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	virtual Renderer IEditorVirtualButtonBehaviour.get_renderer()
	{
		return (Renderer)/*Error near IL_0001: Stack underflow*/;
	}
}
