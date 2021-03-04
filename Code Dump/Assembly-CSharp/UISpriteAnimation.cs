using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000078 RID: 120
[ExecuteInEditMode]
[RequireComponent(typeof(UISprite))]
[AddComponentMenu("NGUI/UI/Sprite Animation")]
public class UISpriteAnimation : MonoBehaviour
{
	// Token: 0x1700009A RID: 154
	// (get) Token: 0x0600037E RID: 894 RVA: 0x00002E40 File Offset: 0x00001040
	public int frames
	{
		get
		{
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x0600037F RID: 895 RVA: 0x00002E44 File Offset: 0x00001044
	// (set) Token: 0x06000380 RID: 896 RVA: 0x00002E48 File Offset: 0x00001048
	public int framesPerSecond
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000381 RID: 897 RVA: 0x00002E4C File Offset: 0x0000104C
	// (set) Token: 0x06000382 RID: 898 RVA: 0x00002E50 File Offset: 0x00001050
	public string namePrefix
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000383 RID: 899 RVA: 0x00002E54 File Offset: 0x00001054
	// (set) Token: 0x06000384 RID: 900 RVA: 0x00002E58 File Offset: 0x00001058
	public bool loop
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000385 RID: 901 RVA: 0x00002E5C File Offset: 0x0000105C
	public bool isPlaying
	{
		get
		{
		}
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00002E60 File Offset: 0x00001060
	private void Start()
	{
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002E64 File Offset: 0x00001064
	private void Update()
	{
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00002E68 File Offset: 0x00001068
	private void RebuildSpriteList()
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00002E6C File Offset: 0x0000106C
	public void Reset()
	{
	}

	// Token: 0x04000337 RID: 823
	[HideInInspector]
	[SerializeField]
	private int mFPS;

	// Token: 0x04000338 RID: 824
	[HideInInspector]
	[SerializeField]
	private string mPrefix;

	// Token: 0x04000339 RID: 825
	[SerializeField]
	[HideInInspector]
	private bool mLoop;

	// Token: 0x0400033A RID: 826
	private UISprite mSprite;

	// Token: 0x0400033B RID: 827
	private float mDelta;

	// Token: 0x0400033C RID: 828
	private int mIndex;

	// Token: 0x0400033D RID: 829
	private bool mActive;

	// Token: 0x0400033E RID: 830
	private List<string> mSpriteNames;
}
