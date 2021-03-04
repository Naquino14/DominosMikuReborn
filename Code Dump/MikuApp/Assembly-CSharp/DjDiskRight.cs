using UnityEngine;

public class DjDiskRight : DJDisk
{
	[SerializeField]
	protected float stopX;

	protected override float AngleToCenter(float angle)
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}

	protected override void SetFirstPositionOfCenterIndex()
	{
	}

	protected override float XfromAlpha(float a, int step)
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
}
