using AnimationOrTween;
using UnityEngine;

public abstract class UITweener : IgnoreTimeScale
{
	public enum Method
	{
		Linear,
		EaseIn,
		EaseOut,
		EaseInOut,
		BounceIn,
		BounceOut
	}

	public enum Style
	{
		Once,
		Loop,
		PingPong
	}

	public delegate void OnFinished(UITweener tween);

	public OnFinished onFinished;

	public Method method;

	public Style style;

	public bool ignoreTimeScale;

	public float delay;

	public float duration;

	public bool steeperCurves;

	public int tweenGroup;

	public GameObject eventReceiver;

	public string callWhenFinished;

	private float mStartTime;

	private float mDuration;

	private float mAmountPerDelta;

	private float mFactor;

	public float amountPerDelta => (float)/*Error near IL_0001: Stack underflow*/;

	public float tweenFactor => (float)/*Error near IL_0001: Stack underflow*/;

	public Direction direction => (Direction)/*Error near IL_0001: Stack underflow*/;

	protected override void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Sample(float factor, bool isFinished)
	{
	}

	private float BounceLogic(float val)
	{
		return (float)/*Error near IL_0001: Stack underflow*/;
	}

	public void Play(bool forward)
	{
	}

	public void Reset()
	{
	}

	public void Toggle()
	{
	}

	protected abstract void OnUpdate(float factor, bool isFinished);

	public static T Begin<T>(GameObject go, float duration) where T : UITweener
	{
		return (T)/*Error near IL_0001: Stack underflow*/;
	}
}
