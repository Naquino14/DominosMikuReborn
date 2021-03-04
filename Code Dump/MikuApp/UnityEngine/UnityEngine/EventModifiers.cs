using System;

namespace UnityEngine
{
	[Flags]
	public enum EventModifiers
	{
		Shift = 0x1,
		Control = 0x2,
		Alt = 0x4,
		Command = 0x8,
		Numeric = 0x10,
		CapsLock = 0x20,
		FunctionKey = 0x40
	}
}
