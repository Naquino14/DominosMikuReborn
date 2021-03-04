using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PoUIController : MonoBehaviour
{
	private const string IMAGE_NAME = "screenshot.png";

	[SerializeField]
	private GameObject[] djDiskFacePrefab;

	[SerializeField]
	private GameObject[] djDiskPosePrefab;

	public DJDisk.item_change_delegate onFaceItemChange;

	public DJDisk.item_change_delegate onPoseItemChange;

	public PoController _poCtrl;

	public Color normalButtonColor;

	public Color selectButtonColor;

	public Transform _panel1_1;

	public Transform _panel2_1;

	public Transform _shield;

	public UIImageButton _faceButton;

	public UIImageButton _poseButton;

	public DjDiskTop _djDiskFace;

	public DjDiskTop _djDiskPose;

	public GameObject _captureScreen;

	public UIWidget _flash;

	public UISprite _logo;

	public ArNavi _banner;

	public Guide _guide;

	public Aim _aim;

	private DjDiskTop _currentDisk;

	private Texture2D _screenTex;

	private MSpecialPose _specialData;

	private int _curFace;

	public ArNavi _btnNormal;

	public ArNavi _btnNew;

	public event Action onBannerClick
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

	public event Action onArBackClick
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

	public event Action onSwitchClick
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

	public event Action onNewClick
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

	public void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void AddAllDelegates()
	{
	}

	private void RemoveAllDelegates()
	{
	}

	public int GetCurrentFace()
	{
		return (int)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnFaceItemChange(int itemId)
	{
	}

	private void OnPoseItemChange(int itemId)
	{
	}

	public void OnBannerClick()
	{
	}

	public void OnArBackClick()
	{
	}

	public void OnBackClick()
	{
	}

	public void OnHelpClick()
	{
	}

	public void OnCameraClick()
	{
	}

	[DebuggerHidden]
	private IEnumerator RenTexture()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private Texture2D CreateScreenTex()
	{
		return (Texture2D)/*Error near IL_0001: Stack underflow*/;
	}

	private Material CreateScreenMat(Texture2D tex)
	{
		return (Material)/*Error near IL_0001: Stack underflow*/;
	}

	private void CreateCaptureObject(Material mat)
	{
	}

	[DebuggerHidden]
	private IEnumerator Flash()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator SaveScreenShot()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator CaptureScreen()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	[DebuggerHidden]
	private IEnumerator ShowDialog()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnShareClose()
	{
	}

	[DebuggerHidden]
	public IEnumerator ShowHelp()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnHelpClose()
	{
	}

	public void OnFaceClick()
	{
	}

	private void ShowFace()
	{
	}

	public void OnPoseClick()
	{
	}

	private void ShowPose()
	{
	}

	public void OnCloseClick()
	{
	}

	public void OnFaceDiskCloseClick()
	{
	}

	public void OnPoseDiskCloseClick()
	{
	}

	public void Found()
	{
	}

	[DebuggerHidden]
	private IEnumerator IEfound()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	public void ShowAr()
	{
	}

	public void ShowAr(float fadeTime)
	{
	}

	public void HideAr()
	{
	}

	public void HideAr(float fadeTime, string callback)
	{
	}

	public void Show(float fadeTime)
	{
	}

	public void ShowAndWaitSpecialAppear(float fadeTime)
	{
	}

	public void ActiveSpecialText(bool active)
	{
	}

	public void ActiveSpecialText(float time, float delay)
	{
	}

	public void DestroyTweenSpecialText()
	{
	}

	public void Hide()
	{
	}

	public void Hide(float fadeTime, string callback)
	{
	}

	public void StartRotateEffect()
	{
	}

	public void Lock()
	{
	}

	public void Unlock()
	{
	}

	public void UnlockAfter(float delay)
	{
	}

	[DebuggerHidden]
	private IEnumerator IErotatePoseDisk(float delay)
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void HidePoseDisk()
	{
	}

	private void ShowPoseDisk(float delay)
	{
	}

	private void HideFaceDisk()
	{
	}

	private void ShowFaceDisk(float delay)
	{
	}

	[DebuggerHidden]
	private IEnumerator Capture()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void OnSwitchNormalClick()
	{
	}

	private void OnSwitchNewClick()
	{
	}

	private void LockSwitchButtons()
	{
	}

	private void UnlockSwitchButtons()
	{
	}

	public void ResetDisks(int version = 0)
	{
	}

	private DjDiskTop MakeDisk(GameObject prefab, GameObject old, Transform pa)
	{
		return (DjDiskTop)/*Error near IL_0001: Stack underflow*/;
	}
}
