using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyleState
	{
		[NonSerialized]
		[NotRenamed]
		internal IntPtr m_Ptr;

		private GUIStyle m_SourceStyle;

		public Color textColor
		{
			set
			{
			}
		}

		public GUIStyleState()
		{
		}

		internal GUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
		}

		~GUIStyleState()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Init();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Cleanup();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_textColor(ref Color value);
	}
}
