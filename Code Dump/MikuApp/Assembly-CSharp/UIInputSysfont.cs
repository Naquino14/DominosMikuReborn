using UnityEngine;

[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInputSysfont : MonoBehaviour
{
	public enum KeyboardType
	{
		Default,
		ASCIICapable,
		NumbersAndPunctuation,
		URL,
		NumberPad,
		PhonePad,
		NamePhonePad,
		EmailAddress
	}

	public delegate char Validator(string currentText, char nextChar);

	public delegate void OnSubmit(string inputString);

	public static UIInputSysfont current;

	public UISysFontLabel label;

	public int maxChars;

	public string caratChar;

	public Validator validator;

	public KeyboardType type;

	public bool isPassword;

	public Color activeColor;

	public GameObject eventReceiver;

	public string functionName;

	public OnSubmit onSubmit;

	[HideInInspector]
	public string mText;

	[HideInInspector]
	public string mDefaultText;

	[HideInInspector]
	public Color mDefaultColor;

	private UIWidget.Pivot mPivot;

	private float mPosition;

	public TouchScreenKeyboard mKeyboard;

	[HideInInspector]
	public bool mDoInit;

	public virtual string text
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool selected
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	protected void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void OnSelect(bool isSelected)
	{
	}

	private void Update()
	{
	}

	private void OnInput(string input)
	{
	}

	public virtual void UpdateLabel()
	{
	}

	public void RestoreLabel()
	{
	}
}
