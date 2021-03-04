using System;
using System.Collections;
using System.Collections.Generic;
using Prime31;
using UnityEngine;

// Token: 0x02000020 RID: 32
public class Facebook : P31RestKit
{
	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600020E RID: 526 RVA: 0x00002750 File Offset: 0x00000950
	public static Facebook instance
	{
		get
		{
		}
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002754 File Offset: 0x00000954
	protected override IEnumerator send(string path, HTTPVerb httpVerb, Dictionary<string, object> parameters, Action<string, object> onComplete)
	{
	}

	// Token: 0x06000210 RID: 528 RVA: 0x00002758 File Offset: 0x00000958
	public void prepareForMetroUse(GameObject go, MonoBehaviour mb)
	{
	}

	// Token: 0x06000211 RID: 529 RVA: 0x0000275C File Offset: 0x0000095C
	public void graphRequest(string path, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000212 RID: 530 RVA: 0x00002760 File Offset: 0x00000960
	public void graphRequest(string path, HTTPVerb verb, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002764 File Offset: 0x00000964
	public void graphRequest(string path, HTTPVerb verb, Dictionary<string, object> parameters, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002768 File Offset: 0x00000968
	public void graphRequestBatch(IEnumerable<FacebookBatchRequest> requests, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000215 RID: 533 RVA: 0x0000276C File Offset: 0x0000096C
	public void restRequest(string method, HTTPVerb verb, Dictionary<string, object> parameters, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000216 RID: 534 RVA: 0x00002770 File Offset: 0x00000970
	public void postMessage(string message, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00002774 File Offset: 0x00000974
	public void postMessageWithLink(string message, string link, string linkName, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00002778 File Offset: 0x00000978
	public void postMessageWithLinkAndLinkToImage(string message, string link, string linkName, string linkToImage, string caption, Action<string, object> completionHandler)
	{
	}

	// Token: 0x06000219 RID: 537 RVA: 0x0000277C File Offset: 0x0000097C
	public void postImage(byte[] image, string message, Action<string, object> completionHandler)
	{
	}

	// Token: 0x0600021A RID: 538 RVA: 0x00002780 File Offset: 0x00000980
	public void postImageToAlbum(byte[] image, string caption, string albumId, Action<string, object> completionHandler)
	{
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00002784 File Offset: 0x00000984
	public void getFriends(Action<string, object> completionHandler)
	{
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00002788 File Offset: 0x00000988
	public void extendAccessToken(string appId, string appSecret, Action<DateTime?> completionHandler)
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0000278C File Offset: 0x0000098C
	public void getAppAccessToken(string appId, string appSecret, Action<string> completionHandler)
	{
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00002790 File Offset: 0x00000990
	public void postScore(string userId, int score, Action<bool> completionHandler)
	{
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002794 File Offset: 0x00000994
	public void getScores(string userId, Action<string, object> onComplete)
	{
	}

	// Token: 0x040000D2 RID: 210
	public string accessToken;

	// Token: 0x040000D3 RID: 211
	public string appAccessToken;

	// Token: 0x040000D4 RID: 212
	private static Facebook _instance;
}
