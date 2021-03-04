using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a time interval.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public struct TimeSpan : IComparable<TimeSpan>, IEquatable<TimeSpan>, IComparable
	{
		/// <summary>Represents the number of ticks in 1 day. This field is constant.</summary>
		/// <filterpriority>1</filterpriority>
		public const long TicksPerDay = 864000000000L;

		/// <summary>Represents the number of ticks in 1 hour. This field is constant.</summary>
		/// <filterpriority>1</filterpriority>
		public const long TicksPerHour = 36000000000L;

		/// <summary>Represents the number of ticks in 1 millisecond. This field is constant.</summary>
		/// <filterpriority>1</filterpriority>
		public const long TicksPerMillisecond = 10000L;

		/// <summary>Represents the number of ticks in 1 minute. This field is constant.</summary>
		/// <filterpriority>1</filterpriority>
		public const long TicksPerMinute = 600000000L;

		/// <summary>Represents the number of ticks in 1 second.</summary>
		/// <filterpriority>1</filterpriority>
		public const long TicksPerSecond = 10000000L;

		/// <summary>Represents the maximum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly TimeSpan MaxValue;

		/// <summary>Represents the minimum <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly TimeSpan MinValue;

		/// <summary>Represents the zero <see cref="T:System.TimeSpan" /> value. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly TimeSpan Zero;

		private long _ticks;

		/// <summary>Gets the days component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The day component of this instance. The return value can be positive or negative.</returns>
		/// <filterpriority>1</filterpriority>
		public int Days => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the hours component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The hour component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -23 through 23.</returns>
		/// <filterpriority>1</filterpriority>
		public int Hours => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the minutes component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The minute component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns>
		/// <filterpriority>1</filterpriority>
		public int Minutes => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the seconds component of the time interval represented by the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The second component of the current <see cref="T:System.TimeSpan" /> structure. The return value ranges from -59 through 59.</returns>
		/// <filterpriority>1</filterpriority>
		public int Seconds => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the number of ticks that represent the value of the current <see cref="T:System.TimeSpan" /> structure.</summary>
		/// <returns>The number of ticks contained in this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public long Ticks => (long)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional milliseconds.</summary>
		/// <returns>The total number of milliseconds represented by this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public double TotalMilliseconds => (double)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the value of the current <see cref="T:System.TimeSpan" /> structure expressed in whole and fractional minutes.</summary>
		/// <returns>The total number of minutes represented by this instance.</returns>
		/// <filterpriority>1</filterpriority>
		public double TotalMinutes => (double)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to the specified number of ticks.</summary>
		/// <param name="ticks">A time period expressed in 100-nanosecond units. </param>
		public TimeSpan(long ticks)
		{
		}

		/// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of hours, minutes, and seconds.</summary>
		/// <param name="hours">Number of hours. </param>
		/// <param name="minutes">Number of minutes. </param>
		/// <param name="seconds">Number of seconds. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		public TimeSpan(int hours, int minutes, int seconds)
		{
		}

		/// <summary>Initializes a new <see cref="T:System.TimeSpan" /> to a specified number of days, hours, minutes, seconds, and milliseconds.</summary>
		/// <param name="days">Number of days. </param>
		/// <param name="hours">Number of hours. </param>
		/// <param name="minutes">Number of minutes. </param>
		/// <param name="seconds">Number of seconds. </param>
		/// <param name="milliseconds">Number of milliseconds. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The parameters specify a <see cref="T:System.TimeSpan" /> value less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		public TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
		}

		internal static long CalculateTicks(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a new <see cref="T:System.TimeSpan" /> object whose value is the sum of the specified <see cref="T:System.TimeSpan" /> object and this instance.</summary>
		/// <returns>A new object that represents the value of this instance plus the value of <paramref name="ts" />.</returns>
		/// <param name="ts">A <see cref="T:System.TimeSpan" />. </param>
		/// <exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public TimeSpan Add(TimeSpan ts)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two <see cref="T:System.TimeSpan" /> values and returns an integer that indicates whether the first value is shorter than, equal to, or longer than the second value.</summary>
		/// <returns>Value Condition -1 <paramref name="t1" /> is shorter than <paramref name="t2" />0 <paramref name="t1" /> is equal to <paramref name="t2" />1 <paramref name="t1" /> is longer than <paramref name="t2" /></returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A <see cref="T:System.TimeSpan" />. </param>
		/// <filterpriority>1</filterpriority>
		public static int Compare(TimeSpan t1, TimeSpan t2)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares this instance to a specified object and returns an integer that indicates whether this instance is shorter than, equal to, or longer than the specified object.</summary>
		/// <returns>Value Condition -1 This instance is shorter than <paramref name="value" />. 0 This instance is equal to <paramref name="value" />. 1 This instance is longer than <paramref name="value" />.-or- <paramref name="value" /> is null. </returns>
		/// <param name="value">An object to compare, or null. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.TimeSpan" />. </exception>
		/// <filterpriority>1</filterpriority>
		public int CompareTo(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares this instance to a specified <see cref="T:System.TimeSpan" /> object and returns an integer that indicates whether this instance is shorter than, equal to, or longer than the <see cref="T:System.TimeSpan" /> object.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description A negative integer This instance is shorter than <paramref name="value" />. Zero This instance is equal to <paramref name="value" />. A positive integer This instance is longer than <paramref name="value" />. </returns>
		/// <param name="value">A <see cref="T:System.TimeSpan" /> object to compare to this instance.</param>
		/// <filterpriority>1</filterpriority>
		public int CompareTo(TimeSpan value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified <see cref="T:System.TimeSpan" /> object.</summary>
		/// <returns>true if <paramref name="obj" /> represents the same time interval as this instance; otherwise, false.</returns>
		/// <param name="obj">An <see cref="T:System.TimeSpan" /> object to compare with this instance. </param>
		/// <filterpriority>1</filterpriority>
		public bool Equals(TimeSpan obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="value" /> is a <see cref="T:System.TimeSpan" /> object that represents the same time interval as the current <see cref="T:System.TimeSpan" /> structure; otherwise, false.</returns>
		/// <param name="value">An object to compare with this instance. </param>
		/// <filterpriority>1</filterpriority>
		public override bool Equals(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of days, where the specification is accurate to the nearest millisecond.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
		/// <param name="value">A number of days, accurate to the nearest millisecond. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. -or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static TimeSpan FromDays(double value)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of minutes, where the specification is accurate to the nearest millisecond.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
		/// <param name="value">A number of minutes, accurate to the nearest millisecond. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static TimeSpan FromMinutes(double value)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a <see cref="T:System.TimeSpan" /> that represents a specified number of seconds, where the specification is accurate to the nearest millisecond.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that represents <paramref name="value" />.</returns>
		/// <param name="value">A number of seconds, accurate to the nearest millisecond. </param>
		/// <exception cref="T:System.OverflowException">
		///   <paramref name="value" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />.-or-<paramref name="value" /> is <see cref="F:System.Double.PositiveInfinity" />.-or-<paramref name="value" /> is <see cref="F:System.Double.NegativeInfinity" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static TimeSpan FromSeconds(double value)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		private static TimeSpan From(double value, long tickMultiplicator)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a new <see cref="T:System.TimeSpan" /> object whose value is the difference between the specified <see cref="T:System.TimeSpan" /> object and this instance.</summary>
		/// <returns>A new time interval whose value is the result of the value of this instance minus the value of <paramref name="ts" />.</returns>
		/// <param name="ts">A <see cref="T:System.TimeSpan" />. </param>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public TimeSpan Subtract(TimeSpan ts)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the string representation of the value of this instance.</summary>
		/// <returns>A string that represents the value of this instance. The return value is of the form: [-][d.]hh:mm:ss[.fffffff] Elements in square brackets ([ and ]) may not be included in the returned string. Colons and periods (: and.) are literal characters. The non-literal elements are listed in the following table.Item Description "-" A minus sign, which indicates a negative time span. No sign is included for a positive time span."d" The number of days in the time span. This element is omitted if the time span is less than one day. "hh" The number of hours in the time span, ranging from 0 to 23. "mm" The number of minutes in the time span, ranging from 0 to 59. "ss" The number of seconds in the time span, ranging from 0 to 59. "fffffff" Fractional seconds in the time span. This element is omitted if the time span does not include fractional seconds. If present, fractional seconds are always expressed using 7 decimal digits. Note:For more information about comparing the string representation of <see cref="T:System.TimeSpan" /> and Oracle data types, see article Q324577, "System.TimeSpan Does Not Match Oracle 9i INTERVAL DAY TO SECOND Data Type," in the Microsoft Knowledge Base at http://support.microsoft.com.</returns>
		/// <filterpriority>1</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Adds two specified <see cref="T:System.TimeSpan" /> instances.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> whose value is the sum of the values of <paramref name="t1" /> and <paramref name="t2" />.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A <see cref="T:System.TimeSpan" />. </param>
		/// <exception cref="T:System.OverflowException">The resulting <see cref="T:System.TimeSpan" /> is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are equal.</summary>
		/// <returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are equal; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A TimeSpan. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>true if the value of <paramref name="t1" /> is greater than the value of <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A TimeSpan. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is greater than or equal to another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>true if the value of <paramref name="t1" /> is greater than or equal to the value of <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A TimeSpan. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Indicates whether two <see cref="T:System.TimeSpan" /> instances are not equal.</summary>
		/// <returns>true if the values of <paramref name="t1" /> and <paramref name="t2" /> are not equal; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A TimeSpan. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>true if the value of <paramref name="t1" /> is less than the value of <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A TimeSpan. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Indicates whether a specified <see cref="T:System.TimeSpan" /> is less than or equal to another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>true if the value of <paramref name="t1" /> is less than or equal to the value of <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A TimeSpan. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Subtracts a specified <see cref="T:System.TimeSpan" /> from another specified <see cref="T:System.TimeSpan" />.</summary>
		/// <returns>A TimeSpan whose value is the result of the value of <paramref name="t1" /> minus the value of <paramref name="t2" />.</returns>
		/// <param name="t1">A <see cref="T:System.TimeSpan" />. </param>
		/// <param name="t2">A TimeSpan. </param>
		/// <exception cref="T:System.OverflowException">The return value is less than <see cref="F:System.TimeSpan.MinValue" /> or greater than <see cref="F:System.TimeSpan.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
