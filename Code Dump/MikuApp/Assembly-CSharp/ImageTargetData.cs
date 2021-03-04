using System.Runtime.InteropServices;
using UnityEngine;

[StructLayout(0, Pack = 1)]
public struct ImageTargetData
{
	public int id;

	[MarshalAs(30, SizeConst = 2)]
	public Vector2 size;
}
