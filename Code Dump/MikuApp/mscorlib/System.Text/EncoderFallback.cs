namespace System.Text
{
	/// <summary>Provides a failure-handling mechanism, called a fallback, for an input character that cannot be converted to an encoded output byte sequence. </summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public abstract class EncoderFallback
	{
		private static EncoderFallback exception_fallback;

		private static EncoderFallback replacement_fallback;

		private static EncoderFallback standard_safe_fallback;

		/// <summary>Gets an object that outputs a substitute string in place of an input character that cannot be encoded.</summary>
		/// <returns>A type derived from the <see cref="T:System.Text.EncoderFallback" /> class. The default value is a <see cref="T:System.Text.EncoderReplacementFallback" /> object that replaces unknown input characters with the QUESTION MARK character ("?", U+003F).</returns>
		/// <filterpriority>1</filterpriority>
		public static EncoderFallback ReplacementFallback => (EncoderFallback)/*Error near IL_0001: Stack underflow*/;

		internal static EncoderFallback StandardSafeFallback => (EncoderFallback)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.EncoderFallback" /> class.</summary>
		protected EncoderFallback()
		{
		}

		/// <summary>When overridden in a derived class, initializes a new instance of the <see cref="T:System.Text.EncoderFallbackBuffer" /> class. </summary>
		/// <returns>An object that provides a fallback buffer for an encoder.</returns>
		/// <filterpriority>2</filterpriority>
		public abstract EncoderFallbackBuffer CreateFallbackBuffer();
	}
}
