using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	[Obsolete("iPhoneKeyboard class is deprecated. Please use TouchScreenKeyboard instead.")]
	public sealed class iPhoneKeyboard
	{
		private IntPtr keyboardWrapper;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Destroy();

		~iPhoneKeyboard()
		{
		}
	}
}
