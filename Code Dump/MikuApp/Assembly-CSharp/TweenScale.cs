using UnityEngine;

[AddComponentMenu("NGUI/Tween/Scale")]
public class TweenScale : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool updateTable;

	private Transform mTrans;

	private UITable mTable;

	public Transform cachedTransform => (Transform)/*Error near IL_0001: Stack underflow*/;

	public Vector3 scale
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

	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
	{
		return (TweenScale)/*Error near IL_0001: Stack underflow*/;
	}
}
