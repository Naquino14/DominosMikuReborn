using AnimationOrTween;
using UnityEngine;

[RequireComponent(typeof(Animation))]
[AddComponentMenu("NGUI/Internal/Active Animation")]
public class ActiveAnimation : IgnoreTimeScale
{
	public delegate void OnFinished(ActiveAnimation anim);

	public OnFinished onFinished;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private Animation mAnim;

	private Direction mLastDirection;

	private Direction mDisableDirection;

	private bool mNotify;

	public void Reset()
	{
	}

	private void Update()
	{
	}

	private void Play(string clipName, Direction playDirection)
	{
	}

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection, EnableCondition enableBeforePlay, DisableCondition disableCondition)
	{
		return (ActiveAnimation)/*Error near IL_0001: Stack underflow*/;
	}

	public static ActiveAnimation Play(Animation anim, string clipName, Direction playDirection)
	{
		return (ActiveAnimation)/*Error near IL_0001: Stack underflow*/;
	}

	public static ActiveAnimation Play(Animation anim, Direction playDirection)
	{
		return (ActiveAnimation)/*Error near IL_0001: Stack underflow*/;
	}
}
