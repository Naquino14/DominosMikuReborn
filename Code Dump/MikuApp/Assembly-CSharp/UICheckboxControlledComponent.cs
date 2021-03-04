using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Checkbox Controlled Component")]
public class UICheckboxControlledComponent : MonoBehaviour
{
	public MonoBehaviour target;

	public bool inverse;

	private bool mUsingDelegates;

	private void Start()
	{
	}

	private void OnActivateDelegate(bool isActive)
	{
	}

	private void OnActivate(bool isActive)
	{
	}
}
