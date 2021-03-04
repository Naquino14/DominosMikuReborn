using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HelpController : MonoBehaviour
{
	public GameObject _root;

	private bool _isInited;

	private bool _isClosed;

	private static HelpController _instance;

	public static HelpController Instance => (HelpController)/*Error near IL_0001: Stack underflow*/;

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

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnCloseClick()
	{
	}

	private void DestroyScene()
	{
	}
}
