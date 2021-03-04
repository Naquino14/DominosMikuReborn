using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Text
{
	/// <summary>Represents a mutable string of characters. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	[MonoTODO("Serialization format not compatible with .NET")]
	public sealed class StringBuilder : ISerializable
	{
		private const int constDefaultCapacity = 16;

		private int _length;

		private string _str;

		private string _cached_str;

		private int _maxCapacity;

		/// <summary>Gets or sets the maximum number of characters that can be contained in the memory allocated by the current instance.</summary>
		/// <returns>The maximum number of characters that can be contained in the memory allocated by the current instance.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than the current length of this instance.-or- The value specified for a set operation is greater than the maximum capacity. </exception>
		/// <filterpriority>2</filterpriority>
		public int Capacity
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the length of the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
		/// <returns>The length of this instance.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value specified for a set operation is less than zero or greater than <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public int Length
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the character at the specified character position in this instance.</summary>
		/// <returns>The Unicode character at position <paramref name="index" />.</returns>
		/// <param name="index">The position of the character. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is outside the bounds of this instance while setting a character. </exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="index" /> is outside the bounds of this instance while getting a character. </exception>
		/// <filterpriority>2</filterpriority>
		[IndexerName("Chars")]
		public char this[int index]
		{
			get
			{
				return (char)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class from the specified substring and capacity.</summary>
		/// <param name="value">The string that contains the substring used to initialize the value of this instance. If <paramref name="value" /> is null, the new <see cref="T:System.Text.StringBuilder" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />). </param>
		/// <param name="startIndex">The position within <paramref name="value" /> where the substring begins. </param>
		/// <param name="length">The number of characters in the substring. </param>
		/// <param name="capacity">The suggested starting size of the <see cref="T:System.Text.StringBuilder" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero.-or- <paramref name="startIndex" /> plus <paramref name="length" /> is not a position within <paramref name="value" />. </exception>
		public StringBuilder(string value, int startIndex, int length, int capacity)
		{
		}

		private StringBuilder(string value, int startIndex, int length, int capacity, int maxCapacity)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class.</summary>
		public StringBuilder()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class using the specified capacity.</summary>
		/// <param name="capacity">The suggested starting size of this instance. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero. </exception>
		public StringBuilder(int capacity)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Text.StringBuilder" /> class using the specified string.</summary>
		/// <param name="value">The string used to initialize the value of the instance. If <paramref name="value" /> is null, the new <see cref="T:System.Text.StringBuilder" /> will contain the empty string (that is, it contains <see cref="F:System.String.Empty" />). </param>
		public StringBuilder(string value)
		{
		}

		private StringBuilder(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the data necessary to deserialize the current <see cref="T:System.Text.StringBuilder" /> object.</summary>
		/// <param name="info">The object to populate with serialization information.</param>
		/// <param name="context">The place to store and retrieve serialized data. Reserved for future use.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Converts the value of this instance to a <see cref="T:System.String" />.</summary>
		/// <returns>A string whose value is the same as this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of a substring of this instance to a <see cref="T:System.String" />.</summary>
		/// <returns>A string whose value is the same as the specified substring of this instance.</returns>
		/// <param name="startIndex">The starting position of the substring in this instance. </param>
		/// <param name="length">The length of the substring. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> or <paramref name="length" /> is less than zero.-or- The sum of <paramref name="startIndex" /> and <paramref name="length" /> is greater than the length of the current instance. </exception>
		/// <filterpriority>1</filterpriority>
		public string ToString(int startIndex, int length)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes the specified range of characters from this instance.</summary>
		/// <returns>A reference to this instance after the excise operation has completed.</returns>
		/// <param name="startIndex">The zero-based position in this instance where removal begins. </param>
		/// <param name="length">The number of characters to remove. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">If <paramref name="startIndex" /> or <paramref name="length" /> is less than zero, or <paramref name="startIndex" /> + <paramref name="length" /> is greater than the length of this instance. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Remove(int startIndex, int length)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends a copy of the specified string to the end of this instance.</summary>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <param name="value">The string to append. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Append(string value)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string representation of a specified 32-bit signed integer to the end of this instance.</summary>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <param name="value">The value to append. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Append(int value)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string representation of a specified object to the end of this instance.</summary>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <param name="value">The object to append. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Append(object value)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string representation of a specified Unicode character to the end of this instance.</summary>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <param name="value">The Unicode character to append. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Append(char value)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends a specified number of copies of the string representation of a Unicode character to the end of this instance.</summary>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <param name="value">The character to append. </param>
		/// <param name="repeatCount">The number of times to append <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="repeatCount" /> is less than zero.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <exception cref="T:System.OutOfMemoryException">Out of memory.</exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Append(char value, int repeatCount)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string representation of a specified subarray of Unicode characters to the end of this instance.</summary>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <param name="value">A character array. </param>
		/// <param name="startIndex">The zero-based starting position in <paramref name="value" />. </param>
		/// <param name="charCount">The number of characters to append. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null, and <paramref name="startIndex" /> and <paramref name="charCount" /> are not zero. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="charCount" /> is less than zero.-or- <paramref name="startIndex" /> is less than zero.-or- <paramref name="startIndex" /> + <paramref name="charCount" /> is greater than the length of <paramref name="value" />.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Append(char[] value, int startIndex, int charCount)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends a copy of a specified substring to the end of this instance.</summary>
		/// <returns>A reference to this instance after the append operation has completed.</returns>
		/// <param name="value">The string that contains the substring to append. </param>
		/// <param name="startIndex">The zero-based starting position of the substring within <paramref name="value" />. </param>
		/// <param name="count">The number of characters in <paramref name="value" /> to append. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="value" /> is null, and <paramref name="startIndex" /> and <paramref name="count" /> are not zero. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="count" /> less than zero.-or- <paramref name="startIndex" /> less than zero.-or- <paramref name="startIndex" /> + <paramref name="count" /> is greater than the length of <paramref name="value" />.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Append(string value, int startIndex, int count)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a corresponding argument in a parameter array using a specified format provider.</summary>
		/// <returns>A reference to this instance after the append operation has completed. After the append operation, this instance contains any data that existed before the operation, suffixed by a copy of <paramref name="format" />, where each format item is replaced by the string representation of the corresponding object argument. </returns>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="args">An array of objects to format.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid.-or-The index of a format item is less than 0 (zero), or greater than or equal to the length of the <paramref name="args" /> array. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded  string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>2</filterpriority>
		public StringBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of a single argument.</summary>
		/// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of <paramref name="arg0" />.</returns>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="arg0">An object to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to 1.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>2</filterpriority>
		public StringBuilder AppendFormat(string format, object arg0)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of two arguments.</summary>
		/// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to 2.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>2</filterpriority>
		public StringBuilder AppendFormat(string format, object arg0, object arg1)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Appends the string returned by processing a composite format string, which contains zero or more format items, to this instance. Each format item is replaced by the string representation of either of three arguments.</summary>
		/// <returns>A reference to this instance with <paramref name="format" /> appended. Each format item in <paramref name="format" /> is replaced by the string representation of the corresponding object argument.</returns>
		/// <param name="format">A composite format string (see Remarks). </param>
		/// <param name="arg0">The first object to format. </param>
		/// <param name="arg1">The second object to format. </param>
		/// <param name="arg2">The third object to format. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="format" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid. -or-The index of a format item is less than 0 (zero), or greater than or equal to 3.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The length of the expanded string would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>2</filterpriority>
		public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Inserts a string into this instance at the specified character position.</summary>
		/// <returns>A reference to this instance after the insert operation has completed.</returns>
		/// <param name="index">The position in this instance where insertion begins. </param>
		/// <param name="value">The string to insert. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero or greater than the current length of this instance. -or-The current length of this <see cref="T:System.Text.StringBuilder" /> object plus the length of <paramref name="value" /> exceeds <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Insert(int index, string value)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Inserts the string representation of a specified Unicode character into this instance at the specified character position.</summary>
		/// <returns>A reference to this instance after the insert operation has completed.</returns>
		/// <param name="index">The position in this instance where insertion begins. </param>
		/// <param name="value">The value to insert. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero or greater than the length of this instance.-or- Enlarging the value of this instance would exceed <see cref="P:System.Text.StringBuilder.MaxCapacity" />. </exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Insert(int index, char value)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Inserts one or more copies of a specified string into this instance at the specified character position.</summary>
		/// <returns>A reference to this instance after insertion has completed.</returns>
		/// <param name="index">The position in this instance where insertion begins. </param>
		/// <param name="value">The string to insert. </param>
		/// <param name="count">The number of times to insert <paramref name="value" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero or greater than the current length of this instance.-or- <paramref name="count" /> is less than zero. -or-The current length of this <see cref="T:System.Text.StringBuilder" /> object plus the length of <paramref name="value" /> times <paramref name="count" /> exceeds <see cref="P:System.Text.StringBuilder.MaxCapacity" />.</exception>
		/// <filterpriority>1</filterpriority>
		public StringBuilder Insert(int index, string value, int count)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		private void InternalEnsureCapacity(int size)
		{
		}
	}
}
