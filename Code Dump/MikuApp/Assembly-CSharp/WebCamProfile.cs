using System.Collections.Generic;

public class WebCamProfile
{
	public struct ProfileData
	{
		public QCARRenderer.Vec2I RequestedTextureSize;

		public QCARRenderer.Vec2I ResampledTextureSize;

		public int RequestedFPS;
	}

	private ProfileData mDefaultProfile;

	private readonly Dictionary<string, ProfileData> mProfiles;

	public ProfileData Default => (ProfileData)/*Error near IL_0001: Stack underflow*/;

	public ProfileData GetProfile(string webcamName)
	{
		return (ProfileData)/*Error near IL_0001: Stack underflow*/;
	}

	public bool ProfileAvailable(string webcamName)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private void LoadAndParseProfiles()
	{
	}
}
