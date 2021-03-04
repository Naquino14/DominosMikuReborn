using System;
using UnityEngine;

// Token: 0x020000A7 RID: 167
public interface IEditorVirtualButtonBehaviour
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000494 RID: 1172
	string VirtualButtonName { get; }

	// Token: 0x06000495 RID: 1173
	bool SetVirtualButtonName(string virtualButtonName);

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000496 RID: 1174
	VirtualButton.Sensitivity SensitivitySetting { get; }

	// Token: 0x06000497 RID: 1175
	bool SetSensitivitySetting(VirtualButton.Sensitivity sensibility);

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000498 RID: 1176
	Matrix4x4 PreviousTransform { get; }

	// Token: 0x06000499 RID: 1177
	bool SetPreviousTransform(Matrix4x4 transform);

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x0600049A RID: 1178
	GameObject PreviousParent { get; }

	// Token: 0x0600049B RID: 1179
	bool SetPreviousParent(GameObject parent);

	// Token: 0x0600049C RID: 1180
	void InitializeVirtualButton(VirtualButton virtualButton);

	// Token: 0x0600049D RID: 1181
	bool SetPosAndScaleFromButtonArea(Vector2 topLeft, Vector2 bottomRight);

	// Token: 0x170000D2 RID: 210
	// (get) Token: 0x0600049E RID: 1182
	// (set) Token: 0x0600049F RID: 1183
	bool UnregisterOnDestroy { get; set; }

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x060004A0 RID: 1184
	bool HasUpdatedPose { get; }

	// Token: 0x060004A1 RID: 1185
	bool UpdatePose();

	// Token: 0x170000D4 RID: 212
	// (get) Token: 0x060004A2 RID: 1186
	// (set) Token: 0x060004A3 RID: 1187
	bool enabled { get; set; }

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x060004A4 RID: 1188
	Transform transform { get; }

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x060004A5 RID: 1189
	GameObject gameObject { get; }

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x060004A6 RID: 1190
	Renderer renderer { get; }
}
