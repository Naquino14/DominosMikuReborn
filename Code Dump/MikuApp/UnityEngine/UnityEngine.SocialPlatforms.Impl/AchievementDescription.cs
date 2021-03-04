using System.Runtime.CompilerServices;

namespace UnityEngine.SocialPlatforms.Impl
{
	public class AchievementDescription : IAchievementDescription
	{
		private string m_Title;

		private Texture2D m_Image;

		private string m_AchievedDescription;

		private string m_UnachievedDescription;

		private bool m_Hidden;

		private int m_Points;

		public string id
		{
			[CompilerGenerated]
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string title => (string)/*Error near IL_0001: Stack underflow*/;

		public string achievedDescription => (string)/*Error near IL_0001: Stack underflow*/;

		public string unachievedDescription => (string)/*Error near IL_0001: Stack underflow*/;

		public bool hidden => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public int points => (int)/*Error near IL_0001: Stack underflow*/;

		public AchievementDescription(string id, string title, Texture2D image, string achievedDescription, string unachievedDescription, bool hidden, int points)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public void SetImage(Texture2D image)
		{
		}
	}
}
