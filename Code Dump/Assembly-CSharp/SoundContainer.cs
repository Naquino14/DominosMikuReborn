using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000003 RID: 3
public class SoundContainer : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000006 RID: 6 RVA: 0x00002064 File Offset: 0x00000264
	public static SoundContainer Instance
	{
		get
		{
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
	private void Awake()
	{
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000206C File Offset: 0x0000026C
	public void Add(AudioClip audioClip)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002070 File Offset: 0x00000270
	public void Refresh()
	{
	}

	// Token: 0x04000001 RID: 1
	public List<AudioClip> audioClips;

	// Token: 0x04000002 RID: 2
	public Dictionary<string, AudioClip> audioDict;

	// Token: 0x04000003 RID: 3
	private static SoundContainer instance;
}
