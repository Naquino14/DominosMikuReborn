using System;
using UnityEngine;

public class NullWebCamTexAdaptor : WebCamTexAdaptor
{
	private const string ERROR_MSG = "No camera connected!\nTo run your application using Play Mode, please connect a webcam to your computer.";

	private readonly Texture2D mTexture;

	private bool mPseudoPlaying;

	private readonly double mMsBetweenFrames;

	private DateTime mLastFrame;

	public override bool DidUpdateThisFrame => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override bool IsPlaying => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override Texture Texture => (Texture)/*Error near IL_0001: Stack underflow*/;

	public NullWebCamTexAdaptor(int requestedFPS, QCARRenderer.Vec2I requestedTextureSize)
	{
	}

	public override void Play()
	{
	}

	public override void Stop()
	{
	}
}
