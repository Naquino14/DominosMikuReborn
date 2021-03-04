namespace System.Runtime.Remoting.Channels
{
	[Serializable]
	internal class CrossAppDomainChannel : IChannel, IChannelReceiver, IChannelSender
	{
		private const string _strName = "MONOCAD";

		private const string _strBaseURI = "MONOCADURI";

		private static object s_lock;

		internal static void RegisterCrossAppDomainChannel()
		{
		}
	}
}
