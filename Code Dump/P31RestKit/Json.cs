using System;
using System.Collections;
using System.Text;

namespace Prime31
{
	// Token: 0x02000005 RID: 5
	public class Json
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002074 File Offset: 0x00000274
		public static object jsonDecode(string json)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002078 File Offset: 0x00000278
		public static object jsonDecode(string json, bool decodeUsingGenericContainers)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000207C File Offset: 0x0000027C
		public static string jsonEncode(object obj)
		{
		}

		// Token: 0x02000006 RID: 6
		internal class Deserializer
		{
			// Token: 0x0600000D RID: 13 RVA: 0x00002080 File Offset: 0x00000280
			private Deserializer(string json, bool useGenericContainers)
			{
			}

			// Token: 0x0600000E RID: 14 RVA: 0x00002084 File Offset: 0x00000284
			public static object deserialize(string json, bool useGenericContainers)
			{
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00002088 File Offset: 0x00000288
			private object deserialize()
			{
			}

			// Token: 0x06000010 RID: 16 RVA: 0x0000208C File Offset: 0x0000028C
			protected object parseValue(char[] json, ref int index)
			{
			}

			// Token: 0x06000011 RID: 17 RVA: 0x00002090 File Offset: 0x00000290
			private IDictionary parseObject(char[] json, ref int index)
			{
			}

			// Token: 0x06000012 RID: 18 RVA: 0x00002094 File Offset: 0x00000294
			private IList parseArray(char[] json, ref int index)
			{
			}

			// Token: 0x06000013 RID: 19 RVA: 0x00002098 File Offset: 0x00000298
			private string parseString(char[] json, ref int index)
			{
			}

			// Token: 0x06000014 RID: 20 RVA: 0x0000209C File Offset: 0x0000029C
			private double parseNumber(char[] json, ref int index)
			{
			}

			// Token: 0x06000015 RID: 21 RVA: 0x000020A0 File Offset: 0x000002A0
			private int getLastIndexOfNumber(char[] json, int index)
			{
			}

			// Token: 0x06000016 RID: 22 RVA: 0x000020A4 File Offset: 0x000002A4
			private void eatWhitespace(char[] json, ref int index)
			{
			}

			// Token: 0x06000017 RID: 23 RVA: 0x000020A8 File Offset: 0x000002A8
			private Json.Deserializer.JsonToken lookAhead(char[] json, int index)
			{
			}

			// Token: 0x06000018 RID: 24 RVA: 0x000020AC File Offset: 0x000002AC
			private Json.Deserializer.JsonToken nextToken(char[] json, ref int index)
			{
			}

			// Token: 0x04000007 RID: 7
			private bool _useGenericContainers;

			// Token: 0x04000008 RID: 8
			private char[] charArray;

			// Token: 0x02000007 RID: 7
			private enum JsonToken
			{
				// Token: 0x0400000A RID: 10
				None,
				// Token: 0x0400000B RID: 11
				CurlyOpen,
				// Token: 0x0400000C RID: 12
				CurlyClose,
				// Token: 0x0400000D RID: 13
				SquaredOpen,
				// Token: 0x0400000E RID: 14
				SquaredClose,
				// Token: 0x0400000F RID: 15
				Colon,
				// Token: 0x04000010 RID: 16
				Comma,
				// Token: 0x04000011 RID: 17
				String,
				// Token: 0x04000012 RID: 18
				Number,
				// Token: 0x04000013 RID: 19
				True,
				// Token: 0x04000014 RID: 20
				False,
				// Token: 0x04000015 RID: 21
				Null
			}
		}

		// Token: 0x02000008 RID: 8
		internal class Serializer
		{
			// Token: 0x06000019 RID: 25 RVA: 0x000020B0 File Offset: 0x000002B0
			private Serializer()
			{
			}

			// Token: 0x0600001A RID: 26 RVA: 0x000020B4 File Offset: 0x000002B4
			public static string serialize(object obj)
			{
			}

			// Token: 0x0600001B RID: 27 RVA: 0x000020B8 File Offset: 0x000002B8
			private void serializeObject(object value)
			{
			}

			// Token: 0x0600001C RID: 28 RVA: 0x000020BC File Offset: 0x000002BC
			private void serializeIList(IList anArray)
			{
			}

			// Token: 0x0600001D RID: 29 RVA: 0x000020C0 File Offset: 0x000002C0
			private void serializeIDictionary(IDictionary dict)
			{
			}

			// Token: 0x0600001E RID: 30 RVA: 0x000020C4 File Offset: 0x000002C4
			private void serializeString(string str)
			{
			}

			// Token: 0x0600001F RID: 31 RVA: 0x000020C8 File Offset: 0x000002C8
			private void serializeClass(object value)
			{
			}

			// Token: 0x04000016 RID: 22
			private StringBuilder _builder;
		}
	}
}
