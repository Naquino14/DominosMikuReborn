using System.Collections.Generic;
using UnityEngine;

public interface ImageTarget : Trackable
{
	ImageTargetType ImageTargetType
	{
		get;
	}

	Vector2 GetSize();

	void SetSize(Vector2 size);

	VirtualButton CreateVirtualButton(string name, VirtualButton.RectangleData area);

	VirtualButton GetVirtualButtonByName(string name);

	IEnumerable<VirtualButton> GetVirtualButtons();

	bool DestroyVirtualButton(VirtualButton vb);
}
