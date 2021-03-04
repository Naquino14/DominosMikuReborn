using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Field of View")]
public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera => (Camera)/*Error near IL_0001: Stack underflow*/;

	public float fov
	{
		get
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return (TweenFOV)/*Error near IL_0001: Stack underflow*/;
	}
}
