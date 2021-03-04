using System;
using UnityEngine;

[Serializable]
[AddComponentMenu("Kayac/Components/Touch To Mouse Converter")]
public class TouchToMouseConverter : MonoBehaviour
{
	[Serializable]
	private enum TouchToMouseState
	{
		Down,
		Drag,
		Up,
		Pinching,
		PinchEnd
	}

	public bool isOn;

	private TouchToMouseState touchState;

	private RaycastHit hit;

	private Transform beforeTransform;

	private float DRAGGING_DISTANSE;

	[NonSerialized]
	private static TouchToMouseConverter instance;

	public Camera cam;

	private float _touchesDistance;

	private Touch _pre_a;

	private Touch _pre_b;

	public static Vector3 GetMousePosition()
	{
		return (Vector3)/*Error near IL_0001: Stack underflow*/;
	}

	public static TouchToMouseConverter GetInstance()
	{
		return (TouchToMouseConverter)/*Error near IL_0001: Stack underflow*/;
	}

	public static void SetCamera(Camera c)
	{
	}

	public override void Awake()
	{
	}

	public override void Start()
	{
	}

	public override void Update()
	{
	}

	private void singleTouch()
	{
	}

	private void multiTouch()
	{
	}

	private void noTouch()
	{
	}

	private void toDown()
	{
	}

	private void toDrag()
	{
	}

	private void toUp()
	{
	}

	private void toOldDrag()
	{
	}

	private void toOldUp()
	{
	}

	private void toPinchStart()
	{
	}

	private void toPinch(float rate)
	{
	}

	private void toPinchEnd()
	{
	}

	public override void Main()
	{
	}
}
