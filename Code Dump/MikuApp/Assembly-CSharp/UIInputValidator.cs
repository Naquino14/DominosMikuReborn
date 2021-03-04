using UnityEngine;

[RequireComponent(typeof(UIInput))]
[AddComponentMenu("NGUI/Interaction/Input Validator")]
public class UIInputValidator : MonoBehaviour
{
	public enum Validation
	{
		None,
		Integer,
		Float,
		Alphanumeric,
		Username,
		Name
	}

	public Validation logic;

	private void Start()
	{
	}

	private char Validate(string text, char ch)
	{
		return (char)/*Error near IL_0001: Stack underflow*/;
	}
}
