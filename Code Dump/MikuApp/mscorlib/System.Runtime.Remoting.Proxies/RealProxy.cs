using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Proxies
{
	/// <summary>Provides base functionality for proxies.</summary>
	[ComVisible(true)]
	public abstract class RealProxy
	{
		private Type class_to_proxy;

		internal Context _targetContext;

		private MarshalByRefObject _server;

		private int _targetDomainId;

		internal string _targetUri;

		internal Identity _objectIdentity;

		private object _objTP;

		private object _stubData;

		internal Identity ObjectIdentity => (Identity)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> class that represents a remote object of the specified <see cref="T:System.Type" />.</summary>
		/// <param name="classToProxy">The <see cref="T:System.Type" /> of the remote object for which to create a proxy. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="classToProxy" /> is not an interface, and is not derived from <see cref="T:System.MarshalByRefObject" />. </exception>
		protected RealProxy(Type classToProxy)
		{
		}

		internal RealProxy(Type classToProxy, ClientIdentity identity)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> class.</summary>
		/// <param name="classToProxy">The <see cref="T:System.Type" /> of the remote object for which to create a proxy. </param>
		/// <param name="stub">A stub to associate with the new proxy instance. </param>
		/// <param name="stubData">The stub data to set for the specified stub and the new proxy instance. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="classToProxy" /> is not an interface, and is not derived from <see cref="T:System.MarshalByRefObject" />. </exception>
		protected RealProxy(Type classToProxy, IntPtr stub, object stubData)
		{
		}

		[MethodImpl(4096)]
		private static extern Type InternalGetProxyType(object transparentProxy);

		/// <summary>Returns the <see cref="T:System.Type" /> of the object that the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> represents.</summary>
		/// <returns>The <see cref="T:System.Type" /> of the object that the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" /> represents.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public Type GetProxiedType()
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>When overridden in a derived class, invokes the method that is specified in the provided <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> on the remote object that is represented by the current instance.</summary>
		/// <returns>The message returned by the invoked method, containing the return value and any out or ref parameters.</returns>
		/// <param name="msg">A <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> that contains a <see cref="T:System.Collections.IDictionary" /> of information about the method call. </param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public abstract IMessage Invoke(IMessage msg);

		[MethodImpl(4096)]
		internal virtual extern object InternalGetTransparentProxy(string className);

		/// <summary>Returns the transparent proxy for the current instance of <see cref="T:System.Runtime.Remoting.Proxies.RealProxy" />.</summary>
		/// <returns>The transparent proxy for the current proxy instance.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public virtual object GetTransparentProxy()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		internal void SetTargetDomain(int domainId)
		{
		}
	}
}
