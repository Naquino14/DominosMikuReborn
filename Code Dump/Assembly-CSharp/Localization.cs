using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000043 RID: 67
[AddComponentMenu("NGUI/Internal/Localization")]
public class Localization : MonoBehaviour
{
	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600018F RID: 399 RVA: 0x00002688 File Offset: 0x00000888
	public static Localization instance
	{
		get
		{
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000190 RID: 400 RVA: 0x0000268C File Offset: 0x0000088C
	// (set) Token: 0x06000191 RID: 401 RVA: 0x00002690 File Offset: 0x00000890
	public string currentLanguage
	{
		get
		{
		}
		set
		{
		}
	}

	// Token: 0x06000192 RID: 402 RVA: 0x00002694 File Offset: 0x00000894
	private void Awake()
	{
	}

	// Token: 0x06000193 RID: 403 RVA: 0x00002698 File Offset: 0x00000898
	private void Start()
	{
	}

	// Token: 0x06000194 RID: 404 RVA: 0x0000269C File Offset: 0x0000089C
	private void OnEnable()
	{
	}

	// Token: 0x06000195 RID: 405 RVA: 0x000026A0 File Offset: 0x000008A0
	private void OnDestroy()
	{
	}

	// Token: 0x06000196 RID: 406 RVA: 0x000026A4 File Offset: 0x000008A4
	private void Load(TextAsset asset)
	{
	}

	// Token: 0x06000197 RID: 407 RVA: 0x000026A8 File Offset: 0x000008A8
	public string Get(string key)
	{
	}

	// Token: 0x040001A0 RID: 416
	private static Localization mInst;

	// Token: 0x040001A1 RID: 417
	public string startingLanguage;

	// Token: 0x040001A2 RID: 418
	public TextAsset[] languages;

	// Token: 0x040001A3 RID: 419
	private Dictionary<string, string> mDictionary;

	// Token: 0x040001A4 RID: 420
	private string mLanguage;
}
