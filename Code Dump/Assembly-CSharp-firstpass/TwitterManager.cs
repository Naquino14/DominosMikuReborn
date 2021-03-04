using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class TwitterManager : MonoBehaviour
{
	// Token: 0x14000025 RID: 37
	// (add) Token: 0x06000294 RID: 660 RVA: 0x00002938 File Offset: 0x00000B38
	// (remove) Token: 0x06000295 RID: 661 RVA: 0x0000293C File Offset: 0x00000B3C
	public static event Action loginSucceededEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x14000026 RID: 38
	// (add) Token: 0x06000296 RID: 662 RVA: 0x00002940 File Offset: 0x00000B40
	// (remove) Token: 0x06000297 RID: 663 RVA: 0x00002944 File Offset: 0x00000B44
	public static event Action<string> loginFailedEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x14000027 RID: 39
	// (add) Token: 0x06000298 RID: 664 RVA: 0x00002948 File Offset: 0x00000B48
	// (remove) Token: 0x06000299 RID: 665 RVA: 0x0000294C File Offset: 0x00000B4C
	public static event Action postSucceededEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x14000028 RID: 40
	// (add) Token: 0x0600029A RID: 666 RVA: 0x00002950 File Offset: 0x00000B50
	// (remove) Token: 0x0600029B RID: 667 RVA: 0x00002954 File Offset: 0x00000B54
	public static event Action<string> postFailedEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x14000029 RID: 41
	// (add) Token: 0x0600029C RID: 668 RVA: 0x00002958 File Offset: 0x00000B58
	// (remove) Token: 0x0600029D RID: 669 RVA: 0x0000295C File Offset: 0x00000B5C
	public static event Action<List<object>> homeTimelineReceivedEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x1400002A RID: 42
	// (add) Token: 0x0600029E RID: 670 RVA: 0x00002960 File Offset: 0x00000B60
	// (remove) Token: 0x0600029F RID: 671 RVA: 0x00002964 File Offset: 0x00000B64
	public static event Action<string> homeTimelineFailedEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x1400002B RID: 43
	// (add) Token: 0x060002A0 RID: 672 RVA: 0x00002968 File Offset: 0x00000B68
	// (remove) Token: 0x060002A1 RID: 673 RVA: 0x0000296C File Offset: 0x00000B6C
	public static event Action<object> requestDidFinishEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x1400002C RID: 44
	// (add) Token: 0x060002A2 RID: 674 RVA: 0x00002970 File Offset: 0x00000B70
	// (remove) Token: 0x060002A3 RID: 675 RVA: 0x00002974 File Offset: 0x00000B74
	public static event Action<string> requestDidFailEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x1400002D RID: 45
	// (add) Token: 0x060002A4 RID: 676 RVA: 0x00002978 File Offset: 0x00000B78
	// (remove) Token: 0x060002A5 RID: 677 RVA: 0x0000297C File Offset: 0x00000B7C
	public static event Action<bool> tweetSheetCompletedEvent
	{
		[MethodImpl(32)]
		add
		{
		}
		[MethodImpl(32)]
		remove
		{
		}
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002980 File Offset: 0x00000B80
	public void twitterLoginSucceeded(string empty)
	{
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002984 File Offset: 0x00000B84
	public void twitterLoginDidFail(string error)
	{
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002988 File Offset: 0x00000B88
	public void twitterPostSucceeded(string empty)
	{
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0000298C File Offset: 0x00000B8C
	public void twitterPostDidFail(string error)
	{
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00002990 File Offset: 0x00000B90
	public void twitterHomeTimelineDidFail(string error)
	{
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00002994 File Offset: 0x00000B94
	public void twitterHomeTimelineDidFinish(string results)
	{
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00002998 File Offset: 0x00000B98
	public void twitterRequestDidFinish(string results)
	{
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000299C File Offset: 0x00000B9C
	public void twitterRequestDidFail(string error)
	{
	}

	// Token: 0x060002AE RID: 686 RVA: 0x000029A0 File Offset: 0x00000BA0
	public void tweetSheetCompleted(string oneOrZero)
	{
	}
}
