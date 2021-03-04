using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace System
{
	/// <summary>Represents a globally unique identifier (GUID).</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public struct Guid : IComparable<Guid>, IEquatable<Guid>, IComparable, IFormattable
	{
		internal class GuidParser
		{
			private string _src;

			private int _length;

			private int _cur;

			public GuidParser(string src)
			{
			}

			private void Reset()
			{
			}

			private bool AtEnd()
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			private void ThrowFormatException()
			{
			}

			private ulong ParseHex(int length, bool strictLength)
			{
				return (ulong)/*Error near IL_0001: Stack underflow*/;
			}

			private bool ParseOptChar(char c)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			private void ParseChar(char c)
			{
			}

			private Guid ParseGuid1()
			{
				return (Guid)/*Error near IL_0001: Stack underflow*/;
			}

			private void ParseHexPrefix()
			{
			}

			private Guid ParseGuid2()
			{
				return (Guid)/*Error near IL_0001: Stack underflow*/;
			}

			public Guid Parse()
			{
				return (Guid)/*Error near IL_0001: Stack underflow*/;
			}
		}

		private int _a;

		private short _b;

		private short _c;

		private byte _d;

		private byte _e;

		private byte _f;

		private byte _g;

		private byte _h;

		private byte _i;

		private byte _j;

		private byte _k;

		/// <summary>A read-only instance of the <see cref="T:System.Guid" /> class whose value is guaranteed to be all zeroes.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly Guid Empty;

		private static object _rngAccess;

		private static RandomNumberGenerator _rng;

		private static RandomNumberGenerator _fastRng;

		/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> class using the specified array of bytes.</summary>
		/// <param name="b">A 16 element byte array containing values with which to initialize the GUID. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="b" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="b" /> is not 16 bytes long. </exception>
		public Guid(byte[] b)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> class using the value represented by the specified string.</summary>
		/// <param name="g">A <see cref="T:System.String" /> that contains a GUID in one of the following formats ('d' represents a hexadecimal digit whose case is ignored): 32 contiguous digits: dddddddddddddddddddddddddddddddd -or- Groups of 8, 4, 4, 4, and 12 digits with hyphens between the groups. The entire GUID can optionally be enclosed in matching braces or parentheses: dddddddd-dddd-dddd-dddd-dddddddddddd -or- {dddddddd-dddd-dddd-dddd-dddddddddddd} -or- (dddddddd-dddd-dddd-dddd-dddddddddddd) -or- Groups of 8, 4, and 4 digits, and a subset of eight groups of 2 digits, with each group prefixed by "0x" or "0X", and separated by commas. The entire GUID, as well as the subset, is enclosed in matching braces: {0xdddddddd, 0xdddd, 0xdddd,{0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd,0xdd}} All braces, commas, and "0x" prefixes are required. All embedded spaces are ignored. All leading zeroes in a group are ignored.The digits shown in a group are the maximum number of meaningful digits that can appear in that group. You can specify from 1 to the number of digits shown for a group. The specified digits are assumed to be the low order digits of the group. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="g" /> is null. </exception>
		/// <exception cref="T:System.FormatException">The format of <paramref name="g" /> is invalid. </exception>
		/// <exception cref="T:System.OverflowException">The format of <paramref name="g" /> is invalid. </exception>
		/// <exception cref="T:System.Exception">An internal type conversion error occurred. </exception>
		public Guid(string g)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> class using the specified integers and byte array.</summary>
		/// <param name="a">The first 4 bytes of the GUID. </param>
		/// <param name="b">The next 2 bytes of the GUID. </param>
		/// <param name="c">The next 2 bytes of the GUID. </param>
		/// <param name="d">The remaining 8 bytes of the GUID. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="d" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="d" /> is not 8 bytes long. </exception>
		public Guid(int a, short b, short c, byte[] d)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> class using the specified integers and bytes.</summary>
		/// <param name="a">The first 4 bytes of the GUID. </param>
		/// <param name="b">The next 2 bytes of the GUID. </param>
		/// <param name="c">The next 2 bytes of the GUID. </param>
		/// <param name="d">The next byte of the GUID. </param>
		/// <param name="e">The next byte of the GUID. </param>
		/// <param name="f">The next byte of the GUID. </param>
		/// <param name="g">The next byte of the GUID. </param>
		/// <param name="h">The next byte of the GUID. </param>
		/// <param name="i">The next byte of the GUID. </param>
		/// <param name="j">The next byte of the GUID. </param>
		/// <param name="k">The next byte of the GUID. </param>
		public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
		{
		}

		private static void CheckNull(object o)
		{
		}

		private static void CheckLength(byte[] o, int l)
		{
		}

		private static void CheckArray(byte[] o, int l)
		{
		}

		private static int Compare(int x, int y)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares this instance to a specified object and returns an indication of their relative values.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns>
		/// <param name="value">An object to compare, or null. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.Guid" />. </exception>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="o" /> is a <see cref="T:System.Guid" /> that has the same value as this instance; otherwise, false.</returns>
		/// <param name="o">The object to compare with this instance. </param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.Guid" /> object and returns an indication of their relative values.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is greater than <paramref name="value" />. </returns>
		/// <param name="value">A <see cref="T:System.Guid" /> object to compare to this instance.</param>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(Guid value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Guid" /> object represent the same value.</summary>
		/// <returns>true if <paramref name="g" /> is equal to this instance; otherwise, false.</returns>
		/// <param name="g">A <see cref="T:System.Guid" /> object to compare to this instance.</param>
		/// <filterpriority>2</filterpriority>
		public bool Equals(Guid g)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>The hash code for this instance.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static char ToHex(int b)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Guid" /> class.</summary>
		/// <returns>A new <see cref="T:System.Guid" /> object.</returns>
		/// <filterpriority>1</filterpriority>
		public static Guid NewGuid()
		{
			return (Guid)/*Error near IL_0001: Stack underflow*/;
		}

		private static void AppendInt(StringBuilder builder, int value)
		{
		}

		private static void AppendShort(StringBuilder builder, short value)
		{
		}

		private static void AppendByte(StringBuilder builder, byte value)
		{
		}

		private string BaseToString(bool h, bool p, bool b)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a <see cref="T:System.String" /> representation of the value of this instance in registry format.</summary>
		/// <returns>A String formatted in this pattern: xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx where the value of the GUID is represented as a series of lower-case hexadecimal digits in groups of 8, 4, 4, 4, and 12 digits and separated by hyphens. An example of a return value is "382c74c3-721d-4f34-80e5-57657b6cbc27".</returns>
		/// <filterpriority>1</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a <see cref="T:System.String" /> representation of the value of this <see cref="T:System.Guid" /> instance, according to the provided format specifier.</summary>
		/// <returns>The value of this <see cref="T:System.Guid" />, represented as a series of lowercase hexadecimal digits in the specified format.</returns>
		/// <param name="format">A single format specifier that indicates how to format the value of this <see cref="T:System.Guid" />. The <paramref name="format" /> parameter can be "N", "D", "B", or "P". If <paramref name="format" /> is null or the empty string (""), "D" is used. </param>
		/// <exception cref="T:System.FormatException">The value of <paramref name="format" /> is not null, the empty string (""), "N", "D", "B", or "P". </exception>
		/// <filterpriority>1</filterpriority>
		public string ToString(string format)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a <see cref="T:System.String" /> representation of the value of this instance of the <see cref="T:System.Guid" /> class, according to the provided format specifier and culture-specific format information.</summary>
		/// <returns>The value of this <see cref="T:System.Guid" />, represented as a series of lowercase hexadecimal digits in the specified format.</returns>
		/// <param name="format">A single format specifier that indicates how to format the value of this <see cref="T:System.Guid" />. The <paramref name="format" /> parameter can be "N", "D", "B", or "P". If <paramref name="format" /> is null or the empty string (""), "D" is used. </param>
		/// <param name="provider">(Reserved) An IFormatProvider reference that supplies culture-specific formatting services. </param>
		/// <exception cref="T:System.FormatException">The value of <paramref name="format" /> is not null, the empty string (""), "N", "D", "B", or "P". </exception>
		/// <filterpriority>1</filterpriority>
		public string ToString(string format, IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
