using UnityEngine;

public class TouchScriptForMaxCam : MonoBehaviour
{
	public MaxCamera maxCam;

	private bool _isActive;

	private Quaternion targetRot;

	private float mouseXNow;

	private float mouseXPre;

	private float mouseYNow;

	private float mouseYPre;

	private float curRotY;

	private float curRotX;

	private float prePinch;

	private bool isPinchReset;

	private float curX;

	private float curY;

	private Quaternion zeroRot;

	private Vector3 zeroPos;

	public bool isActive
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void destroy()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}

	private void OnMouseDown2()
	{
	}

	private void OnMouseDrag()
	{
	}

	private void OnMouseDrag2()
	{
	}

	private void OnMouseUp()
	{
	}

	private void OnPinchStart()
	{
	}

	private void OnPinch(float rate)
	{
	}

	private void OnPinch2()
	{
	}

	private void doZoomWithMouse()
	{
	}

	private void doZoomWithTouch(float rate)
	{
	}

	private void doRotation()
	{
	}

	private void doPan()
	{
	}
}
