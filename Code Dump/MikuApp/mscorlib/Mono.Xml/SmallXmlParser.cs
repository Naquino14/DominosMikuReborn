using System;
using System.Collections;
using System.IO;
using System.Text;

namespace Mono.Xml
{
	internal class SmallXmlParser
	{
		private class AttrListImpl : IAttrList
		{
			private ArrayList attrNames;

			private ArrayList attrValues;

			public string[] Names => (string[])/*Error near IL_0001: Stack underflow*/;

			public string[] Values => (string[])/*Error near IL_0001: Stack underflow*/;

			internal void Clear()
			{
			}

			internal void Add(string name, string value)
			{
			}
		}

		public interface IAttrList
		{
			string[] Names
			{
				get;
			}

			string[] Values
			{
				get;
			}
		}

		public interface IContentHandler
		{
			void OnStartParsing(SmallXmlParser parser);

			void OnEndParsing(SmallXmlParser parser);

			void OnStartElement(string name, IAttrList attrs);

			void OnEndElement(string name);

			void OnProcessingInstruction(string name, string text);

			void OnChars(string text);

			void OnIgnorableWhitespace(string text);
		}

		private IContentHandler handler;

		private TextReader reader;

		private Stack elementNames;

		private Stack xmlSpaces;

		private string xmlSpace;

		private StringBuilder buffer;

		private char[] nameBuffer;

		private bool isWhitespace;

		private AttrListImpl attributes;

		private int line;

		private int column;

		private bool resetColumn;

		private Exception Error(string msg)
		{
			return (Exception)/*Error near IL_0001: Stack underflow*/;
		}

		private Exception UnexpectedEndError()
		{
			return (Exception)/*Error near IL_0001: Stack underflow*/;
		}

		private bool IsNameChar(char c, bool start)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool IsWhitespace(int c)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void SkipWhitespaces()
		{
		}

		private void HandleWhitespaces()
		{
		}

		public void SkipWhitespaces(bool expected)
		{
		}

		private int Peek()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int Read()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public void Expect(int c)
		{
		}

		private string ReadUntil(char until, bool handleReferences)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public string ReadName()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public void Parse(TextReader input, IContentHandler handler)
		{
		}

		private void Cleanup()
		{
		}

		public void ReadContent()
		{
		}

		private void HandleBufferedContent()
		{
		}

		private void ReadCharacters()
		{
		}

		private void ReadReference()
		{
		}

		private int ReadCharacterReference()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private void ReadAttribute(AttrListImpl a)
		{
		}

		private void ReadCDATASection()
		{
		}

		private void ReadComment()
		{
		}
	}
}
