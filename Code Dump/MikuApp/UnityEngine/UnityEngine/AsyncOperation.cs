using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public class AsyncOperation : YieldInstruction
	{
		[NotRenamed]
		internal IntPtr m_Ptr;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void InternalDestroy();

		~AsyncOperation()
		{
		}
	}
}
