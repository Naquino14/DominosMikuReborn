using System;
using System.Collections.Generic;

// Token: 0x020000C4 RID: 196
public class WebCamProfile
{
	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000567 RID: 1383 RVA: 0x000033FC File Offset: 0x000015FC
	public WebCamProfile.ProfileData Default
	{
		get
		{
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00003400 File Offset: 0x00001600
	public WebCamProfile.ProfileData GetProfile(string webcamName)
	{
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x00003404 File Offset: 0x00001604
	public bool ProfileAvailable(string webcamName)
	{
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x00003408 File Offset: 0x00001608
	private void LoadAndParseProfiles()
	{
	}

	// Token: 0x04000431 RID: 1073
	private WebCamProfile.ProfileData mDefaultProfile;

	// Token: 0x04000432 RID: 1074
	private readonly Dictionary<string, WebCamProfile.ProfileData> mProfiles;

	// Token: 0x020000C5 RID: 197
	public struct ProfileData
	{
		// Token: 0x04000433 RID: 1075
		public QCARRenderer.Vec2I RequestedTextureSize;

		// Token: 0x04000434 RID: 1076
		public QCARRenderer.Vec2I ResampledTextureSize;

		// Token: 0x04000435 RID: 1077
		public int RequestedFPS;
	}
}
