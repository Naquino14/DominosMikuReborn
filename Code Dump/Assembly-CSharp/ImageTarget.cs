using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000099 RID: 153
public interface ImageTarget : Trackable
{
	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000414 RID: 1044
	ImageTargetType ImageTargetType { get; }

	// Token: 0x06000415 RID: 1045
	Vector2 GetSize();

	// Token: 0x06000416 RID: 1046
	void SetSize(Vector2 size);

	// Token: 0x06000417 RID: 1047
	VirtualButton CreateVirtualButton(string name, VirtualButton.RectangleData area);

	// Token: 0x06000418 RID: 1048
	VirtualButton GetVirtualButtonByName(string name);

	// Token: 0x06000419 RID: 1049
	IEnumerable<VirtualButton> GetVirtualButtons();

	// Token: 0x0600041A RID: 1050
	bool DestroyVirtualButton(VirtualButton vb);
}
