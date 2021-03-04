using System.Collections.Generic;
using UnityEngine;

public abstract class TrackableBehaviour : MonoBehaviour, IEditorTrackableBehaviour
{
	public enum Status
	{
		NOT_FOUND = -1,
		UNKNOWN,
		UNDEFINED,
		DETECTED,
		TRACKED
	}

	[HideInInspector]
	[SerializeField]
	protected string mTrackableName;

	[SerializeField]
	[HideInInspector]
	protected Vector3 mPreviousScale;

	[SerializeField]
	[HideInInspector]
	protected bool mPreserveChildSize;

	[HideInInspector]
	[SerializeField]
	protected bool mInitializedInEditor;

	protected Status mStatus;

	protected Trackable mTrackable;

	private List<ITrackableEventHandler> mTrackableEventHandlers;

	Vector3 IEditorTrackableBehaviour.PreviousScale => (Vector3)/*Error near IL_0001: Stack underflow*/;

	bool IEditorTrackableBehaviour.PreserveChildSize => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	bool IEditorTrackableBehaviour.InitializedInEditor => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public Status CurrentStatus => (Status)/*Error near IL_0001: Stack underflow*/;

	public Trackable Trackable => (Trackable)/*Error near IL_0001: Stack underflow*/;

	public string TrackableName => (string)/*Error near IL_0001: Stack underflow*/;

	bool IEditorTrackableBehaviour.CorrectScale()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorTrackableBehaviour.SetNameForTrackable(string name)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorTrackableBehaviour.SetPreviousScale(Vector3 previousScale)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorTrackableBehaviour.SetPreserveChildSize(bool preserveChildSize)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	bool IEditorTrackableBehaviour.SetInitializedInEditor(bool initializedInEditor)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	void IEditorTrackableBehaviour.UnregisterTrackable()
	{
	}

	public void RegisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
	}

	public bool UnregisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void OnTrackerUpdate(Status newStatus)
	{
	}

	protected abstract void InternalUnregisterTrackable();

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual bool CorrectScaleImpl()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	virtual bool IEditorTrackableBehaviour.get_enabled()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	virtual void IEditorTrackableBehaviour.set_enabled(bool value)
	{
	}

	virtual Transform IEditorTrackableBehaviour.get_transform()
	{
		return (Transform)/*Error near IL_0001: Stack underflow*/;
	}

	virtual GameObject IEditorTrackableBehaviour.get_gameObject()
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	virtual Renderer IEditorTrackableBehaviour.get_renderer()
	{
		return (Renderer)/*Error near IL_0001: Stack underflow*/;
	}
}
