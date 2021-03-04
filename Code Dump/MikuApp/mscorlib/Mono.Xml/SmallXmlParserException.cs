using System;

namespace Mono.Xml
{
	internal class SmallXmlParserException : SystemException
	{
		private int line;

		private int column;

		public SmallXmlParserException(string msg, int line, int column)
		{
		}
	}
}
