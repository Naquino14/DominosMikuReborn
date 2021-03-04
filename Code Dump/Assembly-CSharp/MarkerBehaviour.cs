using System;
using UnityEngine;

// Token: 0x020000CD RID: 205
public class MarkerBehaviour : TrackableBehaviour, IEditorMarkerBehaviour, IEditorTrackableBehaviour
{
	// Token: 0x17000108 RID: 264
	// (get) Token: 0x060006B2 RID: 1714 RVA: 0x000036AC File Offset: 0x000018AC
	int IEditorMarkerBehaviour.MarkerID
	{
		get
		{
		}
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x000036B0 File Offset: 0x000018B0
	bool IEditorMarkerBehaviour.SetMarkerID(int markerID)
	{
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x000036B4 File Offset: 0x000018B4
	void IEditorMarkerBehaviour.InitializeMarker(Marker marker)
	{
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x060006B5 RID: 1717 RVA: 0x000036B8 File Offset: 0x000018B8
	public Marker Marker
	{
		get
		{
		}
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000036BC File Offset: 0x000018BC
	protected override void InternalUnregisterTrackable()
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x000036C0 File Offset: 0x000018C0
	protected override bool CorrectScaleImpl()
	{
	}

	// Token: 0x04000438 RID: 1080
	[HideInInspector]
	[SerializeField]
	private int mMarkerID;

	// Token: 0x04000439 RID: 1081
	private Marker mMarker;
}
