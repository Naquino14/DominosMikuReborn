using System.Reflection;

namespace UnityEngine
{
	[DefaultMember("Item")]
	public struct Color
	{
		public float r;

		public float g;

		public float b;

		public float a;

		public static Color red => (Color)/*Error near IL_0001: Stack underflow*/;

		public static Color green => (Color)/*Error near IL_0001: Stack underflow*/;

		public static Color white => (Color)/*Error near IL_0001: Stack underflow*/;

		public static Color black => (Color)/*Error near IL_0001: Stack underflow*/;

		public static Color yellow => (Color)/*Error near IL_0001: Stack underflow*/;

		public static Color grey => (Color)/*Error near IL_0001: Stack underflow*/;

		public Color(float r, float g, float b, float a)
		{
		}

		public Color(float r, float g, float b)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool Equals(object other)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static Color Lerp(Color a, Color b, float t)
		{
			return (Color)/*Error near IL_0001: Stack underflow*/;
		}

		public static Color operator *(Color a, float b)
		{
			return (Color)/*Error near IL_0001: Stack underflow*/;
		}

		public static bool operator !=(Color lhs, Color rhs)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static implicit operator Vector4(Color c)
		{
			return (Vector4)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
