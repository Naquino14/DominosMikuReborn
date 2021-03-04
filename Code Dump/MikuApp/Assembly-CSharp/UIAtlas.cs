using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Atlas")]
public class UIAtlas : MonoBehaviour
{
	[Serializable]
	public class Sprite
	{
		public string name;

		public Rect outer;

		public Rect inner;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding => (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public enum Coordinates
	{
		Pixels,
		TexCoords
	}

	[HideInInspector]
	[SerializeField]
	private Material material;

	[HideInInspector]
	[SerializeField]
	private List<Sprite> sprites;

	[SerializeField]
	[HideInInspector]
	private Coordinates mCoordinates;

	[SerializeField]
	[HideInInspector]
	private float mPixelSize;

	[SerializeField]
	[HideInInspector]
	private UIAtlas mReplacement;

	public Material spriteMaterial
	{
		get
		{
			return (Material)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public List<Sprite> spriteList
	{
		get
		{
			return (List<Sprite>)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Texture texture => (Texture)/*Error near IL_0001: Stack underflow*/;

	public Coordinates coordinates
	{
		get
		{
			return (Coordinates)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public float pixelSize
	{
		get
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public UIAtlas replacement
	{
		get
		{
			return (UIAtlas)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public Sprite GetSprite(string name)
	{
		return (Sprite)/*Error near IL_0001: Stack underflow*/;
	}

	private static int CompareString(string a, string b)
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	public BetterList<string> GetListOfSprites()
	{
		return (BetterList<string>)/*Error near IL_0001: Stack underflow*/;
	}

	public BetterList<string> GetListOfSprites(string match)
	{
		return (BetterList<string>)/*Error near IL_0001: Stack underflow*/;
	}

	private bool References(UIAtlas atlas)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public static bool CheckIfRelated(UIAtlas a, UIAtlas b)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public void MarkAsDirty()
	{
	}
}
