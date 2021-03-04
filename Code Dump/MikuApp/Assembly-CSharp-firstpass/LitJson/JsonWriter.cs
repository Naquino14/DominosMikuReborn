using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace LitJson
{
	public class JsonWriter
	{
		private static NumberFormatInfo number_format;

		private WriterContext context;

		private Stack<WriterContext> ctx_stack;

		private bool has_reached_end;

		private char[] hex_seq;

		private int indentation;

		private int indent_value;

		private StringBuilder inst_string_builder;

		private bool pretty_print;

		private bool validate;

		private TextWriter writer;

		public int IndentValue
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public bool PrettyPrint
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public TextWriter TextWriter => (TextWriter)/*Error near IL_0001: Stack underflow*/;

		public bool Validate
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public JsonWriter()
		{
		}

		public JsonWriter(StringBuilder sb)
		{
		}

		public JsonWriter(TextWriter writer)
		{
		}

		static JsonWriter()
		{
		}

		private void DoValidation(Condition cond)
		{
		}

		private void Init()
		{
		}

		private static void IntToHex(int n, char[] hex)
		{
		}

		private void Indent()
		{
		}

		private void Put(string str)
		{
		}

		private void PutNewline()
		{
		}

		private void PutNewline(bool add_comma)
		{
		}

		private void PutString(string str)
		{
		}

		private void Unindent()
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public void Reset()
		{
		}

		public void Write(bool boolean)
		{
		}

		public void Write(decimal number)
		{
		}

		public void Write(double number)
		{
		}

		public void Write(int number)
		{
		}

		public void Write(long number)
		{
		}

		public void Write(string str)
		{
		}

		public void Write(ulong number)
		{
		}

		public void WriteArrayEnd()
		{
		}

		public void WriteArrayStart()
		{
		}

		public void WriteObjectEnd()
		{
		}

		public void WriteObjectStart()
		{
		}

		public void WritePropertyName(string property_name)
		{
		}
	}
}
