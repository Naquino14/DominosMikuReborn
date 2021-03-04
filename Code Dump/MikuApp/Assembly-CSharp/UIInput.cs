using UnityEngine;

[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInput : MonoBehaviour
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

	public static UIInput current;

	public UILabel label;

	public int maxChars;

	public string caratChar;

	public Validator validator;

	public KeyboardType type;

	public bool isPassword;

	public Color activeColor;

	public GameObject eventReceiver;

	public string functionName;

	public OnSubmit onSubmit;

	private string mText;

	private string mDefaultText;

	private Color mDefaultColor;

	private UIWidget.Pivot mPivot;

	private float mPosition;

	private TouchScreenKeyboard mKeyboard;

	private bool mDoInit;

	public string text
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

	private void OnSelect(bool isSelected)
	{
	}

	private void Update()
	{
	}

	private void OnInput(string input)
	{
	}

	private void UpdateLabel()
	{
	}

	private void RestoreLabel()
	{
	}
}
