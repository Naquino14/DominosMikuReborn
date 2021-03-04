using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UISprite))]
[AddComponentMenu("NGUI/UI/Sprite Animation")]
public class UISpriteAnimation : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	private int mFPS;

	[HideInInspector]
	[SerializeField]
	private string mPrefix;

	[SerializeField]
	[HideInInspector]
	private bool mLoop;

	private UISprite mSprite;

	private float mDelta;

	private int mIndex;

	private bool mActive;

	private List<string> mSpriteNames;

	public int frames => (int)/*Error near IL_0001: Stack underflow*/;

	public int framesPerSecond
	{
		get
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public string namePrefix
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public bool loop
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public bool isPlaying => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RebuildSpriteList()
	{
	}

	public void Reset()
	{
	}
}
