using System;
using UnityEngine;

// Token: 0x0200001C RID: 28
[AddComponentMenu("NGUI/Interaction/Checkbox Controlled Object")]
public class UICheckboxControlledObject : MonoBehaviour
{
	// Token: 0x060000B1 RID: 177 RVA: 0x00002310 File Offset: 0x00000510
	private void OnEnable()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002314 File Offset: 0x00000514
	private void OnActivate(bool isActive)
	{
	}

	// Token: 0x0400009A RID: 154
	public GameObject target;

	// Token: 0x0400009B RID: 155
	public bool inverse;
}
