using System;
using UnityEngine;

// Token: 0x0200000F RID: 15
[AddComponentMenu("NGUI/Interaction/Button Keys")]
[RequireComponent(typeof(Collider))]
public class UIButtonKeys : MonoBehaviour
{
	// Token: 0x06000067 RID: 103 RVA: 0x000021E8 File Offset: 0x000003E8
	private void Start()
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000021EC File Offset: 0x000003EC
	private void OnKey(KeyCode key)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000021F0 File Offset: 0x000003F0
	private void OnClick()
	{
	}

	// Token: 0x04000037 RID: 55
	public bool startsSelected;

	// Token: 0x04000038 RID: 56
	public UIButtonKeys selectOnClick;

	// Token: 0x04000039 RID: 57
	public UIButtonKeys selectOnUp;

	// Token: 0x0400003A RID: 58
	public UIButtonKeys selectOnDown;

	// Token: 0x0400003B RID: 59
	public UIButtonKeys selectOnLeft;

	// Token: 0x0400003C RID: 60
	public UIButtonKeys selectOnRight;
}
