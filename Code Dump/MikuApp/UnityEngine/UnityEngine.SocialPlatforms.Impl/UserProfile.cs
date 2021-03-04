namespace UnityEngine.SocialPlatforms.Impl
{
	public class UserProfile : IUserProfile
	{
		protected string m_UserName;

		protected string m_ID;

		protected bool m_IsFriend;

		protected UserState m_State;

		protected Texture2D m_Image;

		public string userName => (string)/*Error near IL_0001: Stack underflow*/;

		public string id => (string)/*Error near IL_0001: Stack underflow*/;

		public bool isFriend => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public UserState state => (UserState)/*Error near IL_0001: Stack underflow*/;

		public UserProfile()
		{
		}

		public UserProfile(string name, string id, bool friend, UserState state, Texture2D image)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public void SetUserName(string name)
		{
		}

		public void SetUserID(string id)
		{
		}

		public void SetImage(Texture2D image)
		{
		}
	}
}
