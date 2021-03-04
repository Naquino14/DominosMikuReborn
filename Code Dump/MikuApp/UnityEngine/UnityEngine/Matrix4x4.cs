using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public struct Matrix4x4
	{
		public float m00;

		public float m10;

		public float m20;

		public float m30;

		public float m01;

		public float m11;

		public float m21;

		public float m31;

		public float m02;

		public float m12;

		public float m22;

		public float m32;

		public float m03;

		public float m13;

		public float m23;

		public float m33;

		public float this[int row, int column] => (float)/*Error near IL_0001: Stack underflow*/;

		public float this[int index]
		{
			get
			{
				return (float)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public static Matrix4x4 zero => (Matrix4x4)/*Error near IL_0001: Stack underflow*/;

		public static Matrix4x4 identity => (Matrix4x4)/*Error near IL_0001: Stack underflow*/;

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool Equals(object other)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public Vector4 GetColumn(int i)
		{
			return (Vector4)/*Error near IL_0001: Stack underflow*/;
		}

		public Vector3 MultiplyPoint3x4(Vector3 v)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		public Vector3 MultiplyVector(Vector3 v)
		{
			return (Vector3)/*Error near IL_0001: Stack underflow*/;
		}

		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			return (Matrix4x4)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Matrix4x4 INTERNAL_CALL_TRS(ref Vector3 pos, ref Quaternion q, ref Vector3 s);

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return (Matrix4x4)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
