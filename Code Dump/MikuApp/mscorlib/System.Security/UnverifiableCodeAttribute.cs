using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Marks modules containing unverifiable code. This class cannot be inherited.</summary>
	[AttributeUsage(AttributeTargets.Module, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	public sealed class UnverifiableCodeAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.UnverifiableCodeAttribute" /> class. </summary>
		public UnverifiableCodeAttribute()
		{
		}
	}
}
