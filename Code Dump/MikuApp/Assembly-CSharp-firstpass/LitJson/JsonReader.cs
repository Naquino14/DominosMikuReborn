using System.Collections.Generic;
using System.IO;

namespace LitJson
{
	public class JsonReader
	{
		private static IDictionary<int, IDictionary<int, int[]>> parse_table;

		private Stack<int> automaton_stack;

		private int current_input;

		private int current_symbol;

		private bool end_of_json;

		private bool end_of_input;

		private Lexer lexer;

		private bool parser_in_string;

		private bool parser_return;

		private bool read_started;

		private TextReader reader;

		private bool reader_is_owned;

		private object token_value;

		private JsonToken token;

		public bool AllowComments
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool AllowSingleQuotedStrings
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public bool EndOfInput => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool EndOfJson => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public JsonToken Token => (JsonToken)/*Error near IL_0001: Stack underflow*/;

		public object Value => (object)/*Error near IL_0001: Stack underflow*/;

		public JsonReader(string json_text)
		{
		}

		public JsonReader(TextReader reader)
		{
		}

		private JsonReader(TextReader reader, bool owned)
		{
		}

		static JsonReader()
		{
		}

		private static void PopulateParseTable()
		{
		}

		private static void TableAddCol(ParserToken row, int col, params int[] symbols)
		{
		}

		private static void TableAddRow(ParserToken rule)
		{
		}

		private void ProcessNumber(string number)
		{
		}

		private void ProcessSymbol()
		{
		}

		private bool ReadToken()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void Close()
		{
		}

		public bool Read()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
