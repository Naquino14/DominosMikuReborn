using System.Runtime.InteropServices;

namespace System.Resources
{
	/// <summary>Instructs the <see cref="T:System.Resources.ResourceManager" /> to ask for a particular version of a satellite assembly to simplify updates of the main assembly of an application.</summary>
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		private Version ver;

		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> class.</summary>
		/// <param name="version">A <see cref="T:System.String" /> with the version of the satellite assemblies to load. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="version" /> parameter is null. </exception>
		public SatelliteContractVersionAttribute(string version)
		{
		}
	}
}
