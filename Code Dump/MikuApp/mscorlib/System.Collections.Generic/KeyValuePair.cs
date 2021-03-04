using System.Diagnostics;

namespace System.Collections.Generic
{
	/// <summary>Defines a key/value pair that can be set or retrieved.</summary>
	/// <typeparam name="TKey">The type of the key.</typeparam>
	/// <typeparam name="TValue">The type of the value.</typeparam>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[DebuggerDisplay("{value}", Name = "[{key}]")]
	public struct KeyValuePair<TKey, TValue>
	{
		private TKey key;

		private TValue value;

		/// <summary>Gets the key in the key/value pair.</summary>
		/// <returns>A <paramref name="TKey" /> that is the key of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />. </returns>
		public TKey Key
		{
			get
			{
				return (TKey)/*Error near IL_0001: Stack underflow*/;
			}
			private set
			{
			}
		}

		/// <summary>Gets the value in the key/value pair.</summary>
		/// <returns>A <paramref name="TValue" /> that is the value of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />. </returns>
		public TValue Value
		{
			get
			{
				return (TValue)/*Error near IL_0001: Stack underflow*/;
			}
			private set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.KeyValuePair`2" /> structure with the specified key and value.</summary>
		/// <param name="key">The object defined in each key/value pair.</param>
		/// <param name="value">The definition associated with <paramref name="key" />.</param>
		public KeyValuePair(TKey key, TValue value)
		{
		}

		/// <summary>Returns a string representation of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />, using the string representations of the key and value.</summary>
		/// <returns>A string representation of the <see cref="T:System.Collections.Generic.KeyValuePair`2" />, which includes the string representations of the key and value.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
