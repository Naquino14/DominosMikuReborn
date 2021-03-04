using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class TouchScreenKeyboard
	{
		private IntPtr keyboardWrapper;

		public string text
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool active
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public bool done
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Destroy();

		~TouchScreenKeyboard()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void TouchScreenKeyboard_InternalConstructorHelper(TouchScreenKeyboard_InternalConstructorHelperArguments arguments);

		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert)
		{
			return (TouchScreenKeyboard)/*Error near IL_0001: Stack underflow*/;
		}

		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure)
		{
			return (TouchScreenKeyboard)/*Error near IL_0001: Stack underflow*/;
		}

		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
		{
			return (TouchScreenKeyboard)/*Error near IL_0001: Stack underflow*/;
		}

		public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder)
		{
			return (TouchScreenKeyboard)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
