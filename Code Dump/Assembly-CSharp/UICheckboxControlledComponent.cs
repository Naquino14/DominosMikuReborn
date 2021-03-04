using System;
using UnityEngine;

// Token: 0x0200001B RID: 27
[AddComponentMenu("NGUI/Interaction/Checkbox Controlled Component")]
public class UICheckboxControlledComponent : MonoBehaviour
{
	// Token: 0x060000AD RID: 173 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002304 File Offset: 0x00000504
	private void OnActivateDelegate(bool isActive)
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002308 File Offset: 0x00000508
	private void OnActivate(bool isActive)
	{
	}

	// Token: 0x04000097 RID: 151
	public MonoBehaviour target;

	// Token: 0x04000098 RID: 152
	public bool inverse;

	// Token: 0x04000099 RID: 153
	private bool mUsingDelegates;
}
