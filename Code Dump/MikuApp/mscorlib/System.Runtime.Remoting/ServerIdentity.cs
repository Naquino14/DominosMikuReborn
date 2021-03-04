using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting
{
	internal abstract class ServerIdentity : Identity
	{
		protected Type _objectType;

		protected MarshalByRefObject _serverObject;

		protected IMessageSink _serverSink;

		protected Context _context;

		protected Lease _lease;

		public Type ObjectType => (Type)/*Error near IL_0001: Stack underflow*/;

		public Lease Lease => (Lease)/*Error near IL_0001: Stack underflow*/;

		public Context Context => (Context)/*Error near IL_0001: Stack underflow*/;

		public ServerIdentity(string objectUri, Context context, Type objectType)
		{
		}

		public void StartTrackingLifetime(ILease lease)
		{
		}

		public virtual void OnLifetimeExpired()
		{
		}

		public override ObjRef CreateObjRef(Type requestedType)
		{
			return (ObjRef)/*Error near IL_0001: Stack underflow*/;
		}

		public void AttachServerObject(MarshalByRefObject serverObject, Context context)
		{
		}

		protected void DisposeServerObject()
		{
		}
	}
}
