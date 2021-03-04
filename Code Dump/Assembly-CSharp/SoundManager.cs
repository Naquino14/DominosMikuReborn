using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class SoundManager : ASoundManager
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600001D RID: 29 RVA: 0x000020C0 File Offset: 0x000002C0
	public static SoundManager Instance
	{
		get
		{
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000020C4 File Offset: 0x000002C4
	protected override void Awake()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000020C8 File Offset: 0x000002C8
	public void Play(string name)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000020CC File Offset: 0x000002CC
	public void PlayBGM(string name)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000020D0 File Offset: 0x000002D0
	public void PlayBGMNoLoop(string name)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000020D4 File Offset: 0x000002D4
	public void PlayBGMCommon(string name)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000020D8 File Offset: 0x000002D8
	public void StopBGM()
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000020DC File Offset: 0x000002DC
	public bool IsPlaying()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000020E0 File Offset: 0x000002E0
	protected override void OnMute()
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000020E4 File Offset: 0x000002E4
	protected override void OnUnmute()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000020E8 File Offset: 0x000002E8
	public void SetMuteInGame()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000020EC File Offset: 0x000002EC
	public void SetUnmuteInGame()
	{
	}

	// Token: 0x04000007 RID: 7
	public AudioClip[] commonAudioClips;

	// Token: 0x04000008 RID: 8
	private Dictionary<string, AudioClip> audioDict;

	// Token: 0x04000009 RID: 9
	private static bool isMuteDevice;

	// Token: 0x0400000A RID: 10
	private static bool isMuteInGame;

	// Token: 0x0400000B RID: 11
	private static string currentBGM;

	// Token: 0x0400000C RID: 12
	private static SoundManager instance;
}
