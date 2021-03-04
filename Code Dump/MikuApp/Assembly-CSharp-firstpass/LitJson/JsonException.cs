using System;

namespace LitJson
{
	public class JsonException : ApplicationException
	{
		public JsonException()
		{
		}

		internal JsonException(ParserToken token)
		{
		}

		internal JsonException(ParserToken token, Exception inner_exception)
		{
		}

		internal JsonException(int c)
		{
		}

		internal JsonException(int c, Exception inner_exception)
		{
		}

		public JsonException(string message)
		{
		}

		public JsonException(string message, Exception inner_exception)
		{
		}
	}
}
