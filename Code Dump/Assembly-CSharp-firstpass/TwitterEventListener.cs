using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000027 RID: 39
public class TwitterEventListener : MonoBehaviour
{
	// Token: 0x06000287 RID: 647 RVA: 0x00002904 File Offset: 0x00000B04
	private void OnEnable()
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002908 File Offset: 0x00000B08
	private void OnDisable()
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0000290C File Offset: 0x00000B0C
	private void loginSucceeded()
	{
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002910 File Offset: 0x00000B10
	private void loginFailed(string error)
	{
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002914 File Offset: 0x00000B14
	private void postSucceeded()
	{
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002918 File Offset: 0x00000B18
	private void postFailed(string error)
	{
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0000291C File Offset: 0x00000B1C
	private void homeTimelineFailed(string error)
	{
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002920 File Offset: 0x00000B20
	private void homeTimelineReceived(List<object> result)
	{
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002924 File Offset: 0x00000B24
	private void requestDidFailEvent(string error)
	{
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002928 File Offset: 0x00000B28
	private void requestDidFinishEvent(object result)
	{
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0000292C File Offset: 0x00000B2C
	private void tweetSheetCompletedEvent(bool didSucceed)
	{
	}
}
