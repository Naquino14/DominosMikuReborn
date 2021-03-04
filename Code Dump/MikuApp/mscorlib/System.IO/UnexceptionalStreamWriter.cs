using System.Text;

namespace System.IO
{
	internal class UnexceptionalStreamWriter : StreamWriter
	{
		public UnexceptionalStreamWriter(Stream stream, Encoding encoding)
		{
		}

		public override void Flush()
		{
		}

		public override void Write(char[] buffer, int index, int count)
		{
		}

		public override void Write(char value)
		{
		}

		public override void Write(char[] value)
		{
		}

		public override void Write(string value)
		{
		}
	}
}
