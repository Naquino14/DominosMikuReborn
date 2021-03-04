using UnityEngine;

[AddComponentMenu("NGUI/Tween/Rotation")]
public class TweenRotation : UITweener
{
	public Vector3 from;

	public Vector3 to;

	private Transform mTrans;

	public Transform cachedTransform => (Transform)/*Error near IL_0001: Stack underflow*/;

	public Quaternion rotation
	{
		get
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return (TweenRotation)/*Error near IL_0001: Stack underflow*/;
	}
}
