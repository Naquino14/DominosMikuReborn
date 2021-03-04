using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Defines the base class for all context-bound classes.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public abstract class ContextBoundObject : MarshalByRefObject
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ContextBoundObject" /> class.</summary>
		protected ContextBoundObject()
		{
		}
	}
}
