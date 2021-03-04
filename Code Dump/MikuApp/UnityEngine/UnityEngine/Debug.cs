using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Debug
	{
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_DrawLine(ref Vector3 start, ref Vector3 end, ref Color color, float duration, bool depthTest);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_Log(int level, string msg, [Writable] Object obj);

		public static void Log(object message)
		{
		}

		public static void LogError(object message)
		{
		}

		public static void LogError(object message, Object context)
		{
		}

		public static void LogWarning(object message)
		{
		}

		public static void LogWarning(object message, Object context)
		{
		}
	}
}
