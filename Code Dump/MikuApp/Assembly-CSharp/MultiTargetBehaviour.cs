public class MultiTargetBehaviour : DataSetTrackableBehaviour, IEditorDataSetTrackableBehaviour, IEditorMultiTargetBehaviour, IEditorTrackableBehaviour
{
	private MultiTarget mMultiTarget;

	public MultiTarget MultiTarget => (MultiTarget)/*Error near IL_0001: Stack underflow*/;

	void IEditorMultiTargetBehaviour.InitializeMultiTarget(MultiTarget multiTarget)
	{
	}

	protected override void InternalUnregisterTrackable()
	{
	}
}
