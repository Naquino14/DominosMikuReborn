using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a decimal number.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public struct Decimal : IComparable<decimal>, IEquatable<decimal>, IComparable, IConvertible, IFormattable
	{
		/// <summary>Represents the smallest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public const decimal MinValue = -79228162514264337593543950335m;

		/// <summary>Represents the largest possible value of <see cref="T:System.Decimal" />. This field is constant and read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public const decimal MaxValue = 79228162514264337593543950335m;

		/// <summary>Represents the number negative one (-1).</summary>
		/// <filterpriority>1</filterpriority>
		public const decimal MinusOne = -1m;

		/// <summary>Represents the number one (1).</summary>
		/// <filterpriority>1</filterpriority>
		public const decimal One = 1m;

		/// <summary>Represents the number zero (0).</summary>
		/// <filterpriority>1</filterpriority>
		public const decimal Zero = 0m;

		private const int DECIMAL_DIVIDE_BY_ZERO = 5;

		private const uint MAX_SCALE = 28u;

		private const int iMAX_SCALE = 28;

		private const uint SIGN_FLAG = 2147483648u;

		private const uint SCALE_MASK = 16711680u;

		private const int SCALE_SHIFT = 16;

		private const uint RESERVED_SS32_BITS = 2130771967u;

		private static readonly decimal MaxValueDiv10;

		private uint flags;

		private uint hi;

		private uint lo;

		private uint mid;

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> from parameters specifying the instance's constituent parts.</summary>
		/// <param name="lo">The low 32 bits of a 96-bit integer. </param>
		/// <param name="mid">The middle 32 bits of a 96-bit integer. </param>
		/// <param name="hi">The high 32 bits of a 96-bit integer. </param>
		/// <param name="isNegative">The sign of the number; 1 is negative, 0 is positive. </param>
		/// <param name="scale">A power of 10 ranging from 0 to 28. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="scale" /> is greater than 28. </exception>
		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit signed integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		public Decimal(int value)
		{
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 32-bit unsigned integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		[CLSCompliant(false)]
		public Decimal(uint value)
		{
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit signed integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		public Decimal(long value)
		{
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified 64-bit unsigned integer.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		[CLSCompliant(false)]
		public Decimal(ulong value)
		{
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified single-precision floating-point number.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.-or- <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. </exception>
		public Decimal(float value)
		{
		}

		/// <summary>Initializes a new instance of <see cref="T:System.Decimal" /> to the value of the specified double-precision floating-point number.</summary>
		/// <param name="value">The value to represent as a <see cref="T:System.Decimal" />. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is greater than <see cref="F:System.Decimal.MaxValue" /> or less than <see cref="F:System.Decimal.MinValue" />.-or- <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />. </exception>
		public Decimal(double value)
		{
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToType(System.Type,System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <paramref name="type" />.</returns>
		/// <param name="type">The type to which to convert the value of this <see cref="T:System.Decimal" /> instance. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> implementation that supplies culture-specific information about the format of the returned value.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null. </exception>
		/// <exception cref="T:System.InvalidCastException">The requested type conversion is not supported. </exception>
		object IConvertible.ToType(Type targetType, IFormatProvider provider)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToBoolean(System.IFormatProvider)" />.</summary>
		/// <returns>true if the value of the current instance is not zero; otherwise, false.</returns>
		/// <param name="provider">This parameter is ignored. </param>
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToByte(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Byte" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>This conversion is not supported. No value is returned.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDecimal(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, unchanged.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToDouble(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Double" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt16(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Int16" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />.</exception>
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Int32" />.</returns>
		/// <param name="provider">The parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Int64" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSByte(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.SByte" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return (sbyte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToSingle(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.Single" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToUInt16(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt16" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt16.MinValue" /> or greater than <see cref="F:System.UInt16.MaxValue" />.</exception>
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt32(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt32" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt32.MinValue" /> or greater than <see cref="F:System.UInt32.MaxValue" />.</exception>
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>For a description of this member, see <see cref="M:System.IConvertible.ToInt64(System.IFormatProvider)" />.</summary>
		/// <returns>The value of the current instance, converted to a <see cref="T:System.UInt64" />.</returns>
		/// <param name="provider">This parameter is ignored.</param>
		/// <exception cref="T:System.OverflowException">The resulting integer value is less than <see cref="F:System.UInt64.MinValue" /> or greater than <see cref="F:System.UInt64.MaxValue" />.</exception>
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of a specified instance of <see cref="T:System.Decimal" /> to its equivalent binary representation.</summary>
		/// <returns>A 32-bit signed integer array with four elements that contain the binary representation of <paramref name="d" />.</returns>
		/// <param name="d">A <see cref="T:System.Decimal" /> value. </param>
		/// <filterpriority>1</filterpriority>
		public static int[] GetBits(decimal d)
		{
			return (int[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Adds two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> value that is the sum of <paramref name="d1" /> and <paramref name="d2" />.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <exception cref="T:System.OverflowException">The sum of <paramref name="d1" /> and <paramref name="d2" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static decimal Add(decimal d1, decimal d2)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Subtracts one specified <see cref="T:System.Decimal" /> value from another.</summary>
		/// <returns>The <see cref="T:System.Decimal" /> result of subtracting <paramref name="d2" /> from <paramref name="d1" />.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" /> (the minuend). </param>
		/// <param name="d2">A <see cref="T:System.Decimal" /> (the subtrahend). </param>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static decimal Subtract(decimal d1, decimal d2)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static ulong u64(decimal value)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		private static long s64(decimal value)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether two specified instances of <see cref="T:System.Decimal" /> represent the same value.</summary>
		/// <returns>true if <paramref name="d1" /> and <paramref name="d2" /> are equal; otherwise, false.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <filterpriority>1</filterpriority>
		public static bool Equals(decimal d1, decimal d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Object" /> represent the same type and value.</summary>
		/// <returns>true if <paramref name="value" /> is a <see cref="T:System.Decimal" /> and equal to this instance; otherwise, false.</returns>
		/// <param name="value">An <see cref="T:System.Object" />. </param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool IsZero()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Rounds a specified <see cref="T:System.Decimal" /> number to the closest integer toward negative infinity.</summary>
		/// <returns>If <paramref name="d" /> has a fractional part, the next whole <see cref="T:System.Decimal" /> number toward negative infinity that is less than <paramref name="d" />.-or- If <paramref name="d" /> doesn't have a fractional part, <paramref name="d" /> is returned unchanged.</returns>
		/// <param name="d">A <see cref="T:System.Decimal" />. </param>
		/// <filterpriority>1</filterpriority>
		public static decimal Floor(decimal d)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that is the result of multiplying <paramref name="d1" /> and <paramref name="d2" />.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" /> (the multiplicand). </param>
		/// <param name="d2">A <see cref="T:System.Decimal" /> (the multiplier). </param>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static decimal Multiply(decimal d1, decimal d2)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>The <see cref="T:System.Decimal" /> that is the result of dividing <paramref name="d1" /> by <paramref name="d2" />.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" /> (the dividend). </param>
		/// <param name="d2">A <see cref="T:System.Decimal" /> (the divisor). </param>
		/// <exception cref="T:System.DivideByZeroException">
		///   <paramref name="d2" /> is zero. </exception>
		/// <exception cref="T:System.OverflowException">The return value (that is, the quotient) is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static decimal Divide(decimal d1, decimal d2)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>A signed number indicating the relative values of <paramref name="d1" /> and <paramref name="d2" />.Return Value Meaning Less than zero <paramref name="d1" /> is less than <paramref name="d2" />. Zero <paramref name="d1" /> and <paramref name="d2" /> are equal. Greater than zero <paramref name="d1" /> is greater than <paramref name="d2" />. </returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <filterpriority>1</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static int Compare(decimal d1, decimal d2)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.Object" />.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Meaning Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns>
		/// <param name="value">An <see cref="T:System.Object" /> or null. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.Decimal" />. </exception>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.Decimal" /> object.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Return Value Meaning Less than zero This instance is less than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. Greater than zero This instance is greater than <paramref name="value" />. </returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> object.</param>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(decimal value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether this instance and a specified <see cref="T:System.Decimal" /> object represent the same value.</summary>
		/// <returns>true if <paramref name="value" /> is equal to this instance; otherwise, false.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> object to compare to this instance.</param>
		/// <filterpriority>2</filterpriority>
		public bool Equals(decimal value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified culture-specific format information.</summary>
		/// <returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns>
		/// <param name="s">The string representation of the number to convert. </param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific parsing information about <paramref name="s" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="s" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> is not of the correct format </exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" /></exception>
		/// <filterpriority>1</filterpriority>
		public static decimal Parse(string s, IFormatProvider provider)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		private static void ThrowAtPos(int pos)
		{
		}

		private static void ThrowInvalidExp()
		{
		}

		private static string stripStyles(string s, NumberStyles style, NumberFormatInfo nfi, out int decPos, out bool isNegative, out bool expFlag, out int exp, bool throwex)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the string representation of a number to its <see cref="T:System.Decimal" /> equivalent using the specified style and culture-specific format.</summary>
		/// <returns>The <see cref="T:System.Decimal" /> number equivalent to the number contained in <paramref name="s" /> as specified by <paramref name="style" /> and <paramref name="provider" />.</returns>
		/// <param name="s">The string representation of the number to convert. </param>
		/// <param name="style">A bitwise combination of <see cref="T:System.Globalization.NumberStyles" /> values that indicates the style elements that can be present in <paramref name="s" />. A typical value to specify is <see cref="F:System.Globalization.NumberStyles.Number" />.</param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> object that supplies culture-specific information about the format of <paramref name="s" />. </param>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> is not in the correct format. </exception>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="s" /> represents a number less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="s" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="style" /> is not a <see cref="T:System.Globalization.NumberStyles" /> value. -or-<paramref name="style" /> is the <see cref="F:System.Globalization.NumberStyles.AllowHexSpecifier" /> value.</exception>
		/// <filterpriority>1</filterpriority>
		public static decimal Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool PerformParse(string s, NumberStyles style, IFormatProvider provider, out decimal res, bool throwex)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.Decimal" />.</summary>
		/// <returns>The enumerated constant <see cref="F:System.TypeCode.Decimal" />.</returns>
		/// <filterpriority>2</filterpriority>
		public TypeCode GetTypeCode()
		{
			return (TypeCode)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.</summary>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		/// <param name="format">A numeric format string (see Remarks).</param>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="format" /> is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		public string ToString(string format, IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation.</summary>
		/// <returns>A string that represents the value of this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.</summary>
		/// <returns>The string representation of the value of this instance as specified by <paramref name="provider" />.</returns>
		/// <param name="provider">An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting information. </param>
		/// <filterpriority>1</filterpriority>
		public string ToString(IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern int decimal2UInt64(ref decimal val, out ulong result);

		[MethodImpl(4096)]
		private static extern int decimal2Int64(ref decimal val, out long result);

		[MethodImpl(4096)]
		private static extern int decimalIncr(ref decimal d1, ref decimal d2);

		[MethodImpl(4096)]
		internal static extern int string2decimal(out decimal val, string sDigits, uint decPos, int sign);

		[MethodImpl(4096)]
		internal static extern int decimalSetExponent(ref decimal val, int exp);

		[MethodImpl(4096)]
		private static extern double decimal2double(ref decimal val);

		[MethodImpl(4096)]
		private static extern void decimalFloorAndTrunc(ref decimal val, int floorFlag);

		[MethodImpl(4096)]
		private static extern int decimalMult(ref decimal pd1, ref decimal pd2);

		[MethodImpl(4096)]
		private static extern int decimalDiv(out decimal pc, ref decimal pa, ref decimal pb);

		[MethodImpl(4096)]
		private static extern int decimalCompare(ref decimal d1, ref decimal d2);

		/// <summary>Increments the <see cref="T:System.Decimal" /> operand by 1.</summary>
		/// <returns>The value of <paramref name="d" /> incremented by 1.</returns>
		/// <param name="d">The <see cref="T:System.Decimal" /> operand. </param>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static decimal operator ++(decimal d)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Subtracts two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>The <see cref="T:System.Decimal" /> result of subtracting <paramref name="d2" /> from <paramref name="d1" />.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static decimal operator -(decimal d1, decimal d2)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Multiplies two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>The <see cref="T:System.Decimal" /> result of multiplying <paramref name="d1" /> by <paramref name="d2" />.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static decimal operator *(decimal d1, decimal d2)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Divides two specified <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>The <see cref="T:System.Decimal" /> result of <paramref name="d1" /> by <paramref name="d2" />.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" /> (the dividend). </param>
		/// <param name="d2">A <see cref="T:System.Decimal" /> (the divisor). </param>
		/// <exception cref="T:System.DivideByZeroException">
		///   <paramref name="d2" /> is zero. </exception>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static decimal operator /(decimal d1, decimal d2)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to an 8-bit unsigned integer.</summary>
		/// <returns>An 8-bit unsigned integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.Byte.MinValue" /> or greater than <see cref="F:System.Byte.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static explicit operator byte(decimal value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to an 8-bit signed integer.</summary>
		/// <returns>An 8-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.SByte.MinValue" /> or greater than <see cref="F:System.SByte.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static explicit operator sbyte(decimal value)
		{
			return (sbyte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a 16-bit signed integer.</summary>
		/// <returns>A 16-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.Int16.MinValue" /> or greater than <see cref="F:System.Int16.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static explicit operator short(decimal value)
		{
			return (short)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a 16-bit unsigned integer.</summary>
		/// <returns>A 16-bit unsigned integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is greater than <see cref="F:System.UInt16.MaxValue" /> or less than <see cref="F:System.UInt16.MinValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static explicit operator ushort(decimal value)
		{
			return (ushort)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a 32-bit signed integer.</summary>
		/// <returns>A 32-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.Int32.MinValue" /> or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static explicit operator int(decimal value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a 32-bit unsigned integer.</summary>
		/// <returns>A 32-bit unsigned integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is negative or greater than <see cref="F:System.UInt32.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static explicit operator uint(decimal value)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a 64-bit signed integer.</summary>
		/// <returns>A 64-bit signed integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.Int64.MinValue" /> or greater than <see cref="F:System.Int64.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static explicit operator long(decimal value)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a 64-bit unsigned integer.</summary>
		/// <returns>A 64-bit unsigned integer that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is negative or greater than <see cref="F:System.UInt64.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static explicit operator ulong(decimal value)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts an 8-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 8-bit unsigned integer.</returns>
		/// <param name="value">An 8-bit unsigned integer. </param>
		/// <filterpriority>3</filterpriority>
		public static implicit operator decimal(byte value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts an 8-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 8-bit signed integer.</returns>
		/// <param name="value">An 8-bit signed integer. </param>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static implicit operator decimal(sbyte value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a 16-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 16-bit signed integer.</returns>
		/// <param name="value">A 16-bit signed integer. </param>
		/// <filterpriority>3</filterpriority>
		public static implicit operator decimal(short value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a 16-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 16-bit unsigned integer.</returns>
		/// <param name="value">A 16-bit unsigned integer. </param>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static implicit operator decimal(ushort value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a 32-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 32-bit signed integer.</returns>
		/// <param name="value">A 32-bit signed integer. </param>
		/// <filterpriority>3</filterpriority>
		public static implicit operator decimal(int value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a 32-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 32-bit unsigned integer.</returns>
		/// <param name="value">A 32-bit unsigned integer. </param>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static implicit operator decimal(uint value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a 64-bit signed integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 64-bit signed integer.</returns>
		/// <param name="value">A 64-bit signed integer. </param>
		/// <filterpriority>3</filterpriority>
		public static implicit operator decimal(long value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a 64-bit unsigned integer to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted 64-bit unsigned integer.</returns>
		/// <param name="value">A 64-bit unsigned integer. </param>
		/// <filterpriority>3</filterpriority>
		[CLSCompliant(false)]
		public static implicit operator decimal(ulong value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a single-precision floating-point number to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted single-precision floating point number.</returns>
		/// <param name="value">A single-precision floating-point number. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.-or- <paramref name="value" /> is <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.PositiveInfinity" />, or <see cref="F:System.Single.NegativeInfinity" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static explicit operator decimal(float value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a double-precision floating-point number to a <see cref="T:System.Decimal" />.</summary>
		/// <returns>A <see cref="T:System.Decimal" /> that represents the converted double-precision floating point number.</returns>
		/// <param name="value">A double-precision floating-point number. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.Decimal.MinValue" /> or greater than <see cref="F:System.Decimal.MaxValue" />.-or- <paramref name="value" /> is <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NegativeInfinity" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static explicit operator decimal(double value)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a single-precision floating-point number.</summary>
		/// <returns>A single-precision floating-point number that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <filterpriority>3</filterpriority>
		public static explicit operator float(decimal value)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts a <see cref="T:System.Decimal" /> to a double-precision floating-point number.</summary>
		/// <returns>A double-precision floating-point number that represents the converted <see cref="T:System.Decimal" />.</returns>
		/// <param name="value">A <see cref="T:System.Decimal" /> to convert. </param>
		/// <filterpriority>3</filterpriority>
		public static explicit operator double(decimal value)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Decimal" /> are not equal.</summary>
		/// <returns>true if <paramref name="d1" /> and <paramref name="d2" /> are not equal; otherwise, false.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator !=(decimal d1, decimal d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a value indicating whether two instances of <see cref="T:System.Decimal" /> are equal.</summary>
		/// <returns>true if <paramref name="d1" /> and <paramref name="d2" /> are equal; otherwise, false.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator ==(decimal d1, decimal d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is greater than another specified <see cref="T:System.Decimal" />.</summary>
		/// <returns>true if <paramref name="d1" /> is greater than <paramref name="d2" />; otherwise, false.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator >(decimal d1, decimal d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a value indicating whether a specified <see cref="T:System.Decimal" /> is less than another specified <see cref="T:System.Decimal" />.</summary>
		/// <returns>true if <paramref name="d1" /> is less than <paramref name="d2" />; otherwise, false.</returns>
		/// <param name="d1">A <see cref="T:System.Decimal" />. </param>
		/// <param name="d2">A <see cref="T:System.Decimal" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator <(decimal d1, decimal d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
