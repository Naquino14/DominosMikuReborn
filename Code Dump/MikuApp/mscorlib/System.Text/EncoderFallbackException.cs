namespace System.Text
{
	/// <summary>The exception that is thrown when an encoder fallback operation fails. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public sealed class EncoderFallbackException : ArgumentException
	{
		private const string defaultMessage = "Failed to decode the input byte sequence to Unicode characters.";

		private char char_unknown;

		private char char_unknown_high;

		private char char_unknown_low;

		private int index;

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallbackException" /> class.</summary>
		public EncoderFallbackException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallbackException" /> class. A parameter specifies the error message.</summary>
		/// <param name="message">An error message.</param>
		public EncoderFallbackException(string message)
		{
		}

		internal EncoderFallbackException(char charUnknown, int index)
		{
		}

		internal EncoderFallbackException(char charUnknownHigh, char charUnknownLow, int index)
		{
		}
	}
}
