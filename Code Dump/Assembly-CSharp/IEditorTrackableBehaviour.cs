using System;
using UnityEngine;

// Token: 0x020000A6 RID: 166
public interface IEditorTrackableBehaviour
{
	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000484 RID: 1156
	string TrackableName { get; }

	// Token: 0x06000485 RID: 1157
	bool CorrectScale();

	// Token: 0x06000486 RID: 1158
	bool SetNameForTrackable(string name);

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000487 RID: 1159
	Trackable Trackable { get; }

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000488 RID: 1160
	Vector3 PreviousScale { get; }

	// Token: 0x06000489 RID: 1161
	bool SetPreviousScale(Vector3 previousScale);

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x0600048A RID: 1162
	bool PreserveChildSize { get; }

	// Token: 0x0600048B RID: 1163
	bool SetPreserveChildSize(bool preserveChildSize);

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x0600048C RID: 1164
	bool InitializedInEditor { get; }

	// Token: 0x0600048D RID: 1165
	bool SetInitializedInEditor(bool initializedInEditor);

	// Token: 0x0600048E RID: 1166
	void UnregisterTrackable();

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x0600048F RID: 1167
	// (set) Token: 0x06000490 RID: 1168
	bool enabled { get; set; }

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000491 RID: 1169
	Transform transform { get; }

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000492 RID: 1170
	GameObject gameObject { get; }

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000493 RID: 1171
	Renderer renderer { get; }
}
