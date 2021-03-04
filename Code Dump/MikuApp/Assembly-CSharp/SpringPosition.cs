using UnityEngine;

[AddComponentMenu("NGUI/Tween/Spring Position")]
public class SpringPosition : IgnoreTimeScale
{
	public delegate void OnFinished(SpringPosition spring);

	public Vector3 target;

	public float strength;

	public bool worldSpace;

	public bool ignoreTimeScale;

	public GameObject eventReceiver;

	public string callWhenFinished;

	public OnFinished onFinished;

	private Transform mTrans;

	private float mThreshold;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return (SpringPosition)/*Error near IL_0001: Stack underflow*/;
	}
}
