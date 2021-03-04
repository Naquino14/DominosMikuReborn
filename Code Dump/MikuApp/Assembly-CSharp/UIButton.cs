using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button")]
public class UIButton : UIButtonColor
{
	public Color disabledColor;

	public bool isEnabled
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	protected override void OnEnable()
	{
	}

	protected override void OnHover(bool isOver)
	{
	}

	protected override void OnPress(bool isPressed)
	{
	}

	public void UpdateColor(bool shouldBeEnabled, bool immediate)
	{
	}
}
