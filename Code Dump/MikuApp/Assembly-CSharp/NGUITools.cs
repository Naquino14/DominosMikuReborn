using System.Collections.Generic;
using UnityEngine;

public static class NGUITools
{
	private static AudioListener mListener;

	private static bool mLoaded;

	private static float mGlobalVolume;

	public static float soundVolume
	{
		get
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public static bool fileAccess => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public static AudioSource PlaySound(AudioClip clip)
	{
		return (AudioSource)/*Error near IL_0001: Stack underflow*/;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return (AudioSource)/*Error near IL_0001: Stack underflow*/;
	}

	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return (AudioSource)/*Error near IL_0001: Stack underflow*/;
	}

	public static WWW OpenURL(string url)
	{
		return (WWW)/*Error near IL_0001: Stack underflow*/;
	}

	public static WWW OpenURL(string url, WWWForm form)
	{
		return (WWW)/*Error near IL_0001: Stack underflow*/;
	}

	public static int RandomRange(int min, int max)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static string GetHierarchy(GameObject obj)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public static Color ParseColor(string text, int offset)
	{
		return (Color)/*Error near IL_0001: Stack underflow*/;
	}

	public static string EncodeColor(Color c)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public static int ParseSymbol(string text, int index, List<Color> colors)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static string StripSymbols(string text)
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public static T[] FindActive<T>() where T : Component
	{
		return (T[])/*Error near IL_0001: Stack underflow*/;
	}

	public static Camera FindCameraForLayer(int layer)
	{
		return (Camera)/*Error near IL_0001: Stack underflow*/;
	}

	public static BoxCollider AddWidgetCollider(GameObject go)
	{
		return (BoxCollider)/*Error near IL_0001: Stack underflow*/;
	}

	public static string GetName<T>() where T : Component
	{
		return (string)/*Error near IL_0001: Stack underflow*/;
	}

	public static GameObject AddChild(GameObject parent)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		return (GameObject)/*Error near IL_0001: Stack underflow*/;
	}

	public static int CalculateNextDepth(GameObject go)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public static T AddChild<T>(GameObject parent) where T : Component
	{
		return (T)/*Error near IL_0001: Stack underflow*/;
	}

	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		return (T)/*Error near IL_0001: Stack underflow*/;
	}

	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		return (UISprite)/*Error near IL_0001: Stack underflow*/;
	}

	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return (T)/*Error near IL_0001: Stack underflow*/;
	}

	public static void Destroy(Object obj)
	{
	}

	public static void DestroyImmediate(Object obj)
	{
	}

	public static void Broadcast(string funcName)
	{
	}

	public static void Broadcast(string funcName, object param)
	{
	}

	public static bool IsChild(Transform parent, Transform child)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private static void Activate(Transform t)
	{
	}

	private static void Deactivate(Transform t)
	{
	}

	public static void SetActive(GameObject go, bool state)
	{
	}

	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	public static bool GetActive(GameObject go)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	public static void SetLayer(GameObject go, int layer)
	{
	}

	public static Vector3 Round(Vector3 v)
	{
		return (Vector3)/*Error near IL_0001: Stack underflow*/;
	}

	public static void MakePixelPerfect(Transform t)
	{
	}

	public static bool Save(string fileName, byte[] bytes)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static byte[] Load(string fileName)
	{
		return (byte[])/*Error near IL_0001: Stack underflow*/;
	}
}
