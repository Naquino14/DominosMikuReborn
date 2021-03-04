using UnityEngine;

[AddComponentMenu("NGUI/Tween/Position")]
public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	private Transform mTrans;

	public Transform cachedTransform => (Transform)/*Error near IL_0001: Stack underflow*/;

	public Vector3 position
	{
		get
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return (TweenPosition)/*Error near IL_0001: Stack underflow*/;
	}
}
