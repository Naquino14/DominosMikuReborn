using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Allows managed code to call into unmanaged code without a stack walk. This class cannot be inherited.</summary>
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = true, Inherited = false)]
	public sealed class SuppressUnmanagedCodeSecurityAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.SuppressUnmanagedCodeSecurityAttribute" /> class. </summary>
		public SuppressUnmanagedCodeSecurityAttribute()
		{
		}
	}
}
