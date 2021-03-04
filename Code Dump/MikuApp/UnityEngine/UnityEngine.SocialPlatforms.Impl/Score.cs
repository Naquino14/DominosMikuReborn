using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.SocialPlatforms.Impl
{
	public class Score : IScore
	{
		private DateTime m_Date;

		private string m_FormattedValue;

		private string m_UserID;

		private int m_Rank;

		public string leaderboardID
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

		public long value
		{
			[CompilerGenerated]
			get
			{
				return (long)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Score(string leaderboardID, long value)
		{
		}

		public Score(string leaderboardID, long value, string userID, DateTime date, string formattedValue, int rank)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
