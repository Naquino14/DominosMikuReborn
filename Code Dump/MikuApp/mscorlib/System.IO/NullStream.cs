namespace System.IO
{
	internal class NullStream : Stream
	{
		public override bool CanRead => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public override bool CanSeek => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public override bool CanWrite => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public override long Length => (long)/*Error near IL_0001: Stack underflow*/;

		public override long Position
		{
			get
			{
				return (long)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int ReadByte()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void WriteByte(byte value)
		{
		}
	}
}
