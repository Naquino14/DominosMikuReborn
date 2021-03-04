using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Represents the result of mapping a string to its sort key.</summary>
	[Serializable]
	[ComVisible(true)]
	public class SortKey
	{
		private readonly string source;

		private readonly CompareOptions options;

		private readonly byte[] key;

		private readonly int lcid;

		/// <summary>Gets the original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <returns>The original string used to create the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
		public virtual string OriginalString => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the byte array representing the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <returns>A byte array representing the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
		public virtual byte[] KeyData => (byte[])/*Error near IL_0001: Stack underflow*/;

		internal SortKey(int lcid, string source, CompareOptions opt)
		{
		}

		/// <summary>Compares two sort keys.</summary>
		/// <returns>Value Condition Less than zero <paramref name="sortkey1" /> is less than <paramref name="sortkey2" />. Zero <paramref name="sortkey1" /> is equal to <paramref name="sortkey2" />. Greater than zero <paramref name="sortkey1" /> is greater than <paramref name="sortkey2" />. </returns>
		/// <param name="sortkey1">The first sort key to compare. </param>
		/// <param name="sortkey2">The second sort key to compare. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sortkey1" /> or <paramref name="sortkey2" /> is null.</exception>
		public static int Compare(SortKey sortkey1, SortKey sortkey2)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <returns>true if the <paramref name="value" /> parameter is equal to the current <see cref="T:System.Globalization.SortKey" /> object; otherwise, false. </returns>
		/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.SortKey" /> object. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null.</exception>
		public override bool Equals(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.SortKey" /> object that is suitable for hashing algorithms and data structures such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.SortKey" /> object.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Globalization.SortKey" /> object.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
