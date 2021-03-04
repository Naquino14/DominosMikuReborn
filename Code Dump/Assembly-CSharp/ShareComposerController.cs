using System;
using UnityEngine;

// Token: 0x02000133 RID: 307
public class ShareComposerController : MonoBehaviour
{
	// Token: 0x060009EC RID: 2540 RVA: 0x000042AC File Offset: 0x000024AC
	protected virtual void AfterLogin()
	{
	}

	// Token: 0x060009ED RID: 2541 RVA: 0x000042B0 File Offset: 0x000024B0
	protected virtual void PostFb()
	{
	}

	// Token: 0x060009EE RID: 2542 RVA: 0x000042B4 File Offset: 0x000024B4
	protected virtual void PostTw()
	{
	}

	// Token: 0x060009EF RID: 2543 RVA: 0x000042B8 File Offset: 0x000024B8
	private void Start()
	{
	}

	// Token: 0x060009F0 RID: 2544 RVA: 0x000042BC File Offset: 0x000024BC
	private void OnEnable()
	{
	}

	// Token: 0x060009F1 RID: 2545 RVA: 0x000042C0 File Offset: 0x000024C0
	private void OnDisable()
	{
	}

	// Token: 0x060009F2 RID: 2546 RVA: 0x000042C4 File Offset: 0x000024C4
	private void OnPostClick(string message)
	{
	}

	// Token: 0x060009F3 RID: 2547 RVA: 0x000042C8 File Offset: 0x000024C8
	protected void PostFacebook()
	{
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x000042CC File Offset: 0x000024CC
	private void sessionOpenedEvent()
	{
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x000042D0 File Offset: 0x000024D0
	protected void completionHandler(string error, object result)
	{
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x000042D4 File Offset: 0x000024D4
	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	// Token: 0x060009F7 RID: 2551 RVA: 0x000042D8 File Offset: 0x000024D8
	protected void PostTwitter()
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x000042DC File Offset: 0x000024DC
	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}

	// Token: 0x0400067B RID: 1659
	private const string CONSUMER_KEY = "CwZvon4BKdGa1krWRM6ubw";

	// Token: 0x0400067C RID: 1660
	private const string CONSUMER_SECRET = "aHRTcazIIITnGCOvlq0s9F9X8tTphRv1wwPH9rKAyuI";

	// Token: 0x0400067D RID: 1661
	private bool _isPostClicked;

	// Token: 0x0400067E RID: 1662
	protected string _fbMessage;
}
