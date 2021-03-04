using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Shader : Object
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern Shader Find(string name);
	}
}
