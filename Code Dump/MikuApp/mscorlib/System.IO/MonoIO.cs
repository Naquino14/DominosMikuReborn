using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.IO
{
	internal sealed class MonoIO
	{
		public static readonly FileAttributes InvalidFileAttributes;

		public static readonly IntPtr InvalidHandle;

		public static IntPtr ConsoleOutput
		{
			[MethodImpl(4096)]
			get;
		}

		public static IntPtr ConsoleInput
		{
			[MethodImpl(4096)]
			get;
		}

		public static IntPtr ConsoleError
		{
			[MethodImpl(4096)]
			get;
		}

		public static char VolumeSeparatorChar
		{
			[MethodImpl(4096)]
			get;
		}

		public static char DirectorySeparatorChar
		{
			[MethodImpl(4096)]
			get;
		}

		public static char AltDirectorySeparatorChar
		{
			[MethodImpl(4096)]
			get;
		}

		public static char PathSeparator
		{
			[MethodImpl(4096)]
			get;
		}

		public static Exception GetException(MonoIOError error)
		{
			return (Exception)/*Error near IL_0001: Stack underflow*/;
		}

		public static Exception GetException(string path, MonoIOError error)
		{
			return (Exception)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		public static extern string GetCurrentDirectory(out MonoIOError error);

		[MethodImpl(4096)]
		public static extern bool SetCurrentDirectory(string path, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern bool DeleteFile(string path, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern FileAttributes GetFileAttributes(string path, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern MonoFileType GetFileType(IntPtr handle, out MonoIOError error);

		public static bool ExistsFile(string path, out MonoIOError error)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool ExistsDirectory(string path, out MonoIOError error)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		public static extern bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern bool Close(IntPtr handle, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern long GetLength(IntPtr handle, out MonoIOError error);

		[MethodImpl(4096)]
		public static extern bool SetLength(IntPtr handle, long length, out MonoIOError error);
	}
}
