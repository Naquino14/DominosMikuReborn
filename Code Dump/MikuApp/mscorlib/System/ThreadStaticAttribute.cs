using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Indicates that the value of a static field is unique for each thread.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[AttributeUsage(AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	public class ThreadStaticAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ThreadStaticAttribute" /> class.</summary>
		public ThreadStaticAttribute()
		{
		}
	}
}
