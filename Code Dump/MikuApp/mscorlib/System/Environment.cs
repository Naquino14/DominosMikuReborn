using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Provides information about, and means to manipulate, the current environment and platform. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	public static class Environment
	{
		/// <summary>Specifies enumerated constants used to retrieve directory paths to system special folders.</summary>
		[ComVisible(true)]
		public enum SpecialFolder
		{
			/// <summary>The "My Documents" folder.</summary>
			MyDocuments = 5,
			/// <summary>The logical Desktop rather than the physical file system location.</summary>
			Desktop = 0,
			/// <summary>The "My Computer" folder. </summary>
			MyComputer = 17,
			/// <summary>The directory that contains the user's program groups.</summary>
			Programs = 2,
			/// <summary>The directory that serves as a common repository for documents.</summary>
			Personal = 5,
			/// <summary>The directory that serves as a common repository for the user's favorite items.</summary>
			Favorites = 6,
			/// <summary>The directory that corresponds to the user's Startup program group.</summary>
			Startup = 7,
			/// <summary>The directory that contains the user's most recently used documents.</summary>
			Recent = 8,
			/// <summary>The directory that contains the Send To menu items.</summary>
			SendTo = 9,
			/// <summary>The directory that contains the Start menu items.</summary>
			StartMenu = 11,
			/// <summary>The "My Music" folder.</summary>
			MyMusic = 13,
			/// <summary>The directory used to physically store file objects on the desktop.</summary>
			DesktopDirectory = 0x10,
			/// <summary>The directory that serves as a common repository for document templates.</summary>
			Templates = 21,
			/// <summary>The directory that serves as a common repository for application-specific data for the current roaming user.</summary>
			ApplicationData = 26,
			/// <summary>The directory that serves as a common repository for application-specific data that is used by the current, non-roaming user.</summary>
			LocalApplicationData = 28,
			/// <summary>The directory that serves as a common repository for temporary Internet files.</summary>
			InternetCache = 0x20,
			/// <summary>The directory that serves as a common repository for Internet cookies.</summary>
			Cookies = 33,
			/// <summary>The directory that serves as a common repository for Internet history items.</summary>
			History = 34,
			/// <summary>The directory that serves as a common repository for application-specific data that is used by all users.</summary>
			CommonApplicationData = 35,
			/// <summary>The System directory.</summary>
			System = 37,
			/// <summary>The program files directory.</summary>
			ProgramFiles = 38,
			/// <summary>The "My Pictures" folder.</summary>
			MyPictures = 39,
			/// <summary>The directory for components that are shared across applications.</summary>
			CommonProgramFiles = 43
		}

		private const int mono_corlib_version = 82;

		private static OperatingSystem os;

		/// <summary>Gets the command line for this process.</summary>
		/// <returns>A string containing command-line arguments.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="Path" />
		/// </PermissionSet>
		public static string CommandLine => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the fully qualified path of the current working directory.</summary>
		/// <returns>A string containing a directory path. </returns>
		/// <exception cref="T:System.ArgumentException">Attempted to set to an empty string (""). </exception>
		/// <exception cref="T:System.ArgumentNullException">Attempted to set to null. </exception>
		/// <exception cref="T:System.IO.IOException">An I/O error occurred. </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">Attempted to set a local path that cannot be found. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the appropriate permission. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static string CurrentDirectory
		{
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the exit code of the process.</summary>
		/// <returns>A 32-bit signed integer containing the exit code. The default value is zero.</returns>
		/// <filterpriority>1</filterpriority>
		public static int ExitCode
		{
			[MethodImpl(4096)]
			get;
			[MethodImpl(4096)]
			set;
		}

		/// <summary>Gets a value indicating whether the common language runtime is shutting down or the current application domain is unloading.</summary>
		/// <returns>true if the common language runtime is shutting down or the current <see cref="T:System.AppDomain" /> is unloading; otherwise, false.The current application domain is the <see cref="T:System.AppDomain" /> that contains the object that is calling <see cref="P:System.Environment.HasShutdownStarted" />.</returns>
		/// <filterpriority>1</filterpriority>
		public static bool HasShutdownStarted
		{
			[MethodImpl(4096)]
			get;
		}

		public static string EmbeddingHostName
		{
			[MethodImpl(4096)]
			get;
		}

		public static bool SocketSecurityEnabled
		{
			[MethodImpl(4096)]
			get;
		}

		public static bool UnityWebSecurityEnabled => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets the NetBIOS name of this local computer.</summary>
		/// <returns>A string containing the name of this computer.</returns>
		/// <exception cref="T:System.InvalidOperationException">The name of this computer cannot be obtained. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="COMPUTERNAME" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static string MachineName
		{
			[MethodImpl(4096)]
			get;
		}

		/// <summary>Gets the newline string defined for this environment.</summary>
		/// <returns>A string containing "\r\n" for non-Unix platforms,  or a string containing "\n" for Unix platforms.</returns>
		/// <filterpriority>1</filterpriority>
		public static string NewLine
		{
			[MethodImpl(4096)]
			get;
		}

		internal static PlatformID Platform
		{
			[MethodImpl(4096)]
			get;
		}

		/// <summary>Gets an <see cref="T:System.OperatingSystem" /> object that contains the current platform identifier and version number.</summary>
		/// <returns>An <see cref="T:System.OperatingSystem" /> object.</returns>
		/// <exception cref="T:System.InvalidOperationException">This property was unable to obtain the system version.-or- The obtained platform identifier is not a member of <see cref="T:System.PlatformID" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static OperatingSystem OSVersion => (OperatingSystem)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets current stack trace information.</summary>
		/// <returns>A string containing stack trace information. This value can be <see cref="F:System.String.Empty" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The requested stack trace information is out of range. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public static string StackTrace => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the number of milliseconds elapsed since the system started.</summary>
		/// <returns>A 32-bit signed integer containing the amount of time in milliseconds that has passed since the last time the computer was started.</returns>
		/// <filterpriority>1</filterpriority>
		public static int TickCount
		{
			[MethodImpl(4096)]
			get;
		}

		/// <summary>Gets the network domain name associated with the current user.</summary>
		/// <returns>The network domain name associated with the current user.</returns>
		/// <exception cref="T:System.PlatformNotSupportedException">The operating system does not support retrieving the network domain name. </exception>
		/// <exception cref="T:System.InvalidOperationException">The network domain name cannot be retrieved. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="UserName;UserDomainName" />
		/// </PermissionSet>
		public static string UserDomainName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the current process is running in user interactive mode.</summary>
		/// <returns>true if the current process is running in user interactive mode; otherwise, false.</returns>
		/// <filterpriority>1</filterpriority>
		[MonoTODO("Currently always returns false, regardless of interactive state")]
		public static bool UserInteractive => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets the user name of the person who is currently logged on to the Windows operating system.</summary>
		/// <returns>The user name of the person who is logged on to Windows.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="UserName" />
		/// </PermissionSet>
		public static string UserName
		{
			[MethodImpl(4096)]
			get;
		}

		/// <summary>Gets a <see cref="T:System.Version" /> object that describes the major, minor, build, and revision numbers of the common language runtime.</summary>
		/// <returns>A <see cref="T:System.Version" /> object.</returns>
		/// <filterpriority>1</filterpriority>
		public static Version Version => (Version)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the amount of physical memory mapped to the process context.</summary>
		/// <returns>A 64-bit signed integer containing the number of bytes of physical memory mapped to the process context.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[MonoTODO("Currently always returns zero")]
		public static long WorkingSet => (long)/*Error near IL_0001: Stack underflow*/;

		internal static bool IsRunningOnWindows => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		[MethodImpl(4096)]
		internal static extern string GetOSVersionString();

		/// <summary>Terminates this process and gives the underlying operating system the specified exit code.</summary>
		/// <param name="exitCode">Exit code to be given to the operating system. </param>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have sufficient security permission to perform this function. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern void Exit(int exitCode);

		/// <summary>Replaces the name of each environment variable embedded in the specified string with the string equivalent of the value of the variable, then returns the resulting string.</summary>
		/// <returns>A string with each environment variable replaced by its value.</returns>
		/// <param name="name">A string containing the names of zero or more environment variables. Each environment variable is quoted with the percent sign character (%). </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string ExpandEnvironmentVariables(string name)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string array containing the command-line arguments for the current process.</summary>
		/// <returns>An array of string where each element contains a command-line argument. The first element is the executable file name, and the following zero or more elements contain the remaining command-line arguments.</returns>
		/// <exception cref="T:System.NotSupportedException">The system does not support command-line arguments. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="Path" />
		/// </PermissionSet>
		[MethodImpl(4096)]
		public static extern string[] GetCommandLineArgs();

		[MethodImpl(4096)]
		internal static extern string internalGetEnvironmentVariable(string variable);

		/// <summary>Retrieves the value of an environment variable from the current process.</summary>
		/// <returns>The value of the environment variable specified by <paramref name="variable" />, or null if the environment variable is not found.</returns>
		/// <param name="variable">The name of the environment variable. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="variable" /> is null. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string GetEnvironmentVariable(string variable)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static Hashtable GetEnvironmentVariablesNoCase()
		{
			return (Hashtable)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves all environment variable names and their values from the current process.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> that contains all environment variable names and their values; otherwise, an empty dictionary if no environment variables are found.</returns>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission to perform this operation.</exception>
		/// <exception cref="T:System.OutOfMemoryException">The buffer is out of memory.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static IDictionary GetEnvironmentVariables()
		{
			return (IDictionary)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern string GetWindowsFolderPath(int folder);

		/// <summary>Gets the path to the system special folder identified by the specified enumeration.</summary>
		/// <returns>The path to the specified system special folder, if that folder physically exists on your computer; otherwise, the empty string ("").A folder will not physically exist if the operating system did not create it, the existing folder was deleted, or the folder is a virtual directory, such as My Computer, which does not correspond to a physical path.</returns>
		/// <param name="folder">An enumerated constant that identifies a system special folder. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="folder" /> is not a member of <see cref="T:System.Environment.SpecialFolder" />. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The current platform is not supported.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string GetFolderPath(SpecialFolder folder)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static string ReadXdgUserDir(string config_dir, string home_dir, string key, string fallback)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string InternalGetFolderPath(SpecialFolder folder)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an array of string containing the names of the logical drives on the current computer.</summary>
		/// <returns>An array of strings where each element contains the name of a logical drive. For example, if the computer's hard drive is the first logical drive, the first element returned is "C:\".</returns>
		/// <exception cref="T:System.IO.IOException">An I/O error occurs. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string[] GetLogicalDrives()
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern string[] GetLogicalDrivesInternal();

		[MethodImpl(4096)]
		private static extern string[] GetEnvironmentVariableNames();

		[MethodImpl(4096)]
		internal static extern string GetMachineConfigPath();

		[MethodImpl(4096)]
		internal static extern string internalGetHome();
	}
}
