using UnityEngine;

public class WebCamTexAdaptorImpl : WebCamTexAdaptor
{
	private WebCamTexture mWebCamTexture;

	public override bool DidUpdateThisFrame => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override bool IsPlaying => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override Texture Texture => (Texture)/*Error near IL_0001: Stack underflow*/;

	public WebCamTexAdaptorImpl(string deviceName, int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}
}
