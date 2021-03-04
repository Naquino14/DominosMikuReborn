using UnityEngine;

public class UINode
{
	private int mVisibleFlag;

	public Transform trans;

	public UIWidget widget;

	public bool lastActive;

	public Vector3 lastPos;

	public Quaternion lastRot;

	public Vector3 lastScale;

	public int changeFlag;

	private GameObject mGo;

	public int visibleFlag
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public UINode(Transform t)
	{
	}

	public bool HasChanged()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
