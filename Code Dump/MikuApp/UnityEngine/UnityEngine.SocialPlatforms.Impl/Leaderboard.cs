using System.Runtime.CompilerServices;

namespace UnityEngine.SocialPlatforms.Impl
{
	public class Leaderboard : ILeaderboard
	{
		private bool m_Loading;

		private IScore m_LocalUserScore;

		private uint m_MaxRange;

		private IScore[] m_Scores;

		private string m_Title;

		private string[] m_UserIDs;

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

		public UserScope userScope
		{
			[CompilerGenerated]
			get
			{
				return (UserScope)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Range range
		{
			[CompilerGenerated]
			get
			{
				return (Range)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeScope timeScope
		{
			[CompilerGenerated]
			get
			{
				return (TimeScope)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public void SetLocalUserScore(IScore score)
		{
		}

		public void SetMaxRange(uint maxRange)
		{
		}

		public void SetScores(IScore[] scores)
		{
		}

		public void SetTitle(string title)
		{
		}

		public string[] GetUserFilter()
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
