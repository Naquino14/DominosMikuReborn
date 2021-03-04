using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public sealed class AnimationEvent
	{
		[NotRenamed]
		internal IntPtr m_Ptr;

		private int m_OwnsData;

		~AnimationEvent()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Destroy();
	}
}
