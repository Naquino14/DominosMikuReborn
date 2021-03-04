using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public class ScriptableObject : Object
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_CreateScriptableObject([Writable] ScriptableObject self);
	}
}
