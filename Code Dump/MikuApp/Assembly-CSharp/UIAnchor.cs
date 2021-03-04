using UnityEngine;

[AddComponentMenu("NGUI/UI/Anchor")]
[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	public enum Side
	{
		BottomLeft,
		Left,
		TopLeft,
		Top,
		TopRight,
		Right,
		BottomRight,
		Bottom,
		Center
	}

	private bool mIsWindows;

	public Camera uiCamera;

	public UIWidget widgetContainer;

	public UIPanel panelContainer;

	public Side side;

	public bool halfPixelOffset;

	public float depthOffset;

	public Vector2 relativeOffset;

	private Animation mAnim;

	private UIRoot mRoot;

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
