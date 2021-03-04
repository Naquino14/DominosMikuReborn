using UnityEngine;

public class DjDiskTop : DJDisk
{
	[SerializeField]
	protected float stopY;

	public void Show(float delay)
	{
	}

	public void Hide(float delay)
	{
	}

	protected override float AngleToCenter(float angle)
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}

	protected override void SetFirstPositionOfCenterIndex()
	{
	}

	protected override void SetItemRotation(int index, float angle)
	{
	}

	protected override float XfromAlpha(float a, int step)
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}

	protected override float YfromAlpha(float a, int step)
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}

	protected override bool HideItemCondition(float x, float y)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	protected override void GetCenter(float angle)
	{
	}

	protected override float ClampAngle(float angle, float direction)
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}

	protected override void SetCenterItemColor()
	{
	}

	public override void SetAllItemWhite()
	{
	}
}
