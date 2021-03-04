using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x0200012B RID: 299
public class ArUIShareController : ShareComposerController
{
	// Token: 0x06000970 RID: 2416 RVA: 0x000040BC File Offset: 0x000022BC
	private void Awake()
	{
	}

	// Token: 0x06000971 RID: 2417 RVA: 0x000040C0 File Offset: 0x000022C0
	private void SetAlphaAll(float alpha)
	{
	}

	// Token: 0x06000972 RID: 2418 RVA: 0x000040C4 File Offset: 0x000022C4
	private void Update()
	{
	}

	// Token: 0x06000973 RID: 2419 RVA: 0x000040C8 File Offset: 0x000022C8
	[DebuggerHidden]
	private IEnumerator IERun()
	{
	}

	// Token: 0x06000974 RID: 2420 RVA: 0x000040CC File Offset: 0x000022CC
	protected override void PostFb()
	{
	}

	// Token: 0x06000975 RID: 2421 RVA: 0x000040D0 File Offset: 0x000022D0
	protected override void PostTw()
	{
	}

	// Token: 0x06000976 RID: 2422 RVA: 0x000040D4 File Offset: 0x000022D4
	private void OnAgainClick()
	{
	}

	// Token: 0x06000977 RID: 2423 RVA: 0x000040D8 File Offset: 0x000022D8
	private void OnMikubakuClick()
	{
	}

	// Token: 0x06000978 RID: 2424 RVA: 0x000040DC File Offset: 0x000022DC
	private void OnFacebookClick()
	{
	}

	// Token: 0x06000979 RID: 2425 RVA: 0x000040E0 File Offset: 0x000022E0
	private void OnTwitterClick()
	{
	}

	// Token: 0x04000615 RID: 1557
	public TextAsset fbText;

	// Token: 0x04000616 RID: 1558
	public TextAsset twText;

	// Token: 0x04000617 RID: 1559
	public UISprite title1;

	// Token: 0x04000618 RID: 1560
	public UISprite title2;

	// Token: 0x04000619 RID: 1561
	public UISprite content;

	// Token: 0x0400061A RID: 1562
	public UISprite again;

	// Token: 0x0400061B RID: 1563
	public UISprite back;

	// Token: 0x0400061C RID: 1564
	public UISprite facebook;

	// Token: 0x0400061D RID: 1565
	public UISprite twitter;

	// Token: 0x0400061E RID: 1566
	public UISprite shield;

	// Token: 0x0400061F RID: 1567
	private bool _isInited;
}
