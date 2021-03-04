using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms.GameCenter
{
	internal struct GcUserProfileData
	{
		public string userName;

		public string userID;

		public int isFriend;

		public Texture2D image;

		public UserProfile ToUserProfile()
		{
			return (UserProfile)/*Error near IL_0001: Stack underflow*/;
		}

		public void AddToArray(ref UserProfile[] array, int number)
		{
		}
	}
}
