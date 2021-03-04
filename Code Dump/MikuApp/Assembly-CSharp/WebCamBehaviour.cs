using UnityEngine;

[RequireComponent(typeof(Camera))]
public class WebCamBehaviour : MonoBehaviour
{
	public Camera BackgroundCameraPrefab;

	public int RenderTextureLayer;

	[HideInInspector]
	[SerializeField]
	private string mDeviceNameSetInEditor;

	[HideInInspector]
	[SerializeField]
	private bool mFlipHorizontally;

	[SerializeField]
	[HideInInspector]
	private bool mTurnOffWebCam;

	private WebCamImpl mWebCamImpl;

	private Camera mBackgroundCameraInstance;

	public string DeviceName
	{
		get
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
		set
		{
		}
	}

	public WebCamImpl ImplementationClass => (WebCamImpl)/*Error near IL_0001: Stack underflow*/;

	public bool FlipHorizontally
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public bool TurnOffWebCam
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public bool IsPlaying => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public void InitCamera()
	{
	}

	public void StartCamera()
	{
	}

	public void StopCamera()
	{
	}

	public bool CheckNativePluginSupport()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public bool IsWebCamUsed()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
