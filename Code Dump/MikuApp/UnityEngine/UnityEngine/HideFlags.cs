using System;

namespace UnityEngine
{
	[Flags]
	public enum HideFlags
	{
		HideInHierarchy = 0x1,
		HideInInspector = 0x2,
		DontSave = 0x4,
		NotEditable = 0x8,
		HideAndDontSave = 0xD
	}
}
