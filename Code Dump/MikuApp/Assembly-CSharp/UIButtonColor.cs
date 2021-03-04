using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Color")]
public class UIButtonColor : MonoBehaviour
{
	public GameObject tweenTarget;

	public Color hover;

	public Color pressed;

	public float duration;

	protected Color mColor;

	protected bool mInitDone;

	protected bool mStarted;

	protected bool mHighlighted;

	public Color defaultColor
	{
		get
		{
			return (Color)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected virtual void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected void Init()
	{
	}

	protected virtual void OnPress(bool isPressed)
	{
	}

	protected virtual void OnHover(bool isOver)
	{
	}
}
