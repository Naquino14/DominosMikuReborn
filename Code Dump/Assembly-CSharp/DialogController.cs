using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200012F RID: 303
public class DialogController : ShareComposerController
{
	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060009AF RID: 2479 RVA: 0x000041B8 File Offset: 0x000023B8
	// (remove) Token: 0x060009B0 RID: 2480 RVA: 0x000041BC File Offset: 0x000023BC
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

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060009B1 RID: 2481 RVA: 0x000041C0 File Offset: 0x000023C0
	// (remove) Token: 0x060009B2 RID: 2482 RVA: 0x000041C4 File Offset: 0x000023C4
	public event Action onGoAr
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
	// (add) Token: 0x060009B3 RID: 2483 RVA: 0x000041C8 File Offset: 0x000023C8
	// (remove) Token: 0x060009B4 RID: 2484 RVA: 0x000041CC File Offset: 0x000023CC
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

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000041D0 File Offset: 0x000023D0
	public static DialogController Instance
	{
		get
		{
		}
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x000041D4 File Offset: 0x000023D4
	private void Awake()
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x000041D8 File Offset: 0x000023D8
	private void HideAllButton()
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x000041DC File Offset: 0x000023DC
	public void SetSpecialDialog()
	{
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x000041E0 File Offset: 0x000023E0
	public void SetOKDialog()
	{
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x000041E4 File Offset: 0x000023E4
	public void SetShareDialog()
	{
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x000041E8 File Offset: 0x000023E8
	private void SetContent(string title, string content)
	{
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x000041EC File Offset: 0x000023EC
	private void Update()
	{
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x000041F0 File Offset: 0x000023F0
	private void OnDestroy()
	{
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x000041F4 File Offset: 0x000023F4
	protected override void PostFb()
	{
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x000041F8 File Offset: 0x000023F8
	protected override void PostTw()
	{
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x000041FC File Offset: 0x000023FC
	private void OnFacebookClick()
	{
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00004200 File Offset: 0x00002400
	private void OnTwitterClick()
	{
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00004204 File Offset: 0x00002404
	private void OnCloseClick()
	{
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00004208 File Offset: 0x00002408
	private void OnGoArClick()
	{
	}

	// Token: 0x060009C4 RID: 2500 RVA: 0x0000420C File Offset: 0x0000240C
	private void OnOKClick()
	{
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x00004210 File Offset: 0x00002410
	private void GoArAndDestroyScene()
	{
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x00004214 File Offset: 0x00002414
	private void OKAndDestroyScene()
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00004218 File Offset: 0x00002418
	private void DestroyScene()
	{
	}

	// Token: 0x04000656 RID: 1622
	private const string IMAGE_NAME = "screenshot.png";

	// Token: 0x04000657 RID: 1623
	public GameObject _dialog;

	// Token: 0x04000658 RID: 1624
	public GameObject _btnClose;

	// Token: 0x04000659 RID: 1625
	public GameObject _btnFb;

	// Token: 0x0400065A RID: 1626
	public GameObject _btnTw;

	// Token: 0x0400065B RID: 1627
	public GameObject _btnAr;

	// Token: 0x0400065C RID: 1628
	public GameObject _btnOk;

	// Token: 0x0400065D RID: 1629
	public GameObject _imgLogo;

	// Token: 0x0400065E RID: 1630
	public UISprite _title;

	// Token: 0x0400065F RID: 1631
	public UISprite _content;

	// Token: 0x04000660 RID: 1632
	public TextAsset fbiText;

	// Token: 0x04000661 RID: 1633
	public TextAsset twiText;

	// Token: 0x04000662 RID: 1634
	private bool _isInited;

	// Token: 0x04000663 RID: 1635
	private bool _isClosed;

	// Token: 0x04000664 RID: 1636
	private static DialogController _instance;

	// Token: 0x04000665 RID: 1637
	public GameObject _root;
}
