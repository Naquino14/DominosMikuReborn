namespace UnityEngine.SocialPlatforms
{
	public interface ILocalUser : IUserProfile
	{
		bool authenticated
		{
			get;
		}
	}
}
