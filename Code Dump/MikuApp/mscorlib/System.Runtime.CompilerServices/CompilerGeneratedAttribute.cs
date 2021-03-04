namespace System.Runtime.CompilerServices
{
	/// <summary>Distinguishes a compiler-generated element from a user-generated element. This class cannot be inherited.</summary>
	[Serializable]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class CompilerGeneratedAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.CompilerGeneratedAttribute" /> class.</summary>
		public CompilerGeneratedAttribute()
		{
		}
	}
}
