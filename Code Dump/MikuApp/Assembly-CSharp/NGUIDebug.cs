using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Debug")]
public class NGUIDebug : MonoBehaviour
{
	private static List<string> mLines;

	private static NGUIDebug mInstance;

	public static void Log(string text)
	{
	}

	public static void DrawBounds(Bounds b)
	{
	}

	private void OnGUI()
	{
	}
}
