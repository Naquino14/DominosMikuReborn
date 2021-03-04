using System;
using System.Runtime.InteropServices;

// Token: 0x020000F1 RID: 241
public abstract class VirtualButton
{
	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600075A RID: 1882
	public abstract string Name { get; }

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x0600075B RID: 1883
	public abstract int ID { get; }

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x0600075C RID: 1884
	public abstract bool Enabled { get; }

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x0600075D RID: 1885
	public abstract VirtualButton.RectangleData Area { get; }

	// Token: 0x0600075E RID: 1886
	public abstract bool SetArea(VirtualButton.RectangleData area);

	// Token: 0x0600075F RID: 1887
	public abstract bool SetSensitivity(VirtualButton.Sensitivity sensitivity);

	// Token: 0x06000760 RID: 1888
	public abstract bool SetEnabled(bool enabled);

	// Token: 0x040004AD RID: 1197
	public const VirtualButton.Sensitivity DEFAULT_SENSITIVITY = VirtualButton.Sensitivity.LOW;

	// Token: 0x020000F2 RID: 242
	public enum Sensitivity
	{
		// Token: 0x040004AF RID: 1199
		HIGH,
		// Token: 0x040004B0 RID: 1200
		MEDIUM,
		// Token: 0x040004B1 RID: 1201
		LOW
	}

	// Token: 0x020000F3 RID: 243
	[StructLayout(0, Pack = 1)]
	public struct RectangleData
	{
		// Token: 0x040004B2 RID: 1202
		public float leftTopX;

		// Token: 0x040004B3 RID: 1203
		public float leftTopY;

		// Token: 0x040004B4 RID: 1204
		public float rightBottomX;

		// Token: 0x040004B5 RID: 1205
		public float rightBottomY;
	}
}
