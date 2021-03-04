using System.Reflection;

namespace UnityEngine
{
	[DefaultMember("Item")]
	public struct Vector4
	{
		public const float kEpsilon = 1E-05f;

		public float x;

		public float y;

		public float z;

		public float w;

		public static Vector4 zero => (Vector4)/*Error near IL_0001: Stack underflow*/;

		public Vector4(float x, float y, float z, float w)
		{
		}

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool Equals(object other)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static float Dot(Vector4 a, Vector4 b)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static float SqrMagnitude(Vector4 a)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return (Vector4)/*Error near IL_0001: Stack underflow*/;
		}

		public static Vector4 operator *(Vector4 a, float d)
		{
			return (Vector4)/*Error near IL_0001: Stack underflow*/;
		}

		public static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static implicit operator Vector4(Vector2 v)
		{
			return (Vector4)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
