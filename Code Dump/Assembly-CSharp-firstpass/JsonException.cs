using System;

namespace LitJson
{
	// Token: 0x02000010 RID: 16
	public class JsonException : ApplicationException
	{
		// Token: 0x06000134 RID: 308 RVA: 0x00002438 File Offset: 0x00000638
		public JsonException()
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000243C File Offset: 0x0000063C
		internal JsonException(ParserToken token)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002440 File Offset: 0x00000640
		internal JsonException(ParserToken token, Exception inner_exception)
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002444 File Offset: 0x00000644
		internal JsonException(int c)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002448 File Offset: 0x00000648
		internal JsonException(int c, Exception inner_exception)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000244C File Offset: 0x0000064C
		public JsonException(string message)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002450 File Offset: 0x00000650
		public JsonException(string message, Exception inner_exception)
		{
		}
	}
}
