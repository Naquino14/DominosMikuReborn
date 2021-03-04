namespace System.Runtime.Remoting
{
	internal class ClientIdentity : Identity
	{
		private WeakReference _proxyReference;

		public MarshalByRefObject ClientProxy
		{
			get
			{
				return (MarshalByRefObject)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public string TargetUri => (string)/*Error near IL_0001: Stack underflow*/;

		public ClientIdentity(string objectUri, ObjRef objRef)
		{
		}

		public override ObjRef CreateObjRef(Type requestedType)
		{
			return (ObjRef)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
