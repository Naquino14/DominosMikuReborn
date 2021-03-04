public class VirtualButtonImpl : VirtualButton
{
	private string mName;

	private int mID;

	private RectangleData mArea;

	private bool mIsEnabled;

	private ImageTarget mParentImageTarget;

	private DataSetImpl mParentDataSet;

	public override string Name => (string)/*Error near IL_0001: Stack underflow*/;

	public override int ID => (int)/*Error near IL_0001: Stack underflow*/;

	public override bool Enabled => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

	public override RectangleData Area => (RectangleData)/*Error near IL_0001: Stack underflow*/;

	public VirtualButtonImpl(string name, int id, RectangleData area, ImageTarget imageTarget, DataSet dataSet)
	{
	}

	public override bool SetArea(RectangleData area)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool SetSensitivity(Sensitivity sensitivity)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}

	public override bool SetEnabled(bool enabled)
	{
		return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
	}
}
