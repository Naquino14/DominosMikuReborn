using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DialogOKController : MonoBehaviour
{
	public GameObject _dialog;

	public GameObject _btnClose;

	public GameObject _btnOk;

	public UISprite _title;

	public UISprite _content;

	private bool _isInited;

	private bool _isClosed;

	private static DialogOKController _instance;

	public GameObject _root;

	public static DialogOKController Instance => (DialogOKController)/*Error near IL_0001: Stack underflow*/;

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

	public void SetOKDialog()
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

	private void OnCloseClick()
	{
	}

	private void OnOKClick()
	{
	}

	private void OKAndDestroyScene()
	{
	}

	private void DestroyScene()
	{
	}
}
