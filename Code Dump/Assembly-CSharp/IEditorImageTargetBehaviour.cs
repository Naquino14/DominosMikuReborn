using System;
using UnityEngine;

// Token: 0x020000A3 RID: 163
public interface IEditorImageTargetBehaviour : IEditorDataSetTrackableBehaviour, IEditorTrackableBehaviour
{
	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000477 RID: 1143
	float AspectRatio { get; }

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000478 RID: 1144
	ImageTargetType ImageTargetType { get; }

	// Token: 0x06000479 RID: 1145
	bool SetAspectRatio(float aspectRatio);

	// Token: 0x0600047A RID: 1146
	bool SetImageTargetType(ImageTargetType imageTargetType);

	// Token: 0x0600047B RID: 1147
	Vector2 GetSize();

	// Token: 0x0600047C RID: 1148
	void InitializeImageTarget(ImageTarget imageTarget);

	// Token: 0x0600047D RID: 1149
	void CreateMissingVirtualButtonBehaviours();

	// Token: 0x0600047E RID: 1150
	bool TryGetVirtualButtonBehaviourByID(int id, out VirtualButtonBehaviour virtualButtonBehaviour);

	// Token: 0x0600047F RID: 1151
	void AssociateExistingVirtualButtonBehaviour(VirtualButtonBehaviour virtualButtonBehaviour);
}
