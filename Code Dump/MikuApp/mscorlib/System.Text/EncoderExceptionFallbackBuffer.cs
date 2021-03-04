namespace System.Text
{
	/// <summary>Throws <see cref="T:System.Text.EncoderFallbackException" /> when an input character cannot be converted to an encoded output byte sequence. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	public sealed class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
	{
		/// <summary>Gets the number of characters in the current <see cref="T:System.Text.EncoderExceptionFallbackBuffer" /> object that remain to be processed.</summary>
		/// <returns>The return value is always zero.A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
		/// <filterpriority>1</filterpriority>
		public override int Remaining => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderExceptionFallbackBuffer" /> class.</summary>
		public EncoderExceptionFallbackBuffer()
		{
		}

		/// <summary>Throws an exception because the input character cannot be encoded. Parameters specify the value and index position of the character that cannot be converted.</summary>
		/// <returns>None. No value is returned because the <see cref="M:System.Text.EncoderExceptionFallbackBuffer.Fallback(System.Char,System.Int32)" /> method always throws an exception. </returns>
		/// <param name="charUnknown">An input character.</param>
		/// <param name="index">The index position of the character in the input buffer.</param>
		/// <exception cref="T:System.Text.EncoderFallbackException">
		///   <paramref name="charUnknown" /> cannot be encoded. This method always throws an exception that reports the value of the <paramref name="charUnknown" /> and <paramref name="index" /> parameters.</exception>
		/// <filterpriority>1</filterpriority>
		public override bool Fallback(char charUnknown, int index)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Throws an exception because the input character cannot be encoded. Parameters specify the value and index position of the surrogate pair in the input, and the nominal return value is not used.</summary>
		/// <returns>None. No value is returned because the <see cref="M:System.Text.EncoderExceptionFallbackBuffer.Fallback(System.Char,System.Char,System.Int32)" /> method always throws an exception. </returns>
		/// <param name="charUnknownHigh">The high surrogate of the input pair.</param>
		/// <param name="charUnknownLow">The low surrogate of the input pair.</param>
		/// <param name="index">The index position of the surrogate pair in the input buffer.</param>
		/// <exception cref="T:System.Text.EncoderFallbackException">The character represented by <paramref name="charUnknownHigh" /> and <paramref name="charUnknownLow" /> cannot be encoded.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="charUnknownHigh" /> or <paramref name="charUnknownLow" /> is invalid. <paramref name="charUnknownHigh" /> is not between U+D800 and U+DBFF, inclusive, or <paramref name="charUnknownLow" /> is not between U+DC00 and U+DFFF, inclusive.</exception>
		/// <filterpriority>1</filterpriority>
		public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Retrieves the next character in the exception fallback buffer.</summary>
		/// <returns>The return value is always the Unicode character, NULL (U+0000). A return value is defined, although it is unchanging, because this method implements an abstract method.</returns>
		/// <filterpriority>2</filterpriority>
		public override char GetNextChar()
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
