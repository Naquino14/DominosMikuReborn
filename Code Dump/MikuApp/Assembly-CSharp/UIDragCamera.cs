using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag Camera")]
[ExecuteInEditMode]
public class UIDragCamera : IgnoreTimeScale
{
	public UIDraggableCamera draggableCamera;

	[HideInInspector]
	[SerializeField]
	private Component target;

	private void Awake()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnScroll(float delta)
	{
	}
}
