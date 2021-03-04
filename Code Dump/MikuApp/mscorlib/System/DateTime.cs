using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents an instant in time, typically expressed as a date and time of day. </summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[StructLayout(3)]
	public struct DateTime : IComparable<DateTime>, IEquatable<DateTime>, IComparable, IConvertible, IFormattable
	{
		private enum Which
		{
			Day,
			DayYear,
			Month,
			Year
		}

		private const int dp400 = 146097;

		private const int dp100 = 36524;

		private const int dp4 = 1461;

		private const long w32file_epoch = 504911232000000000L;

		private const long MAX_VALUE_TICKS = 3155378975999999999L;

		internal const long UnixEpoch = 621355968000000000L;

		private const long ticks18991230 = 599264352000000000L;

		private const double OAMinValue = -657435.0;

		private const double OAMaxValue = 2958466.0;

		private const string formatExceptionMessage = "String was not recognized as a valid DateTime.";

		private TimeSpan ticks;

		private DateTimeKind kind;

		/// <summary>Represents the largest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly DateTime MaxValue;

		/// <summary>Represents the smallest possible value of <see cref="T:System.DateTime" />. This field is read-only.</summary>
		/// <filterpriority>1</filterpriority>
		public static readonly DateTime MinValue;

		private static readonly string[] ParseTimeFormats;

		private static readonly string[] ParseYearDayMonthFormats;

		private static readonly string[] ParseYearMonthDayFormats;

		private static readonly string[] ParseDayMonthYearFormats;

		private static readonly string[] ParseMonthDayYearFormats;

		private static readonly string[] MonthDayShortFormats;

		private static readonly string[] DayMonthShortFormats;

		private static readonly int[] daysmonth;

		private static readonly int[] daysmonthleap;

		private static object to_local_time_span_object;

		private static long last_now;

		/// <summary>Gets the month component of the date represented by this instance.</summary>
		/// <returns>The month component, expressed as a value between 1 and 12.</returns>
		/// <filterpriority>1</filterpriority>
		public int Month => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the day of the month represented by this instance.</summary>
		/// <returns>The day component, expressed as a value between 1 and 31.</returns>
		/// <filterpriority>1</filterpriority>
		public int Day => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the day of the week represented by this instance.</summary>
		/// <returns>A <see cref="T:System.DayOfWeek" /> enumerated constant that indicates the day of the week of this <see cref="T:System.DateTime" /> value. </returns>
		/// <filterpriority>1</filterpriority>
		public DayOfWeek DayOfWeek => (DayOfWeek)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the hour component of the date represented by this instance.</summary>
		/// <returns>The hour component, expressed as a value between 0 and 23.</returns>
		/// <filterpriority>1</filterpriority>
		public int Hour => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the minute component of the date represented by this instance.</summary>
		/// <returns>The minute component, expressed as a value between 0 and 59.</returns>
		/// <filterpriority>1</filterpriority>
		public int Minute => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the seconds component of the date represented by this instance.</summary>
		/// <returns>The seconds, between 0 and 59.</returns>
		/// <filterpriority>1</filterpriority>
		public int Second => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a <see cref="T:System.DateTime" /> object that is set to the current date and time on this computer, expressed as the local time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> whose value is the current local date and time.</returns>
		/// <filterpriority>1</filterpriority>
		public static DateTime Now => (DateTime)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the number of ticks that represent the date and time of this instance.</summary>
		/// <returns>The number of ticks that represent the date and time of this instance. The value is between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.</returns>
		/// <filterpriority>1</filterpriority>
		public long Ticks => (long)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the current date.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> set to today's date, with the time component set to 00:00:00.</returns>
		/// <filterpriority>1</filterpriority>
		public static DateTime Today => (DateTime)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the year component of the date represented by this instance.</summary>
		/// <returns>The year, between 1 and 9999.</returns>
		/// <filterpriority>1</filterpriority>
		public int Year => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value that indicates whether the time represented by this instance is based on local time, Coordinated Universal Time (UTC), or neither.</summary>
		/// <returns>One of the T:System.DateTimeKind values. The default is <see cref="F:System.DateTimeKind.Unspecified" />.</returns>
		/// <filterpriority>1</filterpriority>
		public DateTimeKind Kind => (DateTimeKind)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to a specified number of ticks.</summary>
		/// <param name="ticks">A date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001 at 00:00:00.000 in the Gregorian calendar. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="ticks" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		public DateTime(long ticks)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, and day.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> is less than 1 or greater than 9999.-or- <paramref name="month" /> is less than 1 or greater than 12.-or- <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />. </exception>
		/// <exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue" /> or more than <see cref="F:System.DateTime.MaxValue" />. </exception>
		public DateTime(int year, int month, int day)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, and second.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> is less than 1 or greater than 9999. -or- <paramref name="month" /> is less than 1 or greater than 12. -or- <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.-or- <paramref name="hour" /> is less than 0 or greater than 23. -or- <paramref name="minute" /> is less than 0 or greater than 59. -or- <paramref name="second" /> is less than 0 or greater than 59. </exception>
		/// <exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue" /> or more than <see cref="F:System.DateTime.MaxValue" />. </exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and millisecond.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="millisecond">The milliseconds (0 through 999). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> is less than 1 or greater than 9999.-or- <paramref name="month" /> is less than 1 or greater than 12.-or- <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.-or- <paramref name="hour" /> is less than 0 or greater than 23.-or- <paramref name="minute" /> is less than 0 or greater than 59.-or- <paramref name="second" /> is less than 0 or greater than 59.-or- <paramref name="millisecond" /> is less than 0 or greater than 999. </exception>
		/// <exception cref="T:System.ArgumentException">The specified parameters evaluate to less than <see cref="F:System.DateTime.MinValue" /> or more than <see cref="F:System.DateTime.MaxValue" />. </exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
		{
		}

		internal DateTime(bool check, TimeSpan value)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to a specified number of ticks and to Coordinated Universal Time (UTC) or local time.</summary>
		/// <param name="ticks">A date and time expressed in the number of 100-nanosecond intervals that have elapsed since January 1, 0001 at 00:00:00.000 in the Gregorian calendar. </param>
		/// <param name="kind">One of the enumeration values that indicates whether <paramref name="ticks" /> specifies a local time, Coordinated Universal Time (UTC), or neither.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="ticks" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="kind" /> is not one of the <see cref="T:System.DateTimeKind" /> values.</exception>
		public DateTime(long ticks, DateTimeKind kind)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.DateTime" /> structure to the specified year, month, day, hour, minute, second, and Coordinated Universal Time (UTC) or local time.</summary>
		/// <param name="year">The year (1 through 9999). </param>
		/// <param name="month">The month (1 through 12). </param>
		/// <param name="day">The day (1 through the number of days in <paramref name="month" />). </param>
		/// <param name="hour">The hours (0 through 23). </param>
		/// <param name="minute">The minutes (0 through 59). </param>
		/// <param name="second">The seconds (0 through 59). </param>
		/// <param name="kind">One of the enumeration values that indicates whether <paramref name="year" />, <paramref name="month" />, <paramref name="day" />, <paramref name="hour" />, <paramref name="minute" /> and <paramref name="second" /> specify a local time, Coordinated Universal Time (UTC), or neither.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> is less than 1 or greater than 9999. -or- <paramref name="month" /> is less than 1 or greater than 12. -or- <paramref name="day" /> is less than 1 or greater than the number of days in <paramref name="month" />.-or- <paramref name="hour" /> is less than 0 or greater than 23. -or- <paramref name="minute" /> is less than 0 or greater than 59. -or- <paramref name="second" /> is less than 0 or greater than 59. </exception>
		/// <exception cref="T:System.ArgumentException">The specified time parameters evaluate to less than <see cref="F:System.DateTime.MinValue" /> or more than <see cref="F:System.DateTime.MaxValue" />. -or-<paramref name="kind" /> is not one of the <see cref="T:System.DateTimeKind" /> values.</exception>
		public DateTime(int year, int month, int day, int hour, int minute, int second, DateTimeKind kind)
		{
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		char IConvertible.ToChar(IFormatProvider provider)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the current <see cref="T:System.DateTime" /> object.</summary>
		/// <returns>The current <see cref="T:System.DateTime" /> object.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface or null.</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return (decimal)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return (short)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return (sbyte)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases. </exception>
		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the current <see cref="T:System.DateTime" /> object to an object of a specified type.</summary>
		/// <returns>An object of the type specified by the <paramref name="type" /> parameter, with a value equivalent to the current <see cref="T:System.DateTime" /> object.</returns>
		/// <param name="type">The desired type. </param>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="type" /> is null. </exception>
		/// <exception cref="T:System.InvalidCastException">This conversion is not supported for the <see cref="T:System.DateTime" /> type.</exception>
		object IConvertible.ToType(Type targetType, IFormatProvider provider)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return (ushort)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>This conversion is not supported. Attempting to use this method throws an <see cref="T:System.InvalidCastException" />.</summary>
		/// <returns>The return value for this member is not used.</returns>
		/// <param name="provider">An object that implements the <see cref="T:System.IFormatProvider" /> interface. (This parameter is not used; specify null.)</param>
		/// <exception cref="T:System.InvalidCastException">In all cases.</exception>
		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return (ulong)/*Error near IL_0001: Stack underflow*/;
		}

		private static int AbsoluteDays(int year, int month, int day)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int FromTicks(Which what)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		internal static extern long GetTimeMonotonic();

		[MethodImpl(4096)]
		internal static extern long GetNow();

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the value of the specified <see cref="T:System.TimeSpan" /> to the value of this instance.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> whose value is the sum of the date and time represented by this instance and the time interval represented by <paramref name="value" />.</returns>
		/// <param name="value">A <see cref="T:System.TimeSpan" /> object that represents a positive or negative time interval. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		public DateTime Add(TimeSpan value)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of ticks to the value of this instance.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> whose value is the sum of the date and time represented by this instance and the time represented by <paramref name="value" />.</returns>
		/// <param name="value">A number of 100-nanosecond ticks. The <paramref name="value" /> parameter can be positive or negative. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		public DateTime AddTicks(long value)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of milliseconds to the value of this instance.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> whose value is the sum of the date and time represented by this instance and the number of milliseconds represented by <paramref name="value" />.</returns>
		/// <param name="value">A number of whole and fractional milliseconds. The <paramref name="value" /> parameter can be negative or positive. Note that this value is rounded to the nearest integer.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		public DateTime AddMilliseconds(double value)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a new <see cref="T:System.DateTime" /> that adds the specified number of seconds to the value of this instance.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> whose value is the sum of the date and time represented by this instance and the number of seconds represented by <paramref name="value" />.</returns>
		/// <param name="value">A number of whole and fractional seconds. The <paramref name="value" /> parameter can be negative or positive. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		public DateTime AddSeconds(double value)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two instances of <see cref="T:System.DateTime" /> and returns an integer that indicates whether the first instance is earlier than, the same as, or later than the second instance.</summary>
		/// <returns>A signed number indicating the relative values of <paramref name="t1" /> and <paramref name="t2" />.Value Type Condition Less than zero <paramref name="t1" /> is earlier than <paramref name="t2" />. Zero <paramref name="t1" /> is the same as <paramref name="t2" />. Greater than zero <paramref name="t1" /> is later than <paramref name="t2" />. </returns>
		/// <param name="t1">The first object to compare. </param>
		/// <param name="t2">The second object to compare.</param>
		/// <filterpriority>1</filterpriority>
		public static int Compare(DateTime t1, DateTime t2)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares the value of this instance to a specified object that contains a specified <see cref="T:System.DateTime" /> value, and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="value" />.Value Description Less than zero This instance is earlier than <paramref name="value" />. Zero This instance is the same as <paramref name="value" />. Greater than zero This instance is later than <paramref name="value" />, or <paramref name="value" /> is null. </returns>
		/// <param name="value">A boxed object to compare, or null. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not a <see cref="T:System.DateTime" />. </exception>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares the value of this instance to a specified <see cref="T:System.DateTime" /> value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="T:System.DateTime" /> value.</summary>
		/// <returns>A signed number indicating the relative values of this instance and the <paramref name="value" /> parameter.Value Description Less than zero This instance is earlier than <paramref name="value" />. Zero This instance is the same as <paramref name="value" />. Greater than zero This instance is later than <paramref name="value" />. </returns>
		/// <param name="value">The object to compare to the current instance. </param>
		/// <filterpriority>2</filterpriority>
		public int CompareTo(DateTime value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether this instance is equal to the specified <see cref="T:System.DateTime" /> instance.</summary>
		/// <returns>true if the <paramref name="value" /> parameter equals the value of this instance; otherwise, false.</returns>
		/// <param name="value">The object to compare to this instance. </param>
		/// <filterpriority>2</filterpriority>
		public bool Equals(DateTime value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Serializes the current <see cref="T:System.DateTime" /> object to a 64-bit binary value that subsequently can be used to recreate the <see cref="T:System.DateTime" /> object.</summary>
		/// <returns>A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind" /> and <see cref="P:System.DateTime.Ticks" /> properties. </returns>
		/// <filterpriority>2</filterpriority>
		public long ToBinary()
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Deserializes a 64-bit binary value and recreates an original serialized <see cref="T:System.DateTime" /> object.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object that is equivalent to the <see cref="T:System.DateTime" /> object that was serialized by the <see cref="M:System.DateTime.ToBinary" /> method.</returns>
		/// <param name="dateData">A 64-bit signed integer that encodes the <see cref="P:System.DateTime.Kind" /> property in a 2-bit field and the <see cref="P:System.DateTime.Ticks" /> property in a 62-bit field. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="dateData" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>1</filterpriority>
		public static DateTime FromBinary(long dateData)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a new <see cref="T:System.DateTime" /> object that has the same number of ticks as the specified <see cref="T:System.DateTime" />, but is designated as either local time, Coordinated Universal Time (UTC), or neither, as indicated by the specified <see cref="T:System.DateTimeKind" /> value.</summary>
		/// <returns>A new object that has the same number of ticks as the object represented by the <paramref name="value" /> parameter and the <see cref="T:System.DateTimeKind" /> value specified by the <paramref name="kind" /> parameter.</returns>
		/// <param name="value">A <see cref="T:System.DateTime" /> object.</param>
		/// <param name="kind">One of the <see cref="T:System.DateTimeKind" /> values.</param>
		/// <filterpriority>2</filterpriority>
		public static DateTime SpecifyKind(DateTime value, DateTimeKind kind)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the number of days in the specified month and year.</summary>
		/// <returns>The number of days in <paramref name="month" /> for the specified <paramref name="year" />.For example, if <paramref name="month" /> equals 2 for February, the return value is 28 or 29 depending upon whether <paramref name="year" /> is a leap year.</returns>
		/// <param name="year">The year. </param>
		/// <param name="month">The month (a number ranging from 1 to 12). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="month" /> is less than 1 or greater than 12.-or-<paramref name="year" /> is less than 1 or greater than 9999.</exception>
		/// <filterpriority>1</filterpriority>
		public static int DaysInMonth(int year, int month)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a value indicating whether this instance is equal to a specified object.</summary>
		/// <returns>true if <paramref name="value" /> is an instance of <see cref="T:System.DateTime" /> and equals the value of this instance; otherwise, false.</returns>
		/// <param name="value">An object to compare to this instance. </param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private void CheckDateTimeKind(DateTimeKind kind)
		{
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer hash code.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the <see cref="T:System.TypeCode" /> for value type <see cref="T:System.DateTime" />.</summary>
		/// <returns>The enumerated constant, <see cref="F:System.TypeCode.DateTime" />.</returns>
		/// <filterpriority>2</filterpriority>
		public TypeCode GetTypeCode()
		{
			return (TypeCode)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an indication whether the specified year is a leap year.</summary>
		/// <returns>true if <paramref name="year" /> is a leap year; otherwise, false.</returns>
		/// <param name="year">A 4-digit year. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> is less than 1 or greater than 9999.</exception>
		/// <filterpriority>1</filterpriority>
		public static bool IsLeapYear(int year)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified culture-specific format information.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> equivalent to the date and time contained in <paramref name="s" /> as specified by <paramref name="provider" />.</returns>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific format information about <paramref name="s" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="s" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		/// <filterpriority>1</filterpriority>
		public static DateTime Parse(string s, IFormatProvider provider)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the specified string representation of a date and time to its <see cref="T:System.DateTime" /> equivalent using the specified culture-specific format information and formatting style.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> equivalent to the date and time contained in <paramref name="s" /> as specified by <paramref name="provider" /> and <paramref name="styles" />.</returns>
		/// <param name="s">A string containing a date and time to convert. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information about <paramref name="s" />. </param>
		/// <param name="styles">A bitwise combination of the enumeration values that indicates the style elements that can be present in <paramref name="s" /> for the parse operation to succeed and that defines how to interpret the parsed date in relation to the current time zone or the current date. A typical value to specify is <see cref="F:System.Globalization.DateTimeStyles.None" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="s" /> is null. </exception>
		/// <exception cref="T:System.FormatException">
		///   <paramref name="s" /> does not contain a valid string representation of a date and time. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="styles" /> contains an invalid combination of <see cref="T:System.Globalization.DateTimeStyles" /> values. For example, both <see cref="F:System.Globalization.DateTimeStyles.AssumeLocal" /> and <see cref="F:System.Globalization.DateTimeStyles.AssumeUniversal" />.</exception>
		/// <filterpriority>1</filterpriority>
		public static DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		internal static bool CoreParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result, out DateTimeOffset dto, bool setExceptionOnError, ref Exception exception)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static string[] YearMonthDayFormats(DateTimeFormatInfo dfi, bool setExceptionOnError, ref Exception exc)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		private static int _ParseNumber(string s, int valuePos, int min_digits, int digits, bool leadingzero, bool sloppy_parsing, out int num_parsed)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int _ParseEnum(string s, int sPos, string[] values, string[] invValues, bool exact, out int num_parsed)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool _ParseString(string s, int sPos, int maxlength, string value, out int num_parsed)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool _ParseAmPm(string s, int valuePos, int num, DateTimeFormatInfo dfi, bool exact, out int num_parsed, ref int ampm)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool _ParseTimeSeparator(string s, int sPos, DateTimeFormatInfo dfi, bool exact, out int num_parsed)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool _ParseDateSeparator(string s, int sPos, DateTimeFormatInfo dfi, bool exact, out int num_parsed)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool IsLetter(string s, int pos)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool _DoParse(string s, string firstPart, string secondPart, bool exact, out DateTime result, out DateTimeOffset dto, DateTimeFormatInfo dfi, DateTimeStyles style, bool firstPartIsDate, ref bool incompleteFormat, ref bool longYear)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool ParseExact(string s, string[] formats, DateTimeFormatInfo dfi, DateTimeStyles style, out DateTime ret, bool exact, ref bool longYear, bool setExceptionOnError, ref Exception exception)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Subtracts the specified date and time from this instance.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> interval equal to the date and time represented by this instance minus the date and time represented by <paramref name="value" />.</returns>
		/// <param name="value">An instance of <see cref="T:System.DateTime" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		public TimeSpan Subtract(DateTime value)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Subtracts the specified duration from this instance.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> equal to the date and time represented by this instance minus the time interval represented by <paramref name="value" />.</returns>
		/// <param name="value">An instance of <see cref="T:System.TimeSpan" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The result is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>2</filterpriority>
		public DateTime Subtract(TimeSpan value)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation.</summary>
		/// <returns>A string representation of the value of the current <see cref="T:System.DateTime" /> object.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by the current culture. </exception>
		/// <filterpriority>1</filterpriority>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified culture-specific format information.</summary>
		/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="provider" />.</returns>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />. </exception>
		/// <filterpriority>1</filterpriority>
		public string ToString(IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to its equivalent string representation using the specified format and culture-specific format information.</summary>
		/// <returns>A string representation of value of the current <see cref="T:System.DateTime" /> object as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
		/// <param name="format">A standard or custom date and time format string. </param>
		/// <param name="provider">An object that supplies culture-specific formatting information. </param>
		/// <exception cref="T:System.FormatException">The length of <paramref name="format" /> is 1, and it is not one of the format specifier characters defined for <see cref="T:System.Globalization.DateTimeFormatInfo" />.-or- <paramref name="format" /> does not contain a valid custom format pattern. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The date and time is outside the range of dates supported by the calendar used by <paramref name="provider" />. </exception>
		/// <filterpriority>1</filterpriority>
		public string ToString(string format, IFormatProvider provider)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to local time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Local" />, and whose value is the local time equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented as a <see cref="T:System.DateTime" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		public DateTime ToLocalTime()
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Converts the value of the current <see cref="T:System.DateTime" /> object to Coordinated Universal Time (UTC).</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object whose <see cref="P:System.DateTime.Kind" /> property is <see cref="F:System.DateTimeKind.Utc" />, and whose value is the UTC equivalent to the value of the current <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MaxValue" /> if the converted value is too large to be represented by a <see cref="T:System.DateTime" /> object, or <see cref="F:System.DateTime.MinValue" /> if the converted value is too small to be represented by a <see cref="T:System.DateTime" /> object.</returns>
		/// <filterpriority>2</filterpriority>
		public DateTime ToUniversalTime()
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Adds a specified time interval to a specified date and time, yielding a new date and time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> that is the sum of the values of <paramref name="d" /> and <paramref name="t" />.</returns>
		/// <param name="d">A <see cref="T:System.DateTime" />. </param>
		/// <param name="t">A <see cref="T:System.TimeSpan" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static DateTime operator +(DateTime d, TimeSpan t)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.DateTime" /> are equal.</summary>
		/// <returns>true if <paramref name="d1" /> and <paramref name="d2" /> represent the same date and time; otherwise, false.</returns>
		/// <param name="d1">A <see cref="T:System.DateTime" />. </param>
		/// <param name="d2">A <see cref="T:System.DateTime" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator ==(DateTime d1, DateTime d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is greater than another specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>true if <paramref name="t1" /> is greater than <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.DateTime" />. </param>
		/// <param name="t2">A <see cref="T:System.DateTime" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator >(DateTime t1, DateTime t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is greater than or equal to another specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>true if <paramref name="t1" /> is greater than or equal to <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.DateTime" />. </param>
		/// <param name="t2">A <see cref="T:System.DateTime" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator >=(DateTime t1, DateTime t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether two specified instances of <see cref="T:System.DateTime" /> are not equal.</summary>
		/// <returns>true if <paramref name="d1" /> and <paramref name="d2" /> do not represent the same date and time; otherwise, false.</returns>
		/// <param name="d1">A <see cref="T:System.DateTime" />. </param>
		/// <param name="d2">A <see cref="T:System.DateTime" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator !=(DateTime d1, DateTime d2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is less than another specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>true if <paramref name="t1" /> is less than <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.DateTime" />. </param>
		/// <param name="t2">A <see cref="T:System.DateTime" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator <(DateTime t1, DateTime t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether one specified <see cref="T:System.DateTime" /> is less than or equal to another specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>true if <paramref name="t1" /> is less than or equal to <paramref name="t2" />; otherwise, false.</returns>
		/// <param name="t1">A <see cref="T:System.DateTime" />. </param>
		/// <param name="t2">A <see cref="T:System.DateTime" />. </param>
		/// <filterpriority>3</filterpriority>
		public static bool operator <=(DateTime t1, DateTime t2)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Subtracts a specified date and time from another specified date and time and returns a time interval.</summary>
		/// <returns>A <see cref="T:System.TimeSpan" /> that is the time interval between <paramref name="d1" /> and <paramref name="d2" />; that is, <paramref name="d1" /> minus <paramref name="d2" />.</returns>
		/// <param name="d1">A <see cref="T:System.DateTime" /> (the minuend). </param>
		/// <param name="d2">A <see cref="T:System.DateTime" /> (the subtrahend). </param>
		/// <filterpriority>3</filterpriority>
		public static TimeSpan operator -(DateTime d1, DateTime d2)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Subtracts a specified time interval from a specified date and time and returns a new date and time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> whose value is the value of <paramref name="d" /> minus the value of <paramref name="t" />.</returns>
		/// <param name="d">A <see cref="T:System.DateTime" />. </param>
		/// <param name="t">A <see cref="T:System.TimeSpan" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The resulting <see cref="T:System.DateTime" /> is less than <see cref="F:System.DateTime.MinValue" /> or greater than <see cref="F:System.DateTime.MaxValue" />. </exception>
		/// <filterpriority>3</filterpriority>
		public static DateTime operator -(DateTime d, TimeSpan t)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
