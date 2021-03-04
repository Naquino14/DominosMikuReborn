using System.Runtime.InteropServices;

namespace System.IO
{
	/// <summary>Defines constants for read, write, or read/write access to a file.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum FileAccess
	{
		/// <summary>Read access to the file. Data can be read from the file. Combine with Write for read/write access.</summary>
		Read = 0x1,
		/// <summary>Write access to the file. Data can be written to the file. Combine with Read for read/write access.</summary>
		Write = 0x2,
		/// <summary>Read and write access to the file. Data can be written to and read from the file.</summary>
		ReadWrite = 0x3
	}
}
