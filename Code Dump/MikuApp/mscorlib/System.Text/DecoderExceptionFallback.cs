namespace System.Text
{
	/// <summary>Throws <see cref="T:System.Text.DecoderFallbackException" /> if an encoded input byte sequence cannot be converted to a decoded output character. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public sealed class DecoderExceptionFallback : DecoderFallback
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderExceptionFallback" /> class. </summary>
		public DecoderExceptionFallback()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.DecoderExceptionFallback" /> class. </summary>
		/// <returns>A <see cref="T:System.Text.DecoderFallbackBuffer" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			return (DecoderFallbackBuffer)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Indicates whether the current <see cref="T:System.Text.DecoderExceptionFallback" /> object and a specified object are equal.</summary>
		/// <returns>true if <paramref name="value" /> is not null and is a <see cref="T:System.Text.DecoderExceptionFallback" /> object; otherwise, false.</returns>
		/// <param name="value">An object that derives from the <see cref="T:System.Text.DecoderExceptionFallback" /> class.</param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Retrieves the hash code for this instance.</summary>
		/// <returns>The return value is always the same arbitrary value, and has no special significance. </returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
