using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms.GameCenter
{
	internal struct GcAchievementData
	{
		public string m_Identifier;

		public double m_PercentCompleted;

		public int m_Completed;

		public int m_Hidden;

		public int m_LastReportedDate;

		public Achievement ToAchievement()
		{
			return (Achievement)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
