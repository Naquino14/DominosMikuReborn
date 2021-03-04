using System;
using UnityEngine;

// Token: 0x02000134 RID: 308
public class ShareController : MonoBehaviour
{
	// Token: 0x060009FA RID: 2554 RVA: 0x000042E4 File Offset: 0x000024E4
	protected virtual void PostFb()
	{
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x000042E8 File Offset: 0x000024E8
	protected virtual void PostTw()
	{
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x000042EC File Offset: 0x000024EC
	private void Start()
	{
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x000042F0 File Offset: 0x000024F0
	private void OnEnable()
	{
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x000042F4 File Offset: 0x000024F4
	private void OnDisable()
	{
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x000042F8 File Offset: 0x000024F8
	protected void PostFacebook()
	{
	}

	// Token: 0x06000A00 RID: 2560 RVA: 0x000042FC File Offset: 0x000024FC
	private void sessionOpenedEvent()
	{
	}

	// Token: 0x06000A01 RID: 2561 RVA: 0x00004300 File Offset: 0x00002500
	protected void completionHandler(string error, object result)
	{
	}

	// Token: 0x06000A02 RID: 2562 RVA: 0x00004304 File Offset: 0x00002504
	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	// Token: 0x06000A03 RID: 2563 RVA: 0x00004308 File Offset: 0x00002508
	protected void PostTwitter()
	{
	}

	// Token: 0x06000A04 RID: 2564 RVA: 0x0000430C File Offset: 0x0000250C
	private void loginSucceeded()
	{
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00004310 File Offset: 0x00002510
	private void postSucceeded()
	{
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00004314 File Offset: 0x00002514
	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}

	// Token: 0x0400067F RID: 1663
	private const string CONSUMER_KEY = "CwZvon4BKdGa1krWRM6ubw";

	// Token: 0x04000680 RID: 1664
	private const string CONSUMER_SECRET = "aHRTcazIIITnGCOvlq0s9F9X8tTphRv1wwPH9rKAyuI";
}
