using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms.GameCenter
{
	internal struct GcScoreData
	{
		public string m_Category;

		public int m_ValueLow;

		public int m_ValueHigh;

		public int m_Date;

		public string m_FormattedValue;

		public string m_PlayerID;

		public int m_Rank;

		public Score ToScore()
		{
			return (Score)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
