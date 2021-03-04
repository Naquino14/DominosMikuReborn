using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Defines an environment for the objects that are resident inside it and for which a policy can be enforced.</summary>
	[ComVisible(true)]
	public class Context
	{
		private int domain_id;

		private int context_id;

		private UIntPtr static_data;

		private static IMessageSink default_server_context_sink;

		private IMessageSink server_context_sink_chain;

		private IMessageSink client_context_sink_chain;

		private object[] datastore;

		private ArrayList context_properties;

		private bool frozen;

		private static int global_count;

		private static Hashtable namedSlots;

		private static DynamicPropertyCollection global_dynamic_properties;

		private DynamicPropertyCollection context_dynamic_properties;

		private ContextCallbackObject callback_object;

		/// <summary>Gets the default context for the current application domain.</summary>
		/// <returns>The default context for the <see cref="T:System.AppDomain" /> namespace.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static Context DefaultContext => (Context)/*Error near IL_0001: Stack underflow*/;

		internal bool IsDefaultContext => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		internal static bool HasGlobalDynamicSinks => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		internal bool HasDynamicSinks => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		internal bool HasExitSinks => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Cleans up the backing objects for the nondefault contexts.</summary>
		~Context()
		{
		}

		internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
		}

		internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async)
		{
		}

		/// <summary>Returns a specific context property, specified by name.</summary>
		/// <returns>The specified context property.</returns>
		/// <param name="name">The name of the property. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public virtual IContextProperty GetProperty(string name)
		{
			return (IContextProperty)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a <see cref="T:System.String" /> class representation of the current context.</summary>
		/// <returns>A <see cref="T:System.String" /> class representation of the current context.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal IMessageSink GetServerContextSinkChain()
		{
			return (IMessageSink)/*Error near IL_0001: Stack underflow*/;
		}

		internal IMessageSink GetClientContextSinkChain()
		{
			return (IMessageSink)/*Error near IL_0001: Stack underflow*/;
		}

		internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject)
		{
			return (IMessageSink)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
