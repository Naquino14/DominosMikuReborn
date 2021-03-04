using System;
using UnityEngine;

// Token: 0x0200008B RID: 139
public abstract class DataSetTrackableBehaviour : TrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060003E3 RID: 995 RVA: 0x00002F80 File Offset: 0x00001180
	string IEditorDataSetTrackableBehaviour.DataSetName
	{
		get
		{
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060003E4 RID: 996 RVA: 0x00002F84 File Offset: 0x00001184
	string IEditorDataSetTrackableBehaviour.DataSetPath
	{
		get
		{
		}
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00002F88 File Offset: 0x00001188
	bool IEditorDataSetTrackableBehaviour.SetDataSetPath(string dataSetPath)
	{
	}

	// Token: 0x04000395 RID: 917
	[SerializeField]
	[HideInInspector]
	protected string mDataSetPath;
}
