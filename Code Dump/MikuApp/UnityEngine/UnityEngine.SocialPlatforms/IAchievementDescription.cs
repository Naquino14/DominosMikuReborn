namespace UnityEngine.SocialPlatforms
{
	public interface IAchievementDescription
	{
		string id
		{
			get;
			set;
		}

		string title
		{
			get;
		}

		string achievedDescription
		{
			get;
		}

		string unachievedDescription
		{
			get;
		}

		bool hidden
		{
			get;
		}

		int points
		{
			get;
		}
	}
}
