using System;

// Token: 0x020000A2 RID: 162
public interface IEditorDataSetTrackableBehaviour : IEditorTrackableBehaviour
{
	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000474 RID: 1140
	string DataSetName { get; }

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000475 RID: 1141
	string DataSetPath { get; }

	// Token: 0x06000476 RID: 1142
	bool SetDataSetPath(string dataSetPath);
}
