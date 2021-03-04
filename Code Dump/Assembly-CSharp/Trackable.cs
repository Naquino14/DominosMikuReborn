using System;

// Token: 0x020000E8 RID: 232
public interface Trackable
{
	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000720 RID: 1824
	TrackableType Type { get; }

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000721 RID: 1825
	string Name { get; }

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000722 RID: 1826
	int ID { get; }
}
