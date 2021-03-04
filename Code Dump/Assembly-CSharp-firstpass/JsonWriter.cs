using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace LitJson
{
	// Token: 0x02000019 RID: 25
	public class JsonWriter
	{
		// Token: 0x0600018E RID: 398 RVA: 0x000025A0 File Offset: 0x000007A0
		public JsonWriter()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000025A4 File Offset: 0x000007A4
		public JsonWriter(StringBuilder sb)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000025A8 File Offset: 0x000007A8
		public JsonWriter(TextWriter writer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000025B4 File Offset: 0x000007B4
		public int IndentValue
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000025B8 File Offset: 0x000007B8
		// (set) Token: 0x06000195 RID: 405 RVA: 0x000025BC File Offset: 0x000007BC
		public bool PrettyPrint
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000025C0 File Offset: 0x000007C0
		public TextWriter TextWriter
		{
			get
			{
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000197 RID: 407 RVA: 0x000025C4 File Offset: 0x000007C4
		// (set) Token: 0x06000198 RID: 408 RVA: 0x000025C8 File Offset: 0x000007C8
		public bool Validate
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000025CC File Offset: 0x000007CC
		private void DoValidation(Condition cond)
		{
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000025D0 File Offset: 0x000007D0
		private void Init()
		{
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000025D4 File Offset: 0x000007D4
		private static void IntToHex(int n, char[] hex)
		{
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000025D8 File Offset: 0x000007D8
		private void Indent()
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000025DC File Offset: 0x000007DC
		private void Put(string str)
		{
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000025E0 File Offset: 0x000007E0
		private void PutNewline()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000025E4 File Offset: 0x000007E4
		private void PutNewline(bool add_comma)
		{
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000025E8 File Offset: 0x000007E8
		private void PutString(string str)
		{
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000025EC File Offset: 0x000007EC
		private void Unindent()
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000025F0 File Offset: 0x000007F0
		public override string ToString()
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000025F4 File Offset: 0x000007F4
		public void Reset()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000025F8 File Offset: 0x000007F8
		public void Write(bool boolean)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000025FC File Offset: 0x000007FC
		public void Write(decimal number)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002600 File Offset: 0x00000800
		public void Write(double number)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002604 File Offset: 0x00000804
		public void Write(int number)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002608 File Offset: 0x00000808
		public void Write(long number)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000260C File Offset: 0x0000080C
		public void Write(string str)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002610 File Offset: 0x00000810
		public void Write(ulong number)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002614 File Offset: 0x00000814
		public void WriteArrayEnd()
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002618 File Offset: 0x00000818
		public void WriteArrayStart()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000261C File Offset: 0x0000081C
		public void WriteObjectEnd()
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002620 File Offset: 0x00000820
		public void WriteObjectStart()
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002624 File Offset: 0x00000824
		public void WritePropertyName(string property_name)
		{
		}

		// Token: 0x04000096 RID: 150
		private static NumberFormatInfo number_format;

		// Token: 0x04000097 RID: 151
		private WriterContext context;

		// Token: 0x04000098 RID: 152
		private Stack<WriterContext> ctx_stack;

		// Token: 0x04000099 RID: 153
		private bool has_reached_end;

		// Token: 0x0400009A RID: 154
		private char[] hex_seq;

		// Token: 0x0400009B RID: 155
		private int indentation;

		// Token: 0x0400009C RID: 156
		private int indent_value;

		// Token: 0x0400009D RID: 157
		private StringBuilder inst_string_builder;

		// Token: 0x0400009E RID: 158
		private bool pretty_print;

		// Token: 0x0400009F RID: 159
		private bool validate;

		// Token: 0x040000A0 RID: 160
		private TextWriter writer;
	}
}
