using System;
using UnityEngine;

// Token: 0x020000D5 RID: 213
public abstract class QCARManager
{
	// Token: 0x1700010E RID: 270
	// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00003758 File Offset: 0x00001958
	public static QCARManager Instance
	{
		get
		{
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x060006E3 RID: 1763
	// (set) Token: 0x060006E4 RID: 1764
	public abstract QCARBehaviour.WorldCenterMode WorldCenterMode { get; set; }

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x060006E5 RID: 1765
	// (set) Token: 0x060006E6 RID: 1766
	public abstract TrackableBehaviour WorldCenter { get; set; }

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x060006E7 RID: 1767
	// (set) Token: 0x060006E8 RID: 1768
	public abstract Camera ARCamera { get; set; }

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x060006E9 RID: 1769
	// (set) Token: 0x060006EA RID: 1770
	public abstract bool DrawVideoBackground { get; set; }

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x060006EB RID: 1771
	public abstract bool Initialized { get; }

	// Token: 0x060006EC RID: 1772
	public abstract bool Init();

	// Token: 0x060006ED RID: 1773
	public abstract void Deinit();

	// Token: 0x04000458 RID: 1112
	private static QCARManager sInstance;
}
