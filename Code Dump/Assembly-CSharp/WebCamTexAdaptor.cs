using System;
using UnityEngine;

// Token: 0x020000C6 RID: 198
public abstract class WebCamTexAdaptor
{
	// Token: 0x17000100 RID: 256
	// (get) Token: 0x0600056C RID: 1388
	public abstract bool DidUpdateThisFrame { get; }

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600056D RID: 1389
	public abstract bool IsPlaying { get; }

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600056E RID: 1390
	public abstract Texture Texture { get; }

	// Token: 0x0600056F RID: 1391
	public abstract void Play();

	// Token: 0x06000570 RID: 1392
	public abstract void Stop();
}
