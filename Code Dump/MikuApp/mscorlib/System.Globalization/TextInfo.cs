using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>Defines text properties and behaviors, such as casing, that are specific to a writing system. </summary>
	[Serializable]
	[ComVisible(true)]
	[MonoTODO("IDeserializationCallback isn't implemented.")]
	public class TextInfo : ICloneable, IDeserializationCallback
	{
		private struct Data
		{
			public int ansi;

			public int ebcdic;

			public int mac;

			public int oem;

			public byte list_sep;
		}

		private string m_listSeparator;

		private bool m_isReadOnly;

		private string customCultureName;

		[NonSerialized]
		private int m_nDataItem;

		private bool m_useUserOverride;

		private int m_win32LangID;

		[NonSerialized]
		private readonly CultureInfo ci;

		[NonSerialized]
		private readonly bool handleDotI;

		[NonSerialized]
		private readonly Data data;

		/// <summary>Gets or sets the string that separates items in a list.</summary>
		/// <returns>The string that separates items in a list.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value in a set operation is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">In a set operation, the current <see cref="T:System.Globalization.TextInfo" /> object is read-only.</exception>
		public virtual string ListSeparator => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the name of the culture associated with the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
		/// <returns>The name of a culture. </returns>
		[ComVisible(false)]
		public string CultureName => (string)/*Error near IL_0001: Stack underflow*/;

		internal unsafe TextInfo(CultureInfo ci, int lcid, void* data, bool read_only)
		{
		}

		private TextInfo(TextInfo textInfo)
		{
		}

		/// <summary>Raises the deserialization event when deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event. </param>
		[MonoTODO]
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		/// <summary>Determines whether the specified object represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
		/// <returns>true if <paramref name="obj" /> represents the same writing system as the current <see cref="T:System.Globalization.TextInfo" />; otherwise, false.</returns>
		/// <param name="obj">The object to compare with the current <see cref="T:System.Globalization.TextInfo" />. </param>
		public override bool Equals(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.TextInfo" />, suitable for hashing algorithms and data structures, such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Globalization.TextInfo" />.</returns>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.TextInfo" />.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Globalization.TextInfo" />.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified character to lowercase.</summary>
		/// <returns>The specified character converted to lowercase.</returns>
		/// <param name="c">The character to convert to lowercase. </param>
		public virtual char ToLower(char c)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified character to uppercase.</summary>
		/// <returns>The specified character converted to uppercase.</returns>
		/// <param name="c">The character to convert to uppercase. </param>
		public virtual char ToUpper(char c)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified string to lowercase.</summary>
		/// <returns>The specified string converted to lowercase.</returns>
		/// <param name="str">The string to convert to lowercase. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> is null. </exception>
		public virtual string ToLower(string str)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified string to uppercase.</summary>
		/// <returns>The specified string converted to uppercase.</returns>
		/// <param name="str">The string to convert to uppercase. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="str" /> is null. </exception>
		public virtual string ToUpper(string str)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a read-only version of the specified <see cref="T:System.Globalization.TextInfo" /> object.</summary>
		/// <returns>The <see cref="T:System.Globalization.TextInfo" /> object specified by the <paramref name="textInfo" /> parameter, if <paramref name="textInfo" /> is read-only.-or-A read-only memberwise clone of the <see cref="T:System.Globalization.TextInfo" /> object specified by <paramref name="textInfo" />, if <paramref name="textInfo" /> is not read-only.</returns>
		/// <param name="textInfo">A <see cref="T:System.Globalization.TextInfo" /> object.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="textInfo" /> is null.</exception>
		[ComVisible(false)]
		public static TextInfo ReadOnly(TextInfo textInfo)
		{
			return (TextInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Globalization.TextInfo" /> object.</summary>
		/// <returns>A new instance of <see cref="T:System.Object" /> that is the memberwise clone of the current <see cref="T:System.Globalization.TextInfo" /> object.</returns>
		[ComVisible(false)]
		public virtual object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
