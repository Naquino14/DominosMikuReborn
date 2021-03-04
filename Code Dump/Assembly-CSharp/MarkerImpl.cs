using System;
using System.Runtime.CompilerServices;

// Token: 0x020000AC RID: 172
public class MarkerImpl : TrackableImpl, Marker, Trackable
{
	// Token: 0x060004D8 RID: 1240 RVA: 0x000031C0 File Offset: 0x000013C0
	public MarkerImpl(string name, int id, float size, int markerID)
	{
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x000031C4 File Offset: 0x000013C4
	public float GetSize()
	{
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x060004DA RID: 1242 RVA: 0x000031C8 File Offset: 0x000013C8
	// (set) Token: 0x060004DB RID: 1243 RVA: 0x000031CC File Offset: 0x000013CC
	public int MarkerID
	{
		[CompilerGenerated]
		get
		{
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x040003D4 RID: 980
	private readonly float mSize;
}
