using UnityEngine;

[AddComponentMenu("NGUI/Tween/Color")]
public class TweenColor : UITweener
{
	public Color from;

	public Color to;

	private Transform mTrans;

	private UIWidget mWidget;

	private Material mMat;

	private Light mLight;

	public Color color
	{
		get
		{
			return (Color)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenColor Begin(GameObject go, float duration, Color color)
	{
		return (TweenColor)/*Error near IL_0001: Stack underflow*/;
	}
}
