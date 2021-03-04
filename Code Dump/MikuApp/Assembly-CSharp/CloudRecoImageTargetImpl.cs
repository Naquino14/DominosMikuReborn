using System.Collections.Generic;
using UnityEngine;

public class CloudRecoImageTargetImpl : TrackableImpl, ImageTarget, Trackable
{
	private readonly Vector2 mSize;

	public ImageTargetType ImageTargetType => (ImageTargetType)/*Error near IL_0001: Stack underflow*/;

	public CloudRecoImageTargetImpl(string name, int id, Vector2 size)
	{
	}

	public Vector2 GetSize()
	{
		return (Vector2)/*Error near IL_0001: Stack underflow*/;
	}

	public void SetSize(Vector2 size)
	{
	}

	public VirtualButton CreateVirtualButton(string name, VirtualButton.RectangleData area)
	{
		return (VirtualButton)/*Error near IL_0001: Stack underflow*/;
	}

	public VirtualButton GetVirtualButtonByName(string name)
	{
		return (VirtualButton)/*Error near IL_0001: Stack underflow*/;
	}

	public IEnumerable<VirtualButton> GetVirtualButtons()
	{
		return (IEnumerable<VirtualButton>)/*Error near IL_0001: Stack underflow*/;
	}

	public bool DestroyVirtualButton(VirtualButton vb)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
