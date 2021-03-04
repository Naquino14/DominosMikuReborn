using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Image Button")]
public class UIImageButton : MonoBehaviour
{
	public UISprite target;

	public string normalSprite;

	public string hoverSprite;

	public string pressedSprite;

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnHover(bool isOver)
	{
	}

	private void OnPress(bool pressed)
	{
	}
}
