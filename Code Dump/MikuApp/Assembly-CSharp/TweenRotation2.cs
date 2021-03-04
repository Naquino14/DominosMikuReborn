using UnityEngine;

public class TweenRotation2 : TweenRotation
{
	public string updateFunction;

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenRotation Begin(GameObject go, float duration, Vector3 eulerAngles)
	{
		return (TweenRotation)/*Error near IL_0001: Stack underflow*/;
	}

	public static TweenRotation Begin(GameObject go, float duration, Vector3 eulerAngles, GameObject eventReceiver, string updateFunction)
	{
		return (TweenRotation)/*Error near IL_0001: Stack underflow*/;
	}
}
