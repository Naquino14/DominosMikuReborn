using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Localization")]
public class Localization : MonoBehaviour
{
	private static Localization mInst;

	public string startingLanguage;

	public TextAsset[] languages;

	private Dictionary<string, string> mDictionary;

	private string mLanguage;

	public static Localization instance => (Localization)/*Error near IL_0001: Stack underflow*/;

	public string currentLanguage
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
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

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Load(TextAsset asset)
	{
	}

	public string Get(string key)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}
}
