using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200009A RID: 154
public class ImageTargetBehaviour : DataSetTrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorImageTargetBehaviour, IEditorTrackableBehaviour
{
	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00002FD4 File Offset: 0x000011D4
	float IEditorImageTargetBehaviour.AspectRatio
	{
		get
		{
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600041D RID: 1053 RVA: 0x00002FD8 File Offset: 0x000011D8
	ImageTargetType IEditorImageTargetBehaviour.ImageTargetType
	{
		get
		{
		}
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00002FDC File Offset: 0x000011DC
	bool IEditorImageTargetBehaviour.SetAspectRatio(float aspectRatio)
	{
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x00002FE0 File Offset: 0x000011E0
	bool IEditorImageTargetBehaviour.SetImageTargetType(ImageTargetType imageTargetType)
	{
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00002FE4 File Offset: 0x000011E4
	void IEditorImageTargetBehaviour.InitializeImageTarget(ImageTarget imageTarget)
	{
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00002FE8 File Offset: 0x000011E8
	void IEditorImageTargetBehaviour.AssociateExistingVirtualButtonBehaviour(VirtualButtonBehaviour virtualButtonBehaviour)
	{
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00002FEC File Offset: 0x000011EC
	void IEditorImageTargetBehaviour.CreateMissingVirtualButtonBehaviours()
	{
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00002FF0 File Offset: 0x000011F0
	bool IEditorImageTargetBehaviour.TryGetVirtualButtonBehaviourByID(int id, out VirtualButtonBehaviour virtualButtonBehaviour)
	{
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000424 RID: 1060 RVA: 0x00002FF4 File Offset: 0x000011F4
	public ImageTarget ImageTarget
	{
		get
		{
		}
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00002FF8 File Offset: 0x000011F8
	protected override bool CorrectScaleImpl()
	{
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00002FFC File Offset: 0x000011FC
	protected override void InternalUnregisterTrackable()
	{
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00003000 File Offset: 0x00001200
	public VirtualButtonBehaviour CreateVirtualButton(string vbName, Vector2 position, Vector2 size)
	{
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00003004 File Offset: 0x00001204
	public static VirtualButtonBehaviour CreateVirtualButton(string vbName, Vector2 localScale, GameObject immediateParent)
	{
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00003008 File Offset: 0x00001208
	public IEnumerable<VirtualButtonBehaviour> GetVirtualButtonBehaviours()
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x0000300C File Offset: 0x0000120C
	public void DestroyVirtualButton(string vbName)
	{
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00003010 File Offset: 0x00001210
	public Vector2 GetSize()
	{
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00003014 File Offset: 0x00001214
	private void CreateVirtualButtonFromNative(VirtualButton virtualButton)
	{
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00003018 File Offset: 0x00001218
	private bool CreateNewVirtualButtonFromBehaviour(VirtualButtonBehaviour newVBB)
	{
	}

	// Token: 0x040003AA RID: 938
	[SerializeField]
	[HideInInspector]
	private float mAspectRatio;

	// Token: 0x040003AB RID: 939
	[SerializeField]
	[HideInInspector]
	private ImageTargetType mImageTargetType;

	// Token: 0x040003AC RID: 940
	private ImageTarget mImageTarget;

	// Token: 0x040003AD RID: 941
	private Dictionary<int, VirtualButtonBehaviour> mVirtualButtonBehaviours;
}
