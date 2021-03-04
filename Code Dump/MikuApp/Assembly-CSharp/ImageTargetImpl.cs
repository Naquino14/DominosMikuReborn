using System.Collections.Generic;
using UnityEngine;

public class ImageTargetImpl : TrackableImpl, ImageTarget, Trackable
{
	private Vector2 mSize;

	private readonly DataSetImpl mDataSet;

	private readonly ImageTargetType mImageTargetType;

	private readonly Dictionary<int, VirtualButton> mVirtualButtons;

	public ImageTargetType ImageTargetType => (ImageTargetType)/*Error near IL_0001: Stack underflow*/;

	public ImageTargetImpl(string name, int id, ImageTargetType imageTargetType, DataSet dataSet)
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

	private VirtualButton CreateNewVirtualButtonInNative(string name, VirtualButton.RectangleData rectangleData)
	{
		return (VirtualButton)/*Error near IL_0001: Stack underflow*/;
	}

	private bool UnregisterVirtualButtonInNative(VirtualButton vb)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	private void CreateVirtualButtonsFromNative()
	{
	}
}
