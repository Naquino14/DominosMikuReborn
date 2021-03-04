using System;
using UnityEngine;

// Token: 0x0200006E RID: 110
[AddComponentMenu("NGUI/UI/Input (Saved)")]
public class UIInputSaved : UIInput
{
	// Token: 0x06000300 RID: 768 RVA: 0x00002C48 File Offset: 0x00000E48
	private void Start()
	{
	}

	// Token: 0x06000301 RID: 769 RVA: 0x00002C4C File Offset: 0x00000E4C
	private void OnApplicationQuit()
	{
	}

	// Token: 0x040002DE RID: 734
	public string playerPrefsField;
}
