using System.Runtime.InteropServices;

namespace System
{
	/// <summary>
	///   <see cref="T:System.EventArgs" /> is the base class for classes containing event data. </summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class EventArgs
	{
		/// <summary>Represents an event with no event data.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly EventArgs Empty;

		/// <summary>Initializes a new instance of the <see cref="T:System.EventArgs" /> class.</summary>
		public EventArgs()
		{
		}
	}
}
