using System.Runtime.InteropServices;

namespace System.Reflection
{
	/// <summary>Provides information about an <see cref="T:System.Reflection.Assembly" /> reference.</summary>
	[Serializable]
	[ComVisible(true)]
	[Flags]
	public enum AssemblyNameFlags
	{
		/// <summary>Specifies that no flags are in effect.</summary>
		None = 0x0,
		/// <summary>Specifies that a public key is formed from the full public key rather than the public key token.</summary>
		PublicKey = 0x1,
		/// <summary>Specifies that the assembly can be retargeted at runtime to an assembly from a different publisher. This method supports the .NET Framework infrastructure and is not intended to be used directly from your code. </summary>
		Retargetable = 0x100,
		/// <summary>Specifies that just-in-time (JIT) compiler optimization is disabled for the assembly. This is the exact opposite of the meaning that is suggested by the member name. </summary>
		EnableJITcompileOptimizer = 0x4000,
		/// <summary>Specifies that just-in-time (JIT) compiler tracking is enabled for the assembly.</summary>
		EnableJITcompileTracking = 0x8000
	}
}
