namespace System.Security
{
	/// <summary>Identifies types or members as security-critical and safely accessible by transparent code.</summary>
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[MonoTODO("Only supported by the runtime when CoreCLR is enabled")]
	public sealed class SecuritySafeCriticalAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SecuritySafeCriticalAttribute" /> class. </summary>
		public SecuritySafeCriticalAttribute()
		{
		}
	}
}
