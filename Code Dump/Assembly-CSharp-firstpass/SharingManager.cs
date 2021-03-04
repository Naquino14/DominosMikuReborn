using System;
using System.Runtime.CompilerServices;
using Prime31;

// Token: 0x02000025 RID: 37
public class SharingManager : AbstractManager
{
	// Token: 0x14000023 RID: 35
	// (add) Token: 0x06000265 RID: 613 RVA: 0x000028A8 File Offset: 0x00000AA8
	// (remove) Token: 0x06000266 RID: 614 RVA: 0x000028AC File Offset: 0x00000AAC
	public static event Action<string> sharingFinishedWithActivityTypeEvent
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

	// Token: 0x14000024 RID: 36
	// (add) Token: 0x06000267 RID: 615 RVA: 0x000028B0 File Offset: 0x00000AB0
	// (remove) Token: 0x06000268 RID: 616 RVA: 0x000028B4 File Offset: 0x00000AB4
	public static event Action sharingCancelledEvent
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

	// Token: 0x06000269 RID: 617 RVA: 0x000028B8 File Offset: 0x00000AB8
	private void sharingFinishedWithActivityType(string activityType)
	{
	}

	// Token: 0x0600026A RID: 618 RVA: 0x000028BC File Offset: 0x00000ABC
	private void sharingCancelled(string empty)
	{
	}
}
