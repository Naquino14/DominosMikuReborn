namespace System.Text
{
	[Serializable]
	internal class Latin1Encoding : Encoding
	{
		internal const int ISOLATIN_CODE_PAGE = 28591;

		public override string HeaderName => (string)/*Error near IL_0001: Stack underflow*/;

		public override string WebName => (string)/*Error near IL_0001: Stack underflow*/;

		public override int GetByteCount(char[] chars, int index, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetByteCount(string s)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, ref EncoderFallbackBuffer buffer, ref char[] fallback_chars)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex, ref EncoderFallbackBuffer buffer, ref char[] fallback_chars)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetMaxByteCount(int charCount)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override int GetMaxCharCount(int byteCount)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public override string GetString(byte[] bytes, int index, int count)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public override string GetString(byte[] bytes)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
