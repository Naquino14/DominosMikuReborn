using UnityEngine;

[AddComponentMenu("NGUI/Internal/Event Listener")]
public class UIEventListener : MonoBehaviour
{
	public delegate void VoidDelegate(GameObject go);

	public delegate void BoolDelegate(GameObject go, bool state);

	public delegate void FloatDelegate(GameObject go, float delta);

	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	public delegate void StringDelegate(GameObject go, string text);

	public delegate void ObjectDelegate(GameObject go, GameObject draggedObject);

	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	public object parameter;

	public VoidDelegate onSubmit;

	public VoidDelegate onClick;

	public VoidDelegate onDoubleClick;

	public BoolDelegate onHover;

	public BoolDelegate onPress;

	public BoolDelegate onSelect;

	public FloatDelegate onScroll;

	public VectorDelegate onDrag;

	public ObjectDelegate onDrop;

	public StringDelegate onInput;

	public KeyCodeDelegate onKey;

	private void OnSubmit()
	{
	}

	private void OnClick()
	{
	}

	private void OnDoubleClick()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnSelect(bool selected)
	{
	}

	private void OnScroll(float delta)
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

	private void OnKey(KeyCode key)
	{
	}

	public static UIEventListener Get(GameObject go)
	{
		return (UIEventListener)/*Error near IL_0001: Stack underflow*/;
	}
}
