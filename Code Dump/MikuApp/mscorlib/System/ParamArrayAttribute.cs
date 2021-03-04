using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Indicates that the method will allow a variable number of arguments in its invocation. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	[AttributeUsage(AttributeTargets.Parameter)]
	[ComVisible(true)]
	public sealed class ParamArrayAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ParamArrayAttribute" /> class with default properties.</summary>
		public ParamArrayAttribute()
		{
		}
	}
}
