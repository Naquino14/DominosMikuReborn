using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Specifies the attributes of an event.</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum EventAttributes
	{
		/// <summary>Specifies that the event has no attributes.</summary>
		None = 0x0,
		/// <summary>Specifies that the event is special in a way described by the name.</summary>
		SpecialName = 0x200,
		/// <summary>Specifies a reserved flag for common language runtime use only.</summary>
		ReservedMask = 0x400,
		/// <summary>Specifies that the common language runtime should check name encoding.</summary>
		RTSpecialName = 0x400
	}
}
