using System;
using System.Collections;
using System.Diagnostics;
using Prime31;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class FacebookGUIManager : MonoBehaviourGUI
{
	// Token: 0x060002B1 RID: 689 RVA: 0x000029AC File Offset: 0x00000BAC
	private void completionHandler(string error, object result)
	{
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x000029B0 File Offset: 0x00000BB0
	private void Start()
	{
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x000029B4 File Offset: 0x00000BB4
	private void OnGUI()
	{
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x000029B8 File Offset: 0x00000BB8
	private void secondColumnButtonsGUI()
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x000029BC File Offset: 0x00000BBC
	private void secondColumnAdditionalButtonsGUI()
	{
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x000029C0 File Offset: 0x00000BC0
	[DebuggerHidden]
	private IEnumerator fetchAndShowProfileImage()
	{
	}

	// Token: 0x040000F0 RID: 240
	public GameObject cube;

	// Token: 0x040000F1 RID: 241
	private string _userId;

	// Token: 0x040000F2 RID: 242
	private bool _canUserUseFacebookComposer;

	// Token: 0x040000F3 RID: 243
	private bool _hasPublishPermission;

	// Token: 0x040000F4 RID: 244
	private bool _hasPublishActions;

	// Token: 0x040000F5 RID: 245
	public static string screenshotFilename;
}
