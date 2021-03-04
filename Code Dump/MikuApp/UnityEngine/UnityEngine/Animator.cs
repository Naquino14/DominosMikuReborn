using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Animator : Behaviour
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern int StringToHash(string name);
	}
}
