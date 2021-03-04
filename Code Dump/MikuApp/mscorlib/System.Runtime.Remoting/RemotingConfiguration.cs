using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Provides various static methods for configuring the remoting infrastructure.</summary>
	[ComVisible(true)]
	public static class RemotingConfiguration
	{
		private static string applicationID;

		private static string applicationName;

		private static string processGuid;

		private static bool defaultConfigRead;

		private static bool defaultDelayedConfigRead;

		private static string _errorMode;

		private static Hashtable wellKnownClientEntries;

		private static Hashtable activatedClientEntries;

		private static Hashtable wellKnownServiceEntries;

		private static Hashtable activatedServiceEntries;

		private static Hashtable channelTemplates;

		private static Hashtable clientProviderTemplates;

		private static Hashtable serverProviderTemplates;

		/// <summary>Gets or sets the name of a remoting application.</summary>
		/// <returns>The name of a remoting application.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static string ApplicationName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Returns a Boolean value that indicates whether the specified <see cref="T:System.Type" /> is allowed to be client activated.</summary>
		/// <returns>true if the specified <see cref="T:System.Type" /> is allowed to be client activated; otherwise, false.</returns>
		/// <param name="svrType">The object <see cref="T:System.Type" /> to check. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static bool IsActivationAllowed(Type svrType)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
