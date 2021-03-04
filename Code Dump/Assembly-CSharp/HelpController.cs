using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000131 RID: 305
public class HelpController : MonoBehaviour
{
	// Token: 0x1400000E RID: 14
	// (add) Token: 0x060009D9 RID: 2521 RVA: 0x00004260 File Offset: 0x00002460
	// (remove) Token: 0x060009DA RID: 2522 RVA: 0x00004264 File Offset: 0x00002464
	public event Action onClose
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

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x060009DB RID: 2523 RVA: 0x00004268 File Offset: 0x00002468
	public static HelpController Instance
	{
		get
		{
		}
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x0000426C File Offset: 0x0000246C
	private void Awake()
	{
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00004270 File Offset: 0x00002470
	private void OnDestroy()
	{
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00004274 File Offset: 0x00002474
	private void Update()
	{
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00004278 File Offset: 0x00002478
	private void OnCloseClick()
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x0000427C File Offset: 0x0000247C
	private void DestroyScene()
	{
	}

	// Token: 0x04000674 RID: 1652
	public GameObject _root;

	// Token: 0x04000675 RID: 1653
	private bool _isInited;

	// Token: 0x04000676 RID: 1654
	private bool _isClosed;

	// Token: 0x04000677 RID: 1655
	private static HelpController _instance;
}
