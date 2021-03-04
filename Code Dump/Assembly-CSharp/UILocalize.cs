using System;
using UnityEngine;

// Token: 0x02000071 RID: 113
[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/UI/Localize")]
public class UILocalize : MonoBehaviour
{
	// Token: 0x06000328 RID: 808 RVA: 0x00002CE8 File Offset: 0x00000EE8
	private void OnLocalize(Localization loc)
	{
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00002CEC File Offset: 0x00000EEC
	private void OnEnable()
	{
	}

	// Token: 0x0600032A RID: 810 RVA: 0x00002CF0 File Offset: 0x00000EF0
	private void Start()
	{
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00002CF4 File Offset: 0x00000EF4
	public void Localize()
	{
	}

	// Token: 0x040002FB RID: 763
	public string key;

	// Token: 0x040002FC RID: 764
	private string mLanguage;

	// Token: 0x040002FD RID: 765
	private bool mStarted;
}
