using System;

// Token: 0x020000D1 RID: 209
public class MultiTargetBehaviour : DataSetTrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorMultiTargetBehaviour, IEditorTrackableBehaviour
{
	// Token: 0x060006C1 RID: 1729 RVA: 0x000036D4 File Offset: 0x000018D4
	void IEditorMultiTargetBehaviour.InitializeMultiTarget(MultiTarget multiTarget)
	{
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x060006C2 RID: 1730 RVA: 0x000036D8 File Offset: 0x000018D8
	public MultiTarget MultiTarget
	{
		get
		{
		}
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x000036DC File Offset: 0x000018DC
	protected override void InternalUnregisterTrackable()
	{
	}

	// Token: 0x0400043B RID: 1083
	private MultiTarget mMultiTarget;
}
