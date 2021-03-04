using System.Runtime.CompilerServices;
using UnityEngine;

public class QCARRendererImpl : QCARRenderer
{
	private VideoBGCfgData mVideoBGConfig;

	private bool mVideoBGConfigSet;

	public override bool DrawVideoBackground
	{
		get
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
		set
		{
		}
	}

	public Texture2D VideoBackgroundForEmulator
	{
		[CompilerGenerated]
		get
		{
			return (Texture2D)/*Error near IL_0001: Stack underflow*/;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override VideoBGCfgData GetVideoBackgroundConfig()
	{
		return (VideoBGCfgData)/*Error near IL_0001: Stack underflow*/;
	}

	public override void ClearVideoBackgroundConfig()
	{
	}

	public override void SetVideoBackgroundConfig(VideoBGCfgData config)
	{
	}

	public override bool SetVideoBackgroundTexture(Texture2D texture)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool IsVideoBackgroundInfoAvailable()
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override VideoTextureInfo GetVideoTextureInfo()
	{
		return (VideoTextureInfo)/*Error near IL_0001: Stack underflow*/;
	}
}
