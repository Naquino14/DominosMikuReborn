namespace System.IO
{
	[Serializable]
	internal class SynchronizedReader : TextReader
	{
		private TextReader reader;

		public SynchronizedReader(TextReader reader)
		{
		}

		public override void Close()
		{
		}

		public override int Peek()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override string ReadLine()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public override string ReadToEnd()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public override int Read()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int Read(char[] buffer, int index, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
