using System;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class SoundTools
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600000C RID: 12 RVA: 0x0000207C File Offset: 0x0000027C
	// (set) Token: 0x0600000D RID: 13 RVA: 0x00002080 File Offset: 0x00000280
	public static float soundVolume
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002084 File Offset: 0x00000284
	public static AudioSource PlaySound(AudioClip clip)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002088 File Offset: 0x00000288
	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000208C File Offset: 0x0000028C
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002090 File Offset: 0x00000290
	public static AudioSource PlayBGM(AudioClip clip, bool loop)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002094 File Offset: 0x00000294
	public static AudioSource PlayBGM(AudioClip clip, float volume, bool loop)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002098 File Offset: 0x00000298
	public static AudioSource PlayBGM(AudioClip clip, float volume, float pitch, bool loop)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000209C File Offset: 0x0000029C
	public static void StopBGM()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000020A0 File Offset: 0x000002A0
	public static void PauseBGM()
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000020A4 File Offset: 0x000002A4
	public static void ResumeBGM()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000020A8 File Offset: 0x000002A8
	public static bool isPlaying()
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000020AC File Offset: 0x000002AC
	public static float Percent()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000020B0 File Offset: 0x000002B0
	public static float TimePlay()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000020B4 File Offset: 0x000002B4
	public static float Seek(float percent)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000020B8 File Offset: 0x000002B8
	public static float Length()
	{
	}

	// Token: 0x04000004 RID: 4
	private static AudioListener mListener;

	// Token: 0x04000005 RID: 5
	private static bool mLoaded;

	// Token: 0x04000006 RID: 6
	private static float mGlobalVolume;
}
