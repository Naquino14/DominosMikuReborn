namespace System.Runtime.Remoting
{
	internal class ClientActivatedIdentity : ServerIdentity
	{
		private MarshalByRefObject _targetThis;

		public ClientActivatedIdentity(string objectUri, Type objectType)
		{
		}

		public MarshalByRefObject GetServerObject()
		{
			return (MarshalByRefObject)/*Error near IL_0001: Stack underflow*/;
		}

		public override void OnLifetimeExpired()
		{
		}
	}
}
