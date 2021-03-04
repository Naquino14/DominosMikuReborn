using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class MeshFilter : Component
	{
		public Mesh mesh
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}
	}
}
