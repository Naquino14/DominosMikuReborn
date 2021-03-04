using System;
using System.Collections.Generic;

// Token: 0x0200013F RID: 319
public class MSpecialPose
{
	// Token: 0x06000AE2 RID: 2786 RVA: 0x00004684 File Offset: 0x00002884
	public MSpecialPose(string _id, int _diskIndex, string[] _markers, string _className)
	{
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x00004688 File Offset: 0x00002888
	public static bool IsGotSpecial(MSpecialPose special)
	{
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x0000468C File Offset: 0x0000288C
	public static void GotSpecial(MSpecialPose special)
	{
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00004690 File Offset: 0x00002890
	public static MSpecialPose GetSpecialData()
	{
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00004694 File Offset: 0x00002894
	public static MSpecialPose GetSpecial1Data()
	{
	}

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00004698 File Offset: 0x00002898
	public static MSpecialPose GetSpecial2Data()
	{
	}

	// Token: 0x040006F2 RID: 1778
	public string id;

	// Token: 0x040006F3 RID: 1779
	public int diskIndex;

	// Token: 0x040006F4 RID: 1780
	public List<string> markers;

	// Token: 0x040006F5 RID: 1781
	public string className;
}
