using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DialogController : ShareComposerController
{
	private const string IMAGE_NAME = "screenshot.png";

	public GameObject _dialog;

	public GameObject _btnClose;

	public GameObject _btnFb;

	public GameObject _btnTw;

	public GameObject _btnAr;

	public GameObject _btnOk;

	public GameObject _imgLogo;

	public UISprite _title;

	public UISprite _content;

	public TextAsset fbiText;

	public TextAsset twiText;

	private bool _isInited;

	private bool _isClosed;

	private static DialogController _instance;

	public GameObject _root;

	public static DialogController Instance => (DialogController)/*Error near IL_0001: Stack underflow*/;

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

	private void Awake()
	{
	}

	private void HideAllButton()
	{
	}

	public void SetSpecialDialog()
	{
	}

	public void SetOKDialog()
	{
	}

	public void SetShareDialog()
	{
	}

	private void SetContent(string title, string content)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	protected override void PostFb()
	{
	}

	protected override void PostTw()
	{
	}

	private void OnFacebookClick()
	{
	}

	private void OnTwitterClick()
	{
	}

	private void OnCloseClick()
	{
	}

	private void OnGoArClick()
	{
	}

	private void OnOKClick()
	{
	}

	private void GoArAndDestroyScene()
	{
	}

	private void OKAndDestroyScene()
	{
	}

	private void DestroyScene()
	{
	}
}
