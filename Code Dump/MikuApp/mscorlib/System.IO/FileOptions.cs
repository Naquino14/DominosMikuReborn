using System.Runtime.InteropServices;

namespace System.IO
{
	/// <summary>Represents additional options for creating a <see cref="T:System.IO.FileStream" /> object.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	[Flags]
	public enum FileOptions
	{
		/// <summary>Indicates no additional parameters.</summary>
		None = 0x0,
		/// <summary>Indicates that a file is encrypted and can be decrypted only by using the same user account used for encryption.</summary>
		Encrypted = 0x4000,
		/// <summary>Indicates that a file is automatically deleted when it is no longer in use.</summary>
		DeleteOnClose = 0x4000000,
		/// <summary>Indicates that the file is to be accessed sequentially from beginning to end. The system can use this as a hint to optimize file caching. If an application moves the file pointer for random access, optimum caching may not occur; however, correct operation is still guaranteed. </summary>
		SequentialScan = 0x8000000,
		/// <summary>Indicates that the file is accessed randomly. The system can use this as a hint to optimize file caching.</summary>
		RandomAccess = 0x10000000,
		/// <summary>Indicates that a file can be used for asynchronous reading and writing. </summary>
		Asynchronous = 0x40000000,
		/// <summary>Indicates that the system should write through any intermediate cache and go directly to disk.</summary>
		WriteThrough = int.MinValue
	}
}
