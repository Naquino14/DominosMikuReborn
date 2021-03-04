using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000130 RID: 304
public class DialogOKController : MonoBehaviour
{
	// Token: 0x1400000C RID: 12
	// (add) Token: 0x060009C9 RID: 2505 RVA: 0x00004220 File Offset: 0x00002420
	// (remove) Token: 0x060009CA RID: 2506 RVA: 0x00004224 File Offset: 0x00002424
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

	// Token: 0x1400000D RID: 13
	// (add) Token: 0x060009CB RID: 2507 RVA: 0x00004228 File Offset: 0x00002428
	// (remove) Token: 0x060009CC RID: 2508 RVA: 0x0000422C File Offset: 0x0000242C
	public event Action onOK
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

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x060009CD RID: 2509 RVA: 0x00004230 File Offset: 0x00002430
	public static DialogOKController Instance
	{
		get
		{
		}
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00004234 File Offset: 0x00002434
	private void Awake()
	{
	}

	// Token: 0x060009CF RID: 2511 RVA: 0x00004238 File Offset: 0x00002438
	private void HideAllButton()
	{
	}

	// Token: 0x060009D0 RID: 2512 RVA: 0x0000423C File Offset: 0x0000243C
	public void SetOKDialog()
	{
	}

	// Token: 0x060009D1 RID: 2513 RVA: 0x00004240 File Offset: 0x00002440
	private void SetContent(string title, string content)
	{
	}

	// Token: 0x060009D2 RID: 2514 RVA: 0x00004244 File Offset: 0x00002444
	private void Update()
	{
	}

	// Token: 0x060009D3 RID: 2515 RVA: 0x00004248 File Offset: 0x00002448
	private void OnDestroy()
	{
	}

	// Token: 0x060009D4 RID: 2516 RVA: 0x0000424C File Offset: 0x0000244C
	private void OnCloseClick()
	{
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00004250 File Offset: 0x00002450
	private void OnOKClick()
	{
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x00004254 File Offset: 0x00002454
	private void OKAndDestroyScene()
	{
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x00004258 File Offset: 0x00002458
	private void DestroyScene()
	{
	}

	// Token: 0x04000669 RID: 1641
	public GameObject _dialog;

	// Token: 0x0400066A RID: 1642
	public GameObject _btnClose;

	// Token: 0x0400066B RID: 1643
	public GameObject _btnOk;

	// Token: 0x0400066C RID: 1644
	public UISprite _title;

	// Token: 0x0400066D RID: 1645
	public UISprite _content;

	// Token: 0x0400066E RID: 1646
	private bool _isInited;

	// Token: 0x0400066F RID: 1647
	private bool _isClosed;

	// Token: 0x04000670 RID: 1648
	private static DialogOKController _instance;

	// Token: 0x04000671 RID: 1649
	public GameObject _root;
}
