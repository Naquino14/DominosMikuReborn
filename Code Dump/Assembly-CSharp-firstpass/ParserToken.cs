using System;

namespace LitJson
{
	// Token: 0x0200001C RID: 28
	internal enum ParserToken
	{
		// Token: 0x040000B4 RID: 180
		None = 65536,
		// Token: 0x040000B5 RID: 181
		Number,
		// Token: 0x040000B6 RID: 182
		True,
		// Token: 0x040000B7 RID: 183
		False,
		// Token: 0x040000B8 RID: 184
		Null,
		// Token: 0x040000B9 RID: 185
		CharSeq,
		// Token: 0x040000BA RID: 186
		Char,
		// Token: 0x040000BB RID: 187
		Text,
		// Token: 0x040000BC RID: 188
		Object,
		// Token: 0x040000BD RID: 189
		ObjectPrime,
		// Token: 0x040000BE RID: 190
		Pair,
		// Token: 0x040000BF RID: 191
		PairRest,
		// Token: 0x040000C0 RID: 192
		Array,
		// Token: 0x040000C1 RID: 193
		ArrayPrime,
		// Token: 0x040000C2 RID: 194
		Value,
		// Token: 0x040000C3 RID: 195
		ValueRest,
		// Token: 0x040000C4 RID: 196
		String,
		// Token: 0x040000C5 RID: 197
		End,
		// Token: 0x040000C6 RID: 198
		Epsilon
	}
}
