using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Prime31;

// Token: 0x02000023 RID: 35
public class FacebookManager : AbstractManager
{
	// Token: 0x14000015 RID: 21
	// (add) Token: 0x06000236 RID: 566 RVA: 0x000027F0 File Offset: 0x000009F0
	// (remove) Token: 0x06000237 RID: 567 RVA: 0x000027F4 File Offset: 0x000009F4
	public static event Action sessionOpenedEvent
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

	// Token: 0x14000016 RID: 22
	// (add) Token: 0x06000238 RID: 568 RVA: 0x000027F8 File Offset: 0x000009F8
	// (remove) Token: 0x06000239 RID: 569 RVA: 0x000027FC File Offset: 0x000009FC
	public static event Action preLoginSucceededEvent
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

	// Token: 0x14000017 RID: 23
	// (add) Token: 0x0600023A RID: 570 RVA: 0x00002800 File Offset: 0x00000A00
	// (remove) Token: 0x0600023B RID: 571 RVA: 0x00002804 File Offset: 0x00000A04
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

	// Token: 0x14000018 RID: 24
	// (add) Token: 0x0600023C RID: 572 RVA: 0x00002808 File Offset: 0x00000A08
	// (remove) Token: 0x0600023D RID: 573 RVA: 0x0000280C File Offset: 0x00000A0C
	public static event Action<string> dialogCompletedWithUrlEvent
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

	// Token: 0x14000019 RID: 25
	// (add) Token: 0x0600023E RID: 574 RVA: 0x00002810 File Offset: 0x00000A10
	// (remove) Token: 0x0600023F RID: 575 RVA: 0x00002814 File Offset: 0x00000A14
	public static event Action<string> dialogFailedEvent
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

	// Token: 0x1400001A RID: 26
	// (add) Token: 0x06000240 RID: 576 RVA: 0x00002818 File Offset: 0x00000A18
	// (remove) Token: 0x06000241 RID: 577 RVA: 0x0000281C File Offset: 0x00000A1C
	public static event Action<object> graphRequestCompletedEvent
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

	// Token: 0x1400001B RID: 27
	// (add) Token: 0x06000242 RID: 578 RVA: 0x00002820 File Offset: 0x00000A20
	// (remove) Token: 0x06000243 RID: 579 RVA: 0x00002824 File Offset: 0x00000A24
	public static event Action<string> graphRequestFailedEvent
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

	// Token: 0x1400001C RID: 28
	// (add) Token: 0x06000244 RID: 580 RVA: 0x00002828 File Offset: 0x00000A28
	// (remove) Token: 0x06000245 RID: 581 RVA: 0x0000282C File Offset: 0x00000A2C
	public static event Action<object> restRequestCompletedEvent
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

	// Token: 0x1400001D RID: 29
	// (add) Token: 0x06000246 RID: 582 RVA: 0x00002830 File Offset: 0x00000A30
	// (remove) Token: 0x06000247 RID: 583 RVA: 0x00002834 File Offset: 0x00000A34
	public static event Action<string> restRequestFailedEvent
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

	// Token: 0x1400001E RID: 30
	// (add) Token: 0x06000248 RID: 584 RVA: 0x00002838 File Offset: 0x00000A38
	// (remove) Token: 0x06000249 RID: 585 RVA: 0x0000283C File Offset: 0x00000A3C
	public static event Action<bool> facebookComposerCompletedEvent
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

	// Token: 0x1400001F RID: 31
	// (add) Token: 0x0600024A RID: 586 RVA: 0x00002840 File Offset: 0x00000A40
	// (remove) Token: 0x0600024B RID: 587 RVA: 0x00002844 File Offset: 0x00000A44
	public static event Action reauthorizationSucceededEvent
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

	// Token: 0x14000020 RID: 32
	// (add) Token: 0x0600024C RID: 588 RVA: 0x00002848 File Offset: 0x00000A48
	// (remove) Token: 0x0600024D RID: 589 RVA: 0x0000284C File Offset: 0x00000A4C
	public static event Action<string> reauthorizationFailedEvent
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

	// Token: 0x14000021 RID: 33
	// (add) Token: 0x0600024E RID: 590 RVA: 0x00002850 File Offset: 0x00000A50
	// (remove) Token: 0x0600024F RID: 591 RVA: 0x00002854 File Offset: 0x00000A54
	public static event Action<string> shareDialogFailedEvent
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

	// Token: 0x14000022 RID: 34
	// (add) Token: 0x06000250 RID: 592 RVA: 0x00002858 File Offset: 0x00000A58
	// (remove) Token: 0x06000251 RID: 593 RVA: 0x0000285C File Offset: 0x00000A5C
	public static event Action<Dictionary<string, object>> shareDialogSucceededEvent
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

	// Token: 0x06000252 RID: 594 RVA: 0x00002860 File Offset: 0x00000A60
	public void sessionOpened(string accessToken)
	{
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002864 File Offset: 0x00000A64
	public void loginFailed(string error)
	{
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00002868 File Offset: 0x00000A68
	public void dialogCompletedWithUrl(string url)
	{
	}

	// Token: 0x06000255 RID: 597 RVA: 0x0000286C File Offset: 0x00000A6C
	public void dialogFailedWithError(string error)
	{
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002870 File Offset: 0x00000A70
	public void graphRequestCompleted(string json)
	{
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002874 File Offset: 0x00000A74
	public void graphRequestFailed(string error)
	{
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00002878 File Offset: 0x00000A78
	public void restRequestCompleted(string json)
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x0000287C File Offset: 0x00000A7C
	public void restRequestFailed(string error)
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00002880 File Offset: 0x00000A80
	public void facebookComposerCompleted(string result)
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002884 File Offset: 0x00000A84
	public void reauthorizationSucceeded(string empty)
	{
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00002888 File Offset: 0x00000A88
	public void reauthorizationFailed(string error)
	{
	}

	// Token: 0x0600025D RID: 605 RVA: 0x0000288C File Offset: 0x00000A8C
	public void shareDialogFailed(string error)
	{
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002890 File Offset: 0x00000A90
	public void shareDialogSucceeded(string json)
	{
	}
}
