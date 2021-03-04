using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Checkbox")]
public class UICheckbox : MonoBehaviour
{
	public delegate void OnStateChange(bool state);

	public static UICheckbox current;

	public UISprite checkSprite;

	public Animation checkAnimation;

	public bool startsChecked;

	public Transform radioButtonRoot;

	public bool optionCanBeNone;

	public GameObject eventReceiver;

	public string functionName;

	public OnStateChange onStateChange;

	[SerializeField]
	[HideInInspector]
	private bool option;

	private bool mChecked;

	private bool mStarted;

	private Transform mTrans;

	public bool isChecked
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnClick()
	{
	}

	private void Set(bool state)
	{
	}
}
