using System.Collections.Generic;
using UnityEngine;

public class SoundManager : ASoundManager
{
	public AudioClip[] commonAudioClips;

	private Dictionary<string, AudioClip> audioDict;

	private static bool isMuteDevice;

	private static bool isMuteInGame;

	private static string currentBGM;

	private static SoundManager instance;

	public static SoundManager Instance => (SoundManager)/*Error near IL_0001: Stack underflow*/;

	protected override void Awake()
	{
	}

	public void Play(string name)
	{
	}

	public void PlayBGM(string name)
	{
	}

	public void PlayBGMNoLoop(string name)
	{
	}

	public void PlayBGMCommon(string name)
	{
	}

	public void StopBGM()
	{
	}

	public bool IsPlaying()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	protected override void OnMute()
	{
	}

	protected override void OnUnmute()
	{
	}

	public void SetMuteInGame()
	{
	}

	public void SetUnmuteInGame()
	{
	}
}
