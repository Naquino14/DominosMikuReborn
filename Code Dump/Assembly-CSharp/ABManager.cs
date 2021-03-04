using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class ABManager : MonoBehaviour
{
	// Token: 0x06000037 RID: 55 RVA: 0x00002128 File Offset: 0x00000328
	private void Awake()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0000212C File Offset: 0x0000032C
	protected void Init()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002130 File Offset: 0x00000330
	protected void SetServer()
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600003A RID: 58 RVA: 0x00002134 File Offset: 0x00000334
	public static ABManager Instance
	{
		get
		{
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600003B RID: 59 RVA: 0x00002138 File Offset: 0x00000338
	// (set) Token: 0x0600003C RID: 60 RVA: 0x0000213C File Offset: 0x0000033C
	public bool Downloading
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002140 File Offset: 0x00000340
	private void SetTotal(int total)
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002144 File Offset: 0x00000344
	public float GetProgress()
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002148 File Offset: 0x00000348
	public string GetStringProgress()
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000214C File Offset: 0x0000034C
	public bool ContainsItem(string item)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002150 File Offset: 0x00000350
	public UnityEngine.Object GetItem(string item)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002154 File Offset: 0x00000354
	public UnityEngine.Object GetItemChild(string item, string name)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002158 File Offset: 0x00000358
	[DebuggerHidden]
	public IEnumerator Download(List<string> stringList)
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000215C File Offset: 0x0000035C
	[DebuggerHidden]
	public IEnumerator Download(string[] stringList)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002160 File Offset: 0x00000360
	[DebuggerHidden]
	public IEnumerator Download(string str)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002164 File Offset: 0x00000364
	[DebuggerHidden]
	public IEnumerator DownloadAbsolutely(string str)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002168 File Offset: 0x00000368
	public void FreeAllAssets()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000216C File Offset: 0x0000036C
	public void FreeAsset(string item)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002170 File Offset: 0x00000370
	public void FreeAssets(List<string> items)
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002174 File Offset: 0x00000374
	public void FreeAssets(string[] items)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002178 File Offset: 0x00000378
	public bool IsDownloaded(string str)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000217C File Offset: 0x0000037C
	private void SetUrl(string str)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002180 File Offset: 0x00000380
	private void LoadItemsBegin(string str)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002184 File Offset: 0x00000384
	private void LoadItemsEnd(string str)
	{
	}

	// Token: 0x04000016 RID: 22
	public static bool UseAssetBundleCache;

	// Token: 0x04000017 RID: 23
	public ABManager.ABServer aBServer;

	// Token: 0x04000018 RID: 24
	public int assetVersion;

	// Token: 0x04000019 RID: 25
	public string domain;

	// Token: 0x0400001A RID: 26
	public string domainTest;

	// Token: 0x0400001B RID: 27
	public string domainDevPreview;

	// Token: 0x0400001C RID: 28
	public string domainDev;

	// Token: 0x0400001D RID: 29
	private Dictionary<string, AssetBundle> assetBundleList;

	// Token: 0x0400001E RID: 30
	private static ABManager instance;

	// Token: 0x0400001F RID: 31
	private AssetBundle assetBundle;

	// Token: 0x04000020 RID: 32
	private WWW downloadWWW;

	// Token: 0x04000021 RID: 33
	private string url;

	// Token: 0x04000022 RID: 34
	private int countLoaded;

	// Token: 0x04000023 RID: 35
	private int totalLoad;

	// Token: 0x04000024 RID: 36
	private bool downloading;

	// Token: 0x04000025 RID: 37
	private string currentDomain;

	// Token: 0x0200000A RID: 10
	public enum ABServer
	{
		// Token: 0x04000027 RID: 39
		RELEASE,
		// Token: 0x04000028 RID: 40
		DEV,
		// Token: 0x04000029 RID: 41
		DEV_PREVIEW,
		// Token: 0x0400002A RID: 42
		DOMINO_TEST
	}
}
