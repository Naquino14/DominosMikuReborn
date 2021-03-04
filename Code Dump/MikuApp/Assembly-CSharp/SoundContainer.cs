using System.Collections.Generic;
using UnityEngine;

public class SoundContainer : MonoBehaviour
{
	public List<AudioClip> audioClips;

	public Dictionary<string, AudioClip> audioDict;

	private static SoundContainer instance;

	public static SoundContainer Instance => (SoundContainer)/*Error near IL_0001: Stack underflow*/;

	private void Awake()
	{
	}

	public void Add(AudioClip audioClip)
	{
	}

	public void Refresh()
	{
	}
}
