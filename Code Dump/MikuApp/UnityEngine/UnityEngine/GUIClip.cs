using System.Runtime.CompilerServices;

namespace UnityEngine
{
	internal sealed class GUIClip
	{
		internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Push(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void Pop();

		public static Vector2 Unclip(Vector2 pos)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		private static void Unclip_Vector2(ref Vector2 pos)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Unclip_Vector2(ref Vector2 pos);

		public static Rect Unclip(Rect rect)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		private static void Unclip_Rect(ref Rect rect)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Unclip_Rect(ref Rect rect);

		public static Vector2 Clip(Vector2 absolutePos)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		private static void Clip_Vector2(ref Vector2 absolutePos)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_Clip_Vector2(ref Vector2 absolutePos);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern Matrix4x4 GetMatrix();

		internal static void SetMatrix(Matrix4x4 m)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_SetMatrix(ref Matrix4x4 m);
	}
}
