using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Enforces a synchronization domain for the current context and all contexts that share the same instance.</summary>
	[Serializable]
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(true)]
	public class SynchronizationAttribute : ContextAttribute, IContributeClientContextSink, IContributeServerContextSink
	{
		/// <summary>Indicates that the class to which this attribute is applied cannot be created in a context that has synchronization. This field is constant.</summary>
		public const int NOT_SUPPORTED = 1;

		/// <summary>Indicates that the class to which this attribute is applied is not dependent on whether the context has synchronization. This field is constant.</summary>
		public const int SUPPORTED = 2;

		/// <summary>Indicates that the class to which this attribute is applied must be created in a context that has synchronization. This field is constant.</summary>
		public const int REQUIRED = 4;

		/// <summary>Indicates that the class to which this attribute is applied must be created in a context with a new instance of the synchronization property each time. This field is constant.</summary>
		public const int REQUIRES_NEW = 8;

		private bool _bReEntrant;

		private int _flavor;

		[NonSerialized]
		private bool _locked;

		[NonSerialized]
		private int _lockCount;

		[NonSerialized]
		private Mutex _mutex;

		[NonSerialized]
		private Thread _ownerThread;

		/// <summary>Gets or sets a Boolean value indicating whether reentry is required.</summary>
		/// <returns>A Boolean value indicating whether reentry is required.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public virtual bool IsReEntrant => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets or sets a Boolean value indicating whether the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> implementing this instance of <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> is locked.</summary>
		/// <returns>A Boolean value indicating whether the <see cref="T:System.Runtime.Remoting.Contexts.Context" /> implementing this instance of <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> is locked.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public virtual bool Locked
		{
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> class with default values.</summary>
		public SynchronizationAttribute()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> class with a flag indicating the behavior of the object to which this attribute is applied, and a Boolean value indicating whether reentry is required.</summary>
		/// <param name="flag">An integer value indicating the behavior of the object to which this attribute is applied. </param>
		/// <param name="reEntrant">true if reentry is required, and callouts must be intercepted and serialized; otherwise, false. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="flag" /> parameter was not one of the defined flags. </exception>
		public SynchronizationAttribute(int flag, bool reEntrant)
		{
		}

		internal void AcquireLock()
		{
		}

		internal void ReleaseLock()
		{
		}

		/// <summary>Adds the Synchronized context property to the specified <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />.</summary>
		/// <param name="ctorMsg">The <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> to which to add the property. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		[ComVisible(true)]
		public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
		{
		}

		/// <summary>Creates a CallOut sink and chains it in front of the provided chain of sinks at the context boundary on the client end of a remoting call.</summary>
		/// <returns>The composite sink chain with the new CallOut sink.</returns>
		/// <param name="nextSink">The chain of sinks composed so far. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public virtual IMessageSink GetClientContextSink(IMessageSink nextSink)
		{
			return (IMessageSink)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a synchronized dispatch sink and chains it in front of the provided chain of sinks at the context boundary on the server end of a remoting call.</summary>
		/// <returns>The composite sink chain with the new synchronized dispatch sink.</returns>
		/// <param name="nextSink">The chain of sinks composed so far. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public virtual IMessageSink GetServerContextSink(IMessageSink nextSink)
		{
			return (IMessageSink)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a Boolean value indicating whether the context parameter meets the context attribute's requirements.</summary>
		/// <returns>true if the passed in context is OK; otherwise, false.</returns>
		/// <param name="ctx">The context to check. </param>
		/// <param name="msg">Information gathered at construction time of the context bound object marked by this attribute. The <see cref="T:System.Runtime.Remoting.Contexts.SynchronizationAttribute" /> can inspect, add to, and remove properties from the context while determining if the context is acceptable to it. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="ctx" /> or <paramref name="msg" /> parameter is null. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		[ComVisible(true)]
		public override bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		internal static void ExitContext()
		{
		}

		internal static void EnterContext()
		{
		}
	}
}
