using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Provides a set of properties that are carried with the execution code path. This class cannot be inherited.</summary>
	[Serializable]
	[ComVisible(true)]
	public sealed class CallContext
	{
		[ThreadStatic]
		private static Header[] Headers;

		[ThreadStatic]
		private static Hashtable datastore;

		private static Hashtable Datastore => (Hashtable)/*Error near IL_0001: Stack underflow*/;

		private CallContext()
		{
		}

		/// <summary>Stores a given object and associates it with the specified name.</summary>
		/// <param name="name">The name with which to associate the new item in the call context. </param>
		/// <param name="data">The object to store in the call context. </param>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static void SetData(string name, object data)
		{
		}

		internal static LogicalCallContext CreateLogicalCallContext(bool createEmpty)
		{
			return (LogicalCallContext)/*Error near IL_0001: Stack underflow*/;
		}

		internal static object SetCurrentCallContext(LogicalCallContext ctx)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void UpdateCurrentCallContext(LogicalCallContext ctx)
		{
		}

		internal static void RestoreCallContext(object oldContext)
		{
		}
	}
}
