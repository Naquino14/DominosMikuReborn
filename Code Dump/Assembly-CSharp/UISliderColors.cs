using System;
using UnityEngine;

// Token: 0x02000033 RID: 51
[ExecuteInEditMode]
[RequireComponent(typeof(UISlider))]
[AddComponentMenu("NGUI/Examples/Slider Colors")]
public class UISliderColors : MonoBehaviour
{
	// Token: 0x06000146 RID: 326 RVA: 0x00002564 File Offset: 0x00000764
	private void Start()
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00002568 File Offset: 0x00000768
	private void Update()
	{
	}

	// Token: 0x04000149 RID: 329
	public UISprite sprite;

	// Token: 0x0400014A RID: 330
	public Color[] colors;

	// Token: 0x0400014B RID: 331
	private UISlider mSlider;
}
