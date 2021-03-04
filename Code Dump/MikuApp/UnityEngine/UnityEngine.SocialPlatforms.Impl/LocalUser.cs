namespace UnityEngine.SocialPlatforms.Impl
{
	public class LocalUser : UserProfile, ILocalUser, IUserProfile
	{
		private IUserProfile[] m_Friends;

		private bool m_Authenticated;

		private bool m_Underage;

		public bool authenticated => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public void SetFriends(IUserProfile[] friends)
		{
		}

		public void SetAuthenticated(bool value)
		{
		}

		public void SetUnderage(bool value)
		{
		}
	}
}
