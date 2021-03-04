using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class Physics
	{
		public const int kIgnoreRaycastLayer = 4;

		public const int kDefaultRaycastLayers = -5;

		public const int kAllLayers = -1;

		private static bool Internal_Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float distance, int layermask)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool INTERNAL_CALL_Internal_Raycast(ref Vector3 origin, ref Vector3 direction, out RaycastHit hitInfo, float distance, int layermask);

		public static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float distance, int layerMask)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Raycast(Ray ray, out RaycastHit hitInfo)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool Raycast(Ray ray, out RaycastHit hitInfo, float distance, int layerMask)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static RaycastHit[] RaycastAll(Ray ray, float distance, int layerMask)
		{
			return (RaycastHit[])/*Error near IL_0001: Stack underflow*/;
		}

		public static RaycastHit[] RaycastAll(Vector3 origin, Vector3 direction, float distance, int layermask)
		{
			return (RaycastHit[])/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern RaycastHit[] INTERNAL_CALL_RaycastAll(ref Vector3 origin, ref Vector3 direction, float distance, int layermask);
	}
}
