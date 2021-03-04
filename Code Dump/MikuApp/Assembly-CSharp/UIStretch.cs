using UnityEngine;

[AddComponentMenu("NGUI/UI/Stretch")]
[ExecuteInEditMode]
public class UIStretch : MonoBehaviour
{
	public enum Style
	{
		None,
		Horizontal,
		Vertical,
		Both,
		BasedOnHeight
	}

	public Camera uiCamera;

	public UIWidget widgetContainer;

	public UIPanel panelContainer;

	public Style style;

	public Vector2 relativeSize;

	private Transform mTrans;

	private UIRoot mRoot;

	private Animation mAnim;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
