using System;
using UnityEngine;

// Token: 0x0200010C RID: 268
[AddComponentMenu("NGUI/UI/Input (Basic)")]
public class UIInputSysfontName : UIInputSysfont
{
	// Token: 0x06000801 RID: 2049 RVA: 0x00003B00 File Offset: 0x00001D00
	private void Awake()
	{
	}

	// Token: 0x06000802 RID: 2050 RVA: 0x00003B04 File Offset: 0x00001D04
	public override void UpdateLabel()
	{
	}

	// Token: 0x06000803 RID: 2051 RVA: 0x00003B08 File Offset: 0x00001D08
	public override void OnSelect(bool isSelected)
	{
	}

	// Token: 0x06000804 RID: 2052 RVA: 0x00003B0C File Offset: 0x00001D0C
	private string CutText(string processed)
	{
	}

	// Token: 0x0400051D RID: 1309
	[SerializeField]
	private UIInputSysfontName.LabelType _labelType;

	// Token: 0x0200010D RID: 269
	public enum LabelType
	{
		// Token: 0x0400051F RID: 1311
		Name,
		// Token: 0x04000520 RID: 1312
		TeamName,
		// Token: 0x04000521 RID: 1313
		TeamMessage
	}
}
