using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Forward Events")]
public class UIForwardEvents : MonoBehaviour
{
	public GameObject target;

	public bool onHover;

	public bool onPress;

	public bool onClick;

	public bool onDoubleClick;

	public bool onSelect;

	public bool onDrag;

	public bool onDrop;

	public bool onInput;

	public bool onSubmit;

	public bool onScroll;

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnSelect(bool selected)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnDrop(GameObject go)
	{
	}

	private void OnInput(string text)
	{
	}

	private void OnSubmit()
	{
	}

	private void OnScroll(float delta)
	{
	}
}
