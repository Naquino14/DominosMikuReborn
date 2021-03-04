using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Center On Child")]
public class UICenterOnChild : MonoBehaviour
{
	public SpringPanel.OnFinished onFinished;

	private UIDraggablePanel mDrag;

	private GameObject mCenteredObject;

	public GameObject centeredObject => (GameObject)/*Error near IL_0001: Stack underflow*/;

	private void OnEnable()
	{
	}

	private void OnDragFinished()
	{
	}

	public void Recenter()
	{
	}
}
