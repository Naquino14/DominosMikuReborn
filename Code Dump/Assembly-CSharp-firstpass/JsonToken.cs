using System;

namespace LitJson
{
	// Token: 0x02000015 RID: 21
	public enum JsonToken
	{
		// Token: 0x04000071 RID: 113
		None,
		// Token: 0x04000072 RID: 114
		ObjectStart,
		// Token: 0x04000073 RID: 115
		PropertyName,
		// Token: 0x04000074 RID: 116
		ObjectEnd,
		// Token: 0x04000075 RID: 117
		ArrayStart,
		// Token: 0x04000076 RID: 118
		ArrayEnd,
		// Token: 0x04000077 RID: 119
		Int,
		// Token: 0x04000078 RID: 120
		Long,
		// Token: 0x04000079 RID: 121
		Double,
		// Token: 0x0400007A RID: 122
		String,
		// Token: 0x0400007B RID: 123
		Boolean,
		// Token: 0x0400007C RID: 124
		Null
	}
}
