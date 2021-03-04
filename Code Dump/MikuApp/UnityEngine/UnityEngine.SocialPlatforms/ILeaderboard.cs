namespace UnityEngine.SocialPlatforms
{
	public interface ILeaderboard
	{
		string id
		{
			get;
			set;
		}

		UserScope userScope
		{
			get;
			set;
		}

		Range range
		{
			get;
			set;
		}

		TimeScope timeScope
		{
			get;
			set;
		}
	}
}
