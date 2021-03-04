using System;
using UnityEngine;

// Token: 0x0200002E RID: 46
[AddComponentMenu("NGUI/Interaction/Saved Option")]
public class UISavedOption : MonoBehaviour
{
	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000116 RID: 278 RVA: 0x000024A4 File Offset: 0x000006A4
	private string key
	{
		get
		{
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x000024A8 File Offset: 0x000006A8
	private void Awake()
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x000024AC File Offset: 0x000006AC
	private void OnDestroy()
	{
	}

	// Token: 0x06000119 RID: 281 RVA: 0x000024B0 File Offset: 0x000006B0
	private void OnEnable()
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x000024B4 File Offset: 0x000006B4
	private void OnDisable()
	{
	}

	// Token: 0x0600011B RID: 283 RVA: 0x000024B8 File Offset: 0x000006B8
	private void SaveSelection(string selection)
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x000024BC File Offset: 0x000006BC
	private void SaveState(bool state)
	{
	}

	// Token: 0x04000124 RID: 292
	public string keyName;

	// Token: 0x04000125 RID: 293
	private UIPopupList mList;

	// Token: 0x04000126 RID: 294
	private UICheckbox mCheck;
}
