using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Graphics
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void DrawTexture(ref InternalDrawTextureArguments arguments);
	}
}
