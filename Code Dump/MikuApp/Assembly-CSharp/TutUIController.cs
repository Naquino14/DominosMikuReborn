using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class TutUIController : MonoBehaviour
{
	private const float MAX_BAR_WIDTH = 560f;

	public GameObject _root;

	public Camera _camera;

	public UILabel _textPer;

	public UISlicedSprite _barPer;

	public UISprite _loading;

	public FlashProgress _flash;

	public Transform[] _panels;

	private int _type;

	private bool _isStartedBlink;

	private bool _isReady;

	private static TutUIController _instance;

	public bool IsReady => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public static TutUIController Instance => (TutUIController)/*Error near IL_0001: Stack underflow*/;

	private void Awake()
	{
	}

	private void ResetZero()
	{
	}

	[DebuggerHidden]
	private IEnumerator Start()
	{
		return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
	}

	private void SetReady()
	{
	}

	private void DestroyScene()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void SetDownloadPercent(float percent)
	{
	}

	private void SetTextPercent(float percent)
	{
	}

	private void SetBarPercent(float percent)
	{
	}

	protected virtual void OnPercentChanged(float percent)
	{
	}

	public void OnBackClick()
	{
	}

	public void SetCameraToDepthOnly()
	{
	}

	public void SetIsLoading()
	{
	}

	public void SetIsDownloading()
	{
	}

	private void RunFlash()
	{
	}

	private void BlinkLoading()
	{
	}
}
