using System.Runtime.InteropServices;

namespace System.IO
{
	/// <summary>Provides attributes for files and directories.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum FileAttributes
	{
		/// <summary>The file's archive status. Applications use this attribute to mark files for backup or removal.</summary>
		Archive = 0x20,
		/// <summary>The file is compressed.</summary>
		Compressed = 0x800,
		/// <summary>Reserved for future use.</summary>
		Device = 0x40,
		/// <summary>The file is a directory.</summary>
		Directory = 0x10,
		/// <summary>The file or directory is encrypted. For a file, this means that all data in the file is encrypted. For a directory, this means that encryption is the default for newly created files and directories.</summary>
		Encrypted = 0x4000,
		/// <summary>The file is hidden, and thus is not included in an ordinary directory listing.</summary>
		Hidden = 0x2,
		/// <summary>The file is normal and has no other attributes set. This attribute is valid only if used alone.</summary>
		Normal = 0x80,
		/// <summary>The file will not be indexed by the operating system's content indexing service.</summary>
		NotContentIndexed = 0x2000,
		/// <summary>The file is offline. The data of the file is not immediately available.</summary>
		Offline = 0x1000,
		/// <summary>The file is read-only.</summary>
		ReadOnly = 0x1,
		/// <summary>The file contains a reparse point, which is a block of user-defined data associated with a file or a directory.</summary>
		ReparsePoint = 0x400,
		/// <summary>The file is a sparse file. Sparse files are typically large files whose data are mostly zeros.</summary>
		SparseFile = 0x200,
		/// <summary>The file is a system file. The file is part of the operating system or is used exclusively by the operating system.</summary>
		System = 0x4,
		/// <summary>The file is temporary. File systems attempt to keep all of the data in memory for quicker access rather than flushing the data back to mass storage. A temporary file should be deleted by the application as soon as it is no longer needed.</summary>
		Temporary = 0x100
	}
}
