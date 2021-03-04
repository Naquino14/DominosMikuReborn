using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Indicates that an enumeration can be treated as a bit field; that is, a set of flags.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[AttributeUsage(AttributeTargets.Enum, Inherited = false)]
	[ComVisible(true)]
	public class FlagsAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.FlagsAttribute" /> class.</summary>
		public FlagsAttribute()
		{
		}
	}
}
