using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020000E9 RID: 233
public abstract class TrackableBehaviour : MonoBehaviour, IEditorTrackableBehaviour
{
	// Token: 0x06000724 RID: 1828 RVA: 0x000037C8 File Offset: 0x000019C8
	bool IEditorTrackableBehaviour.CorrectScale()
	{
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x000037CC File Offset: 0x000019CC
	bool IEditorTrackableBehaviour.SetNameForTrackable(string name)
	{
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000726 RID: 1830 RVA: 0x000037D0 File Offset: 0x000019D0
	Vector3 IEditorTrackableBehaviour.PreviousScale
	{
		get
		{
		}
	}

	// Token: 0x06000727 RID: 1831 RVA: 0x000037D4 File Offset: 0x000019D4
	bool IEditorTrackableBehaviour.SetPreviousScale(Vector3 previousScale)
	{
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x06000728 RID: 1832 RVA: 0x000037D8 File Offset: 0x000019D8
	bool IEditorTrackableBehaviour.PreserveChildSize
	{
		get
		{
		}
	}

	// Token: 0x06000729 RID: 1833 RVA: 0x000037DC File Offset: 0x000019DC
	bool IEditorTrackableBehaviour.SetPreserveChildSize(bool preserveChildSize)
	{
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x0600072A RID: 1834 RVA: 0x000037E0 File Offset: 0x000019E0
	bool IEditorTrackableBehaviour.InitializedInEditor
	{
		get
		{
		}
	}

	// Token: 0x0600072B RID: 1835 RVA: 0x000037E4 File Offset: 0x000019E4
	bool IEditorTrackableBehaviour.SetInitializedInEditor(bool initializedInEditor)
	{
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x000037E8 File Offset: 0x000019E8
	void IEditorTrackableBehaviour.UnregisterTrackable()
	{
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x0600072D RID: 1837 RVA: 0x000037EC File Offset: 0x000019EC
	public TrackableBehaviour.Status CurrentStatus
	{
		get
		{
		}
	}

	// Token: 0x17000120 RID: 288
	// (get) Token: 0x0600072E RID: 1838 RVA: 0x000037F0 File Offset: 0x000019F0
	public Trackable Trackable
	{
		get
		{
		}
	}

	// Token: 0x17000121 RID: 289
	// (get) Token: 0x0600072F RID: 1839 RVA: 0x000037F4 File Offset: 0x000019F4
	public string TrackableName
	{
		get
		{
		}
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x000037F8 File Offset: 0x000019F8
	public void RegisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x000037FC File Offset: 0x000019FC
	public bool UnregisterTrackableEventHandler(ITrackableEventHandler trackableEventHandler)
	{
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00003800 File Offset: 0x00001A00
	public void OnTrackerUpdate(TrackableBehaviour.Status newStatus)
	{
	}

	// Token: 0x06000733 RID: 1843
	protected abstract void InternalUnregisterTrackable();

	// Token: 0x06000734 RID: 1844 RVA: 0x00003804 File Offset: 0x00001A04
	private void Start()
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00003808 File Offset: 0x00001A08
	private void OnDisable()
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x0000380C File Offset: 0x00001A0C
	protected virtual bool CorrectScaleImpl()
	{
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00003810 File Offset: 0x00001A10
	virtual bool get_enabled()
	{
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x00003814 File Offset: 0x00001A14
	virtual void set_enabled(bool value)
	{
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00003818 File Offset: 0x00001A18
	virtual Transform get_transform()
	{
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x0000381C File Offset: 0x00001A1C
	virtual GameObject get_gameObject()
	{
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00003820 File Offset: 0x00001A20
	virtual Renderer get_renderer()
	{
	}

	// Token: 0x04000491 RID: 1169
	[HideInInspector]
	[SerializeField]
	protected string mTrackableName;

	// Token: 0x04000492 RID: 1170
	[SerializeField]
	[HideInInspector]
	protected Vector3 mPreviousScale;

	// Token: 0x04000493 RID: 1171
	[SerializeField]
	[HideInInspector]
	protected bool mPreserveChildSize;

	// Token: 0x04000494 RID: 1172
	[HideInInspector]
	[SerializeField]
	protected bool mInitializedInEditor;

	// Token: 0x04000495 RID: 1173
	protected TrackableBehaviour.Status mStatus;

	// Token: 0x04000496 RID: 1174
	protected Trackable mTrackable;

	// Token: 0x04000497 RID: 1175
	private List<ITrackableEventHandler> mTrackableEventHandlers;

	// Token: 0x020000EA RID: 234
	public enum Status
	{
		// Token: 0x04000499 RID: 1177
		NOT_FOUND = -1,
		// Token: 0x0400049A RID: 1178
		UNKNOWN,
		// Token: 0x0400049B RID: 1179
		UNDEFINED,
		// Token: 0x0400049C RID: 1180
		DETECTED,
		// Token: 0x0400049D RID: 1181
		TRACKED
	}
}
