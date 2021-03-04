using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public class TrackedReference
	{
		[NotRenamed]
		internal IntPtr m_Ptr;

		public override bool Equals(object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static bool operator ==(TrackedReference x, TrackedReference y)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool operator !=(TrackedReference x, TrackedReference y)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static implicit operator bool(TrackedReference exists)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
