using System.Runtime.InteropServices;

namespace System.Resources
{
	/// <summary>Informs the <see cref="T:System.Resources.ResourceManager" /> of the neutral culture of an assembly. This class cannot be inherited.</summary>
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class NeutralResourcesLanguageAttribute : Attribute
	{
		private string culture;

		private UltimateResourceFallbackLocation loc;

		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.NeutralResourcesLanguageAttribute" /> class.</summary>
		/// <param name="cultureName">The name of the culture that the current assembly's neutral resources were written in. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="cultureName" /> parameter is null. </exception>
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
		}
	}
}
