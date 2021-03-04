using System.Runtime.InteropServices;
using System.Text;

namespace System.IO
{
	internal class UnexceptionalStreamReader : StreamReader
	{
		private static bool[] newline;

		private static char newlineChar;

		public UnexceptionalStreamReader(Stream stream, Encoding encoding)
		{
		}

		static UnexceptionalStreamReader()
		{
		}

		public override int Peek()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int Read()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int Read([In][Out] char[] dest_buffer, int index, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private bool CheckEOL(char current)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override string ReadLine()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public override string ReadToEnd()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
