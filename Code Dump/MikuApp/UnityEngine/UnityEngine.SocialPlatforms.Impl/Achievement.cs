using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.SocialPlatforms.Impl
{
	public class Achievement : IAchievement
	{
		private bool m_Completed;

		private bool m_Hidden;

		private DateTime m_LastReportedDate;

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

		public double percentCompleted
		{
			[CompilerGenerated]
			get
			{
				return (double)/*Error near IL_0001: Stack underflow*/;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool completed => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool hidden => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public DateTime lastReportedDate => (DateTime)/*Error near IL_0001: Stack underflow*/;

		public Achievement(string id, double percentCompleted, bool completed, bool hidden, DateTime lastReportedDate)
		{
		}

		public Achievement(string id, double percent)
		{
		}

		public Achievement()
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
