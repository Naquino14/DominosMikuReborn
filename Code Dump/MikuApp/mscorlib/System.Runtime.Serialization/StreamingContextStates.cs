using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Defines a set of flags that specifies the source or destination context for the stream during serialization.</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum StreamingContextStates
	{
		/// <summary>Specifies that the source or destination context is a different process on the same computer.</summary>
		CrossProcess = 0x1,
		/// <summary>Specifies that the source or destination context is a different computer.</summary>
		CrossMachine = 0x2,
		/// <summary>Specifies that the source or destination context is a file. Users can assume that files will last longer than the process that created them and not serialize objects in such a way that deserialization will require accessing any data from the current process.</summary>
		File = 0x4,
		/// <summary>Specifies that the source or destination context is a persisted store, which could include databases, files, or other backing stores. Users can assume that persisted data will last longer than the process that created the data and not serialize objects so that deserialization will require accessing any data from the current process.</summary>
		Persistence = 0x8,
		/// <summary>Specifies that the data is remoted to a context in an unknown location. Users cannot make any assumptions whether this is on the same computer.</summary>
		Remoting = 0x10,
		/// <summary>Specifies that the serialization context is unknown.</summary>
		Other = 0x20,
		/// <summary>Specifies that the object graph is being cloned. Users can assume that the cloned graph will continue to exist within the same process and be safe to access handles or other references to unmanaged resources.</summary>
		Clone = 0x40,
		/// <summary>Specifies that the source or destination context is a different AppDomain. (For a description of AppDomains, see Application Domains).</summary>
		CrossAppDomain = 0x80,
		/// <summary>Specifies that the serialized data can be transmitted to or received from any of the other contexts.</summary>
		All = 0xFF
	}
}
