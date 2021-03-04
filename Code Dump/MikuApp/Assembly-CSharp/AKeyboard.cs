using UnityEngine;

public class AKeyboard : MonoBehaviour
{
	public TouchScreenKeyboard keyboard;

	public static AKeyboard instance;

	private string onKeyboardDoneFunc;

	private GameObject receiver;

	public static void Open(string defautText, MonoBehaviour receiver)
	{
	}

	private void Update()
	{
	}

	private static void DestroyKeyboard()
	{
	}
}
