using System.Collections;
using System.Text;

namespace Prime31
{
	public class Json
	{
		internal class Deserializer
		{
			private enum JsonToken
			{
				None,
				CurlyOpen,
				CurlyClose,
				SquaredOpen,
				SquaredClose,
				Colon,
				Comma,
				String,
				Number,
				True,
				False,
				Null
			}

			private bool _useGenericContainers;

			private char[] charArray;

			private Deserializer(string json, bool useGenericContainers)
			{
			}

			public static object deserialize(string json, bool useGenericContainers)
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}

			private object deserialize()
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}

			protected object parseValue(char[] json, ref int index)
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}

			private IDictionary parseObject(char[] json, ref int index)
			{
				return (IDictionary)/*Error near IL_0001: Stack underflow*/;
			}

			private IList parseArray(char[] json, ref int index)
			{
				return (IList)/*Error near IL_0001: Stack underflow*/;
			}

			private string parseString(char[] json, ref int index)
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}

			private double parseNumber(char[] json, ref int index)
			{
				return (double)/*Error near IL_0001: Stack underflow*/;
			}

			private int getLastIndexOfNumber(char[] json, int index)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			private void eatWhitespace(char[] json, ref int index)
			{
			}

			private JsonToken lookAhead(char[] json, int index)
			{
				return (JsonToken)/*Error near IL_0001: Stack underflow*/;
			}

			private JsonToken nextToken(char[] json, ref int index)
			{
				return (JsonToken)/*Error near IL_0001: Stack underflow*/;
			}
		}

		internal class Serializer
		{
			private StringBuilder _builder;

			private Serializer()
			{
			}

			public static string serialize(object obj)
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}

			private void serializeObject(object value)
			{
			}

			private void serializeIList(IList anArray)
			{
			}

			private void serializeIDictionary(IDictionary dict)
			{
			}

			private void serializeString(string str)
			{
			}

			private void serializeClass(object value)
			{
			}
		}

		public static object jsonDecode(string json)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public static object jsonDecode(string json, bool decodeUsingGenericContainers)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public static string jsonEncode(object obj)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
