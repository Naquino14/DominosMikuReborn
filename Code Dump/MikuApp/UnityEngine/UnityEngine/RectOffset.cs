using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[Serializable]
	[StructLayout(0)]
	public sealed class RectOffset
	{
		[NonSerialized]
		[NotRenamed]
		internal IntPtr m_Ptr;

		private GUIStyle m_SourceStyle;

		public int left
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int right
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int top
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int bottom
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public int horizontal
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public int vertical
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public RectOffset()
		{
		}

		internal RectOffset(GUIStyle sourceStyle, IntPtr source)
		{
		}

		public RectOffset(int left, int right, int top, int bottom)
		{
		}

		~RectOffset()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Init();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Cleanup();

		public Rect Add(Rect rect)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Rect INTERNAL_CALL_Add(RectOffset self, ref Rect rect);

		public Rect Remove(Rect rect)
		{
			return (Rect)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Rect INTERNAL_CALL_Remove(RectOffset self, ref Rect rect);

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
