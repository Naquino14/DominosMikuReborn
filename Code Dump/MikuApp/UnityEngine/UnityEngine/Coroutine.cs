using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public sealed class Coroutine : YieldInstruction
	{
		internal IntPtr m_Ptr;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void ReleaseCoroutine();

		~Coroutine()
		{
		}
	}
}
