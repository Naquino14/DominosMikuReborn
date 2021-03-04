using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Provides a text description for an assembly.</summary>
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	[ComVisible(true)]
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		private string name;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyDescriptionAttribute" /> class.</summary>
		/// <param name="description">The assembly description. </param>
		public AssemblyDescriptionAttribute(string description)
		{
		}
	}
}
