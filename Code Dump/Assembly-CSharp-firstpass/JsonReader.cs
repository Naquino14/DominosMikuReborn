using System;
using System.Collections.Generic;
using System.IO;

namespace LitJson
{
	// Token: 0x02000016 RID: 22
	public class JsonReader
	{
		// Token: 0x06000179 RID: 377 RVA: 0x0000254C File Offset: 0x0000074C
		public JsonReader(string json_text)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002550 File Offset: 0x00000750
		public JsonReader(TextReader reader)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002554 File Offset: 0x00000754
		private JsonReader(TextReader reader, bool owned)
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000255C File Offset: 0x0000075C
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00002560 File Offset: 0x00000760
		public bool AllowComments
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x06000180 RID: 384 RVA: 0x00002568 File Offset: 0x00000768
		public bool AllowSingleQuotedStrings
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000256C File Offset: 0x0000076C
		public bool EndOfInput
		{
			get
			{
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00002570 File Offset: 0x00000770
		public bool EndOfJson
		{
			get
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002574 File Offset: 0x00000774
		public JsonToken Token
		{
			get
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00002578 File Offset: 0x00000778
		public object Value
		{
			get
			{
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000257C File Offset: 0x0000077C
		private static void PopulateParseTable()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002580 File Offset: 0x00000780
		private static void TableAddCol(ParserToken row, int col, params int[] symbols)
		{
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002584 File Offset: 0x00000784
		private static void TableAddRow(ParserToken rule)
		{
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00002588 File Offset: 0x00000788
		private void ProcessNumber(string number)
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000258C File Offset: 0x0000078C
		private void ProcessSymbol()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002590 File Offset: 0x00000790
		private bool ReadToken()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002594 File Offset: 0x00000794
		public void Close()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002598 File Offset: 0x00000798
		public bool Read()
		{
		}

		// Token: 0x0400007D RID: 125
		private static IDictionary<int, IDictionary<int, int[]>> parse_table;

		// Token: 0x0400007E RID: 126
		private Stack<int> automaton_stack;

		// Token: 0x0400007F RID: 127
		private int current_input;

		// Token: 0x04000080 RID: 128
		private int current_symbol;

		// Token: 0x04000081 RID: 129
		private bool end_of_json;

		// Token: 0x04000082 RID: 130
		private bool end_of_input;

		// Token: 0x04000083 RID: 131
		private Lexer lexer;

		// Token: 0x04000084 RID: 132
		private bool parser_in_string;

		// Token: 0x04000085 RID: 133
		private bool parser_return;

		// Token: 0x04000086 RID: 134
		private bool read_started;

		// Token: 0x04000087 RID: 135
		private TextReader reader;

		// Token: 0x04000088 RID: 136
		private bool reader_is_owned;

		// Token: 0x04000089 RID: 137
		private object token_value;

		// Token: 0x0400008A RID: 138
		private JsonToken token;
	}
}
