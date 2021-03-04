namespace UnityEngine.SocialPlatforms
{
	public interface IScore
	{
		string leaderboardID
		{
			get;
			set;
		}

		long value
		{
			get;
			set;
		}
	}
}
