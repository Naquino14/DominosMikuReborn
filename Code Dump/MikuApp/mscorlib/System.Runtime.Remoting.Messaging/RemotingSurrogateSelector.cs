using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Selects the remoting surrogate that can be used to serialize an object that derives from a <see cref="T:System.MarshalByRefObject" />.</summary>
	[ComVisible(true)]
	public class RemotingSurrogateSelector : ISurrogateSelector
	{
		private static Type s_cachedTypeObjRef;

		private static ObjRefSurrogate _objRefSurrogate;

		private static RemotingSurrogate _objRemotingSurrogate;

		private object _rootObj;

		private MessageSurrogateFilter _filter;

		private ISurrogateSelector _next;

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" /> class.</summary>
		public RemotingSurrogateSelector()
		{
		}

		/// <summary>Returns the appropriate surrogate for the given type in the given context.</summary>
		/// <returns>The appropriate surrogate for the given type in the given context.</returns>
		/// <param name="type">The <see cref="T:System.Type" /> for which the surrogate is requested. </param>
		/// <param name="context">The source or destination of serialization. </param>
		/// <param name="ssout">When this method returns, contains an <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> that is appropriate for the specified object type. This parameter is passed uninitialized. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="SerializationFormatter, Infrastructure" />
		/// </PermissionSet>
		public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
		{
			return (ISerializationSurrogate)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
