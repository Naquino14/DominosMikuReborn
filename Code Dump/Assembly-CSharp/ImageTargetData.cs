using System;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000098 RID: 152
[StructLayout(0, Pack = 1)]
public struct ImageTargetData
{
	// Token: 0x040003A8 RID: 936
	public int id;

	// Token: 0x040003A9 RID: 937
	[MarshalAs(30, SizeConst = 2)]
	public Vector2 size;
}
