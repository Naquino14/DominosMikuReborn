using System;
using UnityEngine;

// Token: 0x02000110 RID: 272
public class CacheController : MonoBehaviour
{
	// Token: 0x0600082D RID: 2093 RVA: 0x00003BB0 File Offset: 0x00001DB0
	public void MakeMikuCache(GameObject go)
	{
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x00003BB4 File Offset: 0x00001DB4
	public void MakeMiku2Cache(GameObject go)
	{
	}

	// Token: 0x0600082F RID: 2095 RVA: 0x00003BB8 File Offset: 0x00001DB8
	public void MakeNekoCache(GameObject go)
	{
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x00003BBC File Offset: 0x00001DBC
	private GameObject MakeObjectCache(GameObject go)
	{
	}

	// Token: 0x0400052D RID: 1325
	[HideInInspector]
	public GameObject mikuPrefab;

	// Token: 0x0400052E RID: 1326
	[HideInInspector]
	public GameObject nekoPrefab;

	// Token: 0x0400052F RID: 1327
	[HideInInspector]
	public GameObject miku2Prefab;

	// Token: 0x04000530 RID: 1328
	[HideInInspector]
	public GameObject neko2Prefab;
}
