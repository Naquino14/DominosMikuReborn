namespace System.IO
{
	[Serializable]
	internal class SynchronizedWriter : TextWriter
	{
		private TextWriter writer;

		private bool neverClose;

		public SynchronizedWriter(TextWriter writer, bool neverClose)
		{
		}

		public override void Flush()
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

		public override void Write(uint value)
		{
		}

		public override void Write(char[] buffer, int index, int count)
		{
		}

		public override void WriteLine()
		{
		}

		public override void WriteLine(string value)
		{
		}

		public override void WriteLine(uint value)
		{
		}
	}
}
