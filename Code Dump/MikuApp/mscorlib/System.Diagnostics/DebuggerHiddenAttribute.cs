using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Hides the code from the debugger. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
	[ComVisible(true)]
	public sealed class DebuggerHiddenAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DebuggerHiddenAttribute" /> class. </summary>
		public DebuggerHiddenAttribute()
		{
		}
	}
}
