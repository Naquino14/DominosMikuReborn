using System.Runtime.InteropServices;

namespace System.IO
{
	/// <summary>Performs operations on <see cref="T:System.String" /> instances that contain file or directory path information. These operations are performed in a cross-platform manner.</summary>
	/// <filterpriority>1</filterpriority>
	[ComVisible(true)]
	public static class Path
	{
		/// <summary>Provides a platform-specific array of characters that cannot be specified in path string arguments passed to members of the <see cref="T:System.IO.Path" /> class.</summary>
		/// <returns>A character array of invalid path characters for the current platform.</returns>
		/// <filterpriority>1</filterpriority>
		[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
		public static readonly char[] InvalidPathChars;

		/// <summary>Provides a platform-specific alternate character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char AltDirectorySeparatorChar;

		/// <summary>Provides a platform-specific character used to separate directory levels in a path string that reflects a hierarchical file system organization.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char DirectorySeparatorChar;

		/// <summary>A platform-specific separator character used to separate path strings in environment variables.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char PathSeparator;

		internal static readonly string DirectorySeparatorStr;

		/// <summary>Provides a platform-specific volume separator character.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly char VolumeSeparatorChar;

		internal static readonly char[] PathSeparatorChars;

		private static readonly bool dirEqualsVolume;

		static Path()
		{
		}

		/// <summary>Combines two path strings.</summary>
		/// <returns>A string containing the combined paths. If one of the specified paths is a zero-length string, this method returns the other path. If <paramref name="path2" /> contains an absolute path, this method returns <paramref name="path2" />.</returns>
		/// <param name="path1">The first path. </param>
		/// <param name="path2">The second path. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path1" /> or <paramref name="path2" /> contain one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path1" /> or <paramref name="path2" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static string Combine(string path1, string path2)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string CleanPath(string s)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the directory information for the specified path string.</summary>
		/// <returns>A <see cref="T:System.String" /> containing directory information for <paramref name="path" />, or null if <paramref name="path" /> denotes a root directory or is null. Returns <see cref="F:System.String.Empty" /> if <paramref name="path" /> does not contain directory information.</returns>
		/// <param name="path">The path of a file or directory. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="path" /> parameter contains invalid characters, is empty, or contains only white spaces. </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The <paramref name="path" /> parameter is longer than the system-defined maximum length.</exception>
		/// <filterpriority>1</filterpriority>
		public static string GetDirectoryName(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the file name and extension of the specified path string.</summary>
		/// <returns>A <see cref="T:System.String" /> consisting of the characters after the last directory character in <paramref name="path" />. If the last character of <paramref name="path" /> is a directory or volume separator character, this method returns <see cref="F:System.String.Empty" />. If <paramref name="path" /> is null, this method returns null.</returns>
		/// <param name="path">The path string from which to obtain the file name and extension. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static string GetFileName(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the absolute path for the specified path string.</summary>
		/// <returns>A string containing the fully qualified location of <paramref name="path" />, such as "C:\MyFile.txt".</returns>
		/// <param name="path">The file or directory for which to obtain absolute path information. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> is a zero-length string, contains only white space, or contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- The system could not retrieve the absolute path. </exception>
		/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permissions. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="path" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <paramref name="path" /> contains a colon (":") that is not part of a volume identifier (for example, "c:\"). </exception>
		/// <exception cref="T:System.IO.PathTooLongException">The specified path, file name, or both exceed the system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file names must be less than 260 characters. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public static string GetFullPath(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string WindowsDriveAdjustment(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string InsecureGetFullPath(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool IsDsc(char c)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Gets the root directory information of the specified path.</summary>
		/// <returns>A string containing the root directory of <paramref name="path" />, such as "C:\", or null if <paramref name="path" /> is null, or an empty string if <paramref name="path" /> does not contain root directory information.</returns>
		/// <param name="path">The path from which to obtain root directory information. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />.-or- <see cref="F:System.String.Empty" /> was passed to <paramref name="path" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static string GetPathRoot(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets a value indicating whether the specified path string contains absolute or relative path information.</summary>
		/// <returns>true if <paramref name="path" /> contains an absolute path; otherwise, false.</returns>
		/// <param name="path">The path to test. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="path" /> contains one or more of the invalid characters defined in <see cref="M:System.IO.Path.GetInvalidPathChars" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static bool IsPathRooted(string path)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Gets an array containing the characters that are not allowed in path names.</summary>
		/// <returns>An array containing the characters that are not allowed in path names.</returns>
		public static char[] GetInvalidPathChars()
		{
			return (char[])/*Error near IL_0001: Stack underflow*/;
		}

		private static string GetServerAndShare(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool SameRoot(string root, string path)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static string CanonicalizePath(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
