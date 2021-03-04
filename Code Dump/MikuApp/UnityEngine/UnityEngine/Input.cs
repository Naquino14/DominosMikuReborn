using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Input
	{
		private static Gyroscope m_MainGyro;

		private static LocationService locationServiceInstance;

		private static Compass compassInstance;

		public static Vector3 mousePosition
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static string inputString
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static int touchCount
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static IMECompositionMode imeCompositionMode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static string compositionString
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static Vector2 compositionCursorPos
		{
			set
			{
			}
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool GetKeyInt(int key);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool GetKeyUpInt(int key);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool GetKeyDownInt(int key);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern float GetAxis(string axisName);

		public static bool GetKey(KeyCode key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool GetKeyDown(KeyCode key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool GetKeyUp(KeyCode key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool GetMouseButton(int button);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool GetMouseButtonDown(int button);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool GetMouseButtonUp(int button);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern Touch GetTouch(int index);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_set_compositionCursorPos(ref Vector2 value);
	}
}
