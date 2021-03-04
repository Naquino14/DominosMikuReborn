using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class GL
	{
		public const int TRIANGLES = 4;

		public const int TRIANGLE_STRIP = 5;

		public const int QUADS = 7;

		public const int LINES = 1;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void SetRevertBackfacing(bool revertBackFaces);

		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor)
		{
		}

		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
		}

		private static void Internal_Clear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Internal_Clear(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void InvalidateState();
	}
}
