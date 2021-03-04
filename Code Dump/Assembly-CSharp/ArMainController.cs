using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

// Token: 0x02000126 RID: 294
public class ArMainController : MonoBehaviour
{
	// Token: 0x0600093D RID: 2365 RVA: 0x00003FF0 File Offset: 0x000021F0
	private void Awake()
	{
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00003FF4 File Offset: 0x000021F4
	private void Update()
	{
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00003FF8 File Offset: 0x000021F8
	private void OnEnable()
	{
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x00003FFC File Offset: 0x000021FC
	private void OnDisable()
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00004000 File Offset: 0x00002200
	private void OnCloseClick()
	{
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00004004 File Offset: 0x00002204
	private void OnDownloadCompleted()
	{
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x00004008 File Offset: 0x00002208
	[DebuggerHidden]
	private IEnumerator ShowHelpAuto()
	{
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x0000400C File Offset: 0x0000220C
	private void OnArInited()
	{
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00004010 File Offset: 0x00002210
	private void OnTrackingFound(string obj)
	{
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00004014 File Offset: 0x00002214
	private void ShowRootAfterFound()
	{
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00004018 File Offset: 0x00002218
	private void OnTrackingLost()
	{
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x0000401C File Offset: 0x0000221C
	private void PlayMiku()
	{
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00004020 File Offset: 0x00002220
	private void ResumeMiku()
	{
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00004024 File Offset: 0x00002224
	private void PauseMiku()
	{
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00004028 File Offset: 0x00002228
	[DebuggerHidden]
	private IEnumerator OnApplicationPause(bool pause)
	{
	}

	// Token: 0x040005EF RID: 1519
	private const string MIKU_ANIM = "Take 001";

	// Token: 0x040005F0 RID: 1520
	private const string ASHI_ANIM = "Take 001";

	// Token: 0x040005F1 RID: 1521
	private const string FLOOR_ANIM = "FloorAnimation";

	// Token: 0x040005F2 RID: 1522
	public float deltaTime;

	// Token: 0x040005F3 RID: 1523
	public ArController _arCtrl;

	// Token: 0x040005F4 RID: 1524
	public ArUIController _arUICtrl;

	// Token: 0x040005F5 RID: 1525
	public ArDLController _arDlCtrl;

	// Token: 0x040005F6 RID: 1526
	public ArBlinkController _arBlinkCtrl;

	// Token: 0x040005F7 RID: 1527
	public ArBlinkScriptController _arBlinkScriptCtrl;

	// Token: 0x040005F8 RID: 1528
	private bool _IsFirstFound;

	// Token: 0x040005F9 RID: 1529
	private bool _IsFinished;

	// Token: 0x040005FA RID: 1530
	private bool _IsSoundPlayed;

	// Token: 0x040005FB RID: 1531
	private GameObject _miku;

	// Token: 0x040005FC RID: 1532
	private GameObject _floor;

	// Token: 0x040005FD RID: 1533
	private GameObject _ashi;

	// Token: 0x040005FE RID: 1534
	private bool _IsClosed;
}
