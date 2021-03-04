using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000022 RID: 34
public class FacebookEventListener : MonoBehaviour
{
	// Token: 0x06000224 RID: 548 RVA: 0x000027A8 File Offset: 0x000009A8
	private void OnEnable()
	{
	}

	// Token: 0x06000225 RID: 549 RVA: 0x000027AC File Offset: 0x000009AC
	private void OnDisable()
	{
	}

	// Token: 0x06000226 RID: 550 RVA: 0x000027B0 File Offset: 0x000009B0
	private void sessionOpenedEvent()
	{
	}

	// Token: 0x06000227 RID: 551 RVA: 0x000027B4 File Offset: 0x000009B4
	private void loginFailedEvent(string error)
	{
	}

	// Token: 0x06000228 RID: 552 RVA: 0x000027B8 File Offset: 0x000009B8
	private void dialogCompletedEvent(string url)
	{
	}

	// Token: 0x06000229 RID: 553 RVA: 0x000027BC File Offset: 0x000009BC
	private void dialogFailedEvent(string error)
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x000027C0 File Offset: 0x000009C0
	private void facebokDialogCompleted()
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x000027C4 File Offset: 0x000009C4
	private void graphRequestCompletedEvent(object obj)
	{
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000027C8 File Offset: 0x000009C8
	private void facebookCustomRequestFailed(string error)
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x000027CC File Offset: 0x000009CC
	private void restRequestCompletedEvent(object obj)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x000027D0 File Offset: 0x000009D0
	private void restRequestFailedEvent(string error)
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x000027D4 File Offset: 0x000009D4
	private void facebookComposerCompletedEvent(bool didSucceed)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x000027D8 File Offset: 0x000009D8
	private void reauthorizationSucceededEvent()
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x000027DC File Offset: 0x000009DC
	private void reauthorizationFailedEvent(string error)
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x000027E0 File Offset: 0x000009E0
	private void shareDialogFailedEvent(string error)
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x000027E4 File Offset: 0x000009E4
	private void shareDialogSucceededEvent(Dictionary<string, object> dict)
	{
	}
}
