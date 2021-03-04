using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prime31;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class EtceteraManager : AbstractManager
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000055 RID: 85 RVA: 0x00002110 File Offset: 0x00000310
	// (remove) Token: 0x06000056 RID: 86 RVA: 0x00002114 File Offset: 0x00000314
	public static event Action dismissingViewControllerEvent
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

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000057 RID: 87 RVA: 0x00002118 File Offset: 0x00000318
	// (remove) Token: 0x06000058 RID: 88 RVA: 0x0000211C File Offset: 0x0000031C
	public static event Action imagePickerCancelledEvent
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

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x06000059 RID: 89 RVA: 0x00002120 File Offset: 0x00000320
	// (remove) Token: 0x0600005A RID: 90 RVA: 0x00002124 File Offset: 0x00000324
	public static event Action<string> imagePickerChoseImageEvent
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

	// Token: 0x14000004 RID: 4
	// (add) Token: 0x0600005B RID: 91 RVA: 0x00002128 File Offset: 0x00000328
	// (remove) Token: 0x0600005C RID: 92 RVA: 0x0000212C File Offset: 0x0000032C
	public static event Action saveImageToPhotoAlbumSucceededEvent
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

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x0600005D RID: 93 RVA: 0x00002130 File Offset: 0x00000330
	// (remove) Token: 0x0600005E RID: 94 RVA: 0x00002134 File Offset: 0x00000334
	public static event Action<string> saveImageToPhotoAlbumFailedEvent
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

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x0600005F RID: 95 RVA: 0x00002138 File Offset: 0x00000338
	// (remove) Token: 0x06000060 RID: 96 RVA: 0x0000213C File Offset: 0x0000033C
	public static event Action<string> alertButtonClickedEvent
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

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000061 RID: 97 RVA: 0x00002140 File Offset: 0x00000340
	// (remove) Token: 0x06000062 RID: 98 RVA: 0x00002144 File Offset: 0x00000344
	public static event Action promptCancelledEvent
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

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x06000063 RID: 99 RVA: 0x00002148 File Offset: 0x00000348
	// (remove) Token: 0x06000064 RID: 100 RVA: 0x0000214C File Offset: 0x0000034C
	public static event Action<string> singleFieldPromptTextEnteredEvent
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

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x06000065 RID: 101 RVA: 0x00002150 File Offset: 0x00000350
	// (remove) Token: 0x06000066 RID: 102 RVA: 0x00002154 File Offset: 0x00000354
	public static event Action<string, string> twoFieldPromptTextEnteredEvent
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

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x06000067 RID: 103 RVA: 0x00002158 File Offset: 0x00000358
	// (remove) Token: 0x06000068 RID: 104 RVA: 0x0000215C File Offset: 0x0000035C
	public static event Action<string> remoteRegistrationSucceededEvent
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

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x06000069 RID: 105 RVA: 0x00002160 File Offset: 0x00000360
	// (remove) Token: 0x0600006A RID: 106 RVA: 0x00002164 File Offset: 0x00000364
	public static event Action<string> remoteRegistrationFailedEvent
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

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x0600006B RID: 107 RVA: 0x00002168 File Offset: 0x00000368
	// (remove) Token: 0x0600006C RID: 108 RVA: 0x0000216C File Offset: 0x0000036C
	public static event Action urbanAirshipRegistrationSucceededEvent
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

	// Token: 0x1400000D RID: 13
	// (add) Token: 0x0600006D RID: 109 RVA: 0x00002170 File Offset: 0x00000370
	// (remove) Token: 0x0600006E RID: 110 RVA: 0x00002174 File Offset: 0x00000374
	public static event Action<string> urbanAirshipRegistrationFailedEvent
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

	// Token: 0x1400000E RID: 14
	// (add) Token: 0x0600006F RID: 111 RVA: 0x00002178 File Offset: 0x00000378
	// (remove) Token: 0x06000070 RID: 112 RVA: 0x0000217C File Offset: 0x0000037C
	public static event Action<string> pushIORegistrationCompletedEvent
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

	// Token: 0x1400000F RID: 15
	// (add) Token: 0x06000071 RID: 113 RVA: 0x00002180 File Offset: 0x00000380
	// (remove) Token: 0x06000072 RID: 114 RVA: 0x00002184 File Offset: 0x00000384
	public static event Action<IDictionary> remoteNotificationReceivedEvent
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

	// Token: 0x14000010 RID: 16
	// (add) Token: 0x06000073 RID: 115 RVA: 0x00002188 File Offset: 0x00000388
	// (remove) Token: 0x06000074 RID: 116 RVA: 0x0000218C File Offset: 0x0000038C
	public static event Action<IDictionary> remoteNotificationReceivedAtLaunchEvent
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

	// Token: 0x14000011 RID: 17
	// (add) Token: 0x06000075 RID: 117 RVA: 0x00002190 File Offset: 0x00000390
	// (remove) Token: 0x06000076 RID: 118 RVA: 0x00002194 File Offset: 0x00000394
	public static event Action<IDictionary> localNotificationWasReceivedEvent
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

	// Token: 0x14000012 RID: 18
	// (add) Token: 0x06000077 RID: 119 RVA: 0x00002198 File Offset: 0x00000398
	// (remove) Token: 0x06000078 RID: 120 RVA: 0x0000219C File Offset: 0x0000039C
	public static event Action<IDictionary> localNotificationWasReceivedAtLaunchEvent
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

	// Token: 0x14000013 RID: 19
	// (add) Token: 0x06000079 RID: 121 RVA: 0x000021A0 File Offset: 0x000003A0
	// (remove) Token: 0x0600007A RID: 122 RVA: 0x000021A4 File Offset: 0x000003A4
	public static event Action<string> mailComposerFinishedEvent
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

	// Token: 0x14000014 RID: 20
	// (add) Token: 0x0600007B RID: 123 RVA: 0x000021A8 File Offset: 0x000003A8
	// (remove) Token: 0x0600007C RID: 124 RVA: 0x000021AC File Offset: 0x000003AC
	public static event Action<string> smsComposerFinishedEvent
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

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600007D RID: 125 RVA: 0x000021B0 File Offset: 0x000003B0
	// (set) Token: 0x0600007E RID: 126 RVA: 0x000021B4 File Offset: 0x000003B4
	public static string deviceToken
	{
		[CompilerGenerated]
		get
		{
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x0600007F RID: 127 RVA: 0x000021B8 File Offset: 0x000003B8
	public void dismissingViewController()
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000021BC File Offset: 0x000003BC
	public void imagePickerDidCancel(string empty)
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000021C0 File Offset: 0x000003C0
	public void imageSavedToDocuments(string filePath)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x000021C4 File Offset: 0x000003C4
	public void saveImageToPhotoAlbumFailed(string error)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000021C8 File Offset: 0x000003C8
	public void saveImageToPhotoAlbumSucceeded(string empty)
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000021CC File Offset: 0x000003CC
	[DebuggerHidden]
	public static IEnumerator textureFromFileAtPath(string filePath, EtceteraManager.EceteraTextureDelegate del, EtceteraManager.EceteraTextureFailedDelegate errorDel)
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x000021D0 File Offset: 0x000003D0
	public void alertViewClickedButton(string buttonTitle)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000021D4 File Offset: 0x000003D4
	public void alertPromptCancelled(string empty)
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x000021D8 File Offset: 0x000003D8
	public void alertPromptEnteredText(string text)
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x000021DC File Offset: 0x000003DC
	public void remoteRegistrationDidSucceed(string deviceToken)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000021E0 File Offset: 0x000003E0
	[DebuggerHidden]
	private IEnumerator registerDeviceWithPushIO()
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x000021E4 File Offset: 0x000003E4
	public void remoteRegistrationDidFail(string error)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000021E8 File Offset: 0x000003E8
	public void urbanAirshipRegistrationDidSucceed(string empty)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000021EC File Offset: 0x000003EC
	public void urbanAirshipRegistrationDidFail(string error)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000021F0 File Offset: 0x000003F0
	public void remoteNotificationWasReceived(string json)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000021F4 File Offset: 0x000003F4
	public void remoteNotificationWasReceivedAtLaunch(string json)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x000021F8 File Offset: 0x000003F8
	public void localNotificationWasReceived(string json)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000021FC File Offset: 0x000003FC
	public void localNotificationWasReceivedAtLaunch(string json)
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002200 File Offset: 0x00000400
	public void mailComposerFinishedWithResult(string result)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002204 File Offset: 0x00000404
	public void smsComposerFinishedWithResult(string result)
	{
	}

	// Token: 0x0400000F RID: 15
	public static string pushIOApiKey;

	// Token: 0x04000010 RID: 16
	public static string[] pushIOCategories;

	// Token: 0x02000032 RID: 50
	// (Invoke) Token: 0x06000338 RID: 824
	public delegate void EceteraTextureDelegate(Texture2D texture);

	// Token: 0x02000033 RID: 51
	// (Invoke) Token: 0x0600033C RID: 828
	public delegate void EceteraTextureFailedDelegate(string error);
}
