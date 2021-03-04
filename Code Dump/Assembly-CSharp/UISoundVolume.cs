using System;
using UnityEngine;

// Token: 0x02000034 RID: 52
[AddComponentMenu("NGUI/Interaction/Sound Volume")]
[RequireComponent(typeof(UISlider))]
public class UISoundVolume : MonoBehaviour
{
	// Token: 0x06000149 RID: 329 RVA: 0x00002570 File Offset: 0x00000770
	private void Awake()
	{
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00002574 File Offset: 0x00000774
	private void OnSliderChange(float val)
	{
	}

	// Token: 0x0400014C RID: 332
	private UISlider mSlider;
}
