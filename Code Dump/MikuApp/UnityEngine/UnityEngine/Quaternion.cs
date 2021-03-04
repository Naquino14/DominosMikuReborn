using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	[DefaultMember("Item")]
	public struct Quaternion
	{
		public const float kEpsilon = 1E-06f;

		public float x;

		public float y;

		public float z;

		public float w;

		public static Quaternion identity => (Quaternion)/*Error near IL_0001: Stack underflow*/;

		public Vector3 eulerAngles => (Vector3)/*Error near IL_0001: Stack underflow*/;

		public Quaternion(float x, float y, float z, float w)
		{
		}

		public static float Dot(Quaternion a, Quaternion b)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Quaternion INTERNAL_CALL_AngleAxis(float angle, ref Vector3 axis);

		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Quaternion INTERNAL_CALL_FromToRotation(ref Vector3 fromDirection, ref Vector3 toDirection);

		public static Quaternion LookRotation(Vector3 forward)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Quaternion INTERNAL_CALL_LookRotation(ref Vector3 forward, ref Vector3 upwards);

		public static Quaternion Slerp(Quaternion from, Quaternion to, float t)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Quaternion INTERNAL_CALL_Slerp(ref Quaternion from, ref Quaternion to, float t);

		public static Quaternion Inverse(Quaternion rotation)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Quaternion INTERNAL_CALL_Inverse(ref Quaternion rotation);

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static Quaternion Euler(float x, float y, float z)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		public static Quaternion Euler(Vector3 euler)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Vector3 INTERNAL_CALL_Internal_ToEulerRad(ref Quaternion rotation);

		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Quaternion INTERNAL_CALL_Internal_FromEulerRad(ref Vector3 euler);

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool Equals(object other)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			return (Quaternion)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
