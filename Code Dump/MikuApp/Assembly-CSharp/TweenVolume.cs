using UnityEngine;

[AddComponentMenu("NGUI/Tween/Volume")]
public class TweenVolume : UITweener
{
	public float from;

	public float to;

	private AudioSource mSource;

	public AudioSource audioSource => (AudioSource)/*Error near IL_0001: Stack underflow*/;

	public float volume
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

	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return (TweenVolume)/*Error near IL_0001: Stack underflow*/;
	}
}
