using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Defines how <see cref="T:System.DateTime" /> values are formatted and displayed, depending on the culture.</summary>
	[Serializable]
	[ComVisible(true)]
	public sealed class DateTimeFormatInfo : ICloneable, IFormatProvider
	{
		private const string _RoundtripPattern = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";

		private static readonly string MSG_READONLY;

		private static readonly string MSG_ARRAYSIZE_MONTH;

		private static readonly string MSG_ARRAYSIZE_DAY;

		private static readonly string[] INVARIANT_ABBREVIATED_DAY_NAMES;

		private static readonly string[] INVARIANT_DAY_NAMES;

		private static readonly string[] INVARIANT_ABBREVIATED_MONTH_NAMES;

		private static readonly string[] INVARIANT_MONTH_NAMES;

		private static readonly string[] INVARIANT_SHORT_DAY_NAMES;

		private static DateTimeFormatInfo theInvariantDateTimeFormatInfo;

		private bool m_isReadOnly;

		private string amDesignator;

		private string pmDesignator;

		private string dateSeparator;

		private string timeSeparator;

		private string shortDatePattern;

		private string longDatePattern;

		private string shortTimePattern;

		private string longTimePattern;

		private string monthDayPattern;

		private string yearMonthPattern;

		private string fullDateTimePattern;

		private string _RFC1123Pattern;

		private string _SortableDateTimePattern;

		private string _UniversalSortableDateTimePattern;

		private int firstDayOfWeek;

		private Calendar calendar;

		private int calendarWeekRule;

		private string[] abbreviatedDayNames;

		private string[] dayNames;

		private string[] monthNames;

		private string[] abbreviatedMonthNames;

		private string[] allShortDatePatterns;

		private string[] allLongDatePatterns;

		private string[] allShortTimePatterns;

		private string[] allLongTimePatterns;

		private string[] monthDayPatterns;

		private string[] yearMonthPatterns;

		private string[] shortDayNames;

		private int nDataItem;

		private bool m_useUserOverride;

		private bool m_isDefaultCalendar;

		private int CultureID;

		private bool bUseCalendarInfo;

		private string generalShortTimePattern;

		private string generalLongTimePattern;

		private string[] m_eraNames;

		private string[] m_abbrevEraNames;

		private string[] m_abbrevEnglishEraNames;

		private string[] m_dateWords;

		private int[] optionalCalendars;

		private string[] m_superShortDayNames;

		private string[] genitiveMonthNames;

		private string[] m_genitiveAbbreviatedMonthNames;

		private string[] leapYearMonthNames;

		private DateTimeFormatFlags formatFlags;

		private string m_name;

		private volatile string[] all_date_time_patterns;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only.</summary>
		/// <returns>true if the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only; otherwise, false.</returns>
		public bool IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		internal string[] RawAbbreviatedDayNames => (string[])/*Error near IL_0001: Stack underflow*/;

		internal string[] RawAbbreviatedMonthNames => (string[])/*Error near IL_0001: Stack underflow*/;

		internal string[] RawDayNames => (string[])/*Error near IL_0001: Stack underflow*/;

		internal string[] RawMonthNames => (string[])/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the string designator for hours that are "ante meridiem" (before noon).</summary>
		/// <returns>The string designator for hours that are "ante meridiem" (before noon). The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "AM".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string AMDesignator => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the string designator for hours that are "post meridiem" (after noon).</summary>
		/// <returns>The string designator for hours that are "post meridiem" (after noon). The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "PM".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string PMDesignator => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the string that separates the components of a date, that is, the year, month, and day.</summary>
		/// <returns>The string that separates the components of a date, that is, the year, month, and day. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is "/".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string DateSeparator => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the string that separates the components of time, that is, the hour, minutes, and seconds.</summary>
		/// <returns>The string that separates the components of time. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is ":".</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string TimeSeparator => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the format pattern for a long date value, which is associated with the "D" format pattern.</summary>
		/// <returns>The format pattern for a long date value, which is associated with the "D" format pattern.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string LongDatePattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the format pattern for a short date value, which is associated with the "d" format pattern.</summary>
		/// <returns>The format pattern for a short date value, which is associated with the "d" format pattern.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> object is read-only. </exception>
		public string ShortDatePattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the format pattern for a short time value, which is associated with the "t" format pattern.</summary>
		/// <returns>The format pattern for a short time value, which is associated with the "t" format pattern.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string ShortTimePattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the format pattern for a long time value, which is associated with the "T" format pattern.</summary>
		/// <returns>The format pattern for a long time value, which is associated with the "T" format pattern.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string LongTimePattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the format pattern for a month and day value, which is associated with the "m" and "M" format patterns.</summary>
		/// <returns>The format pattern for a month and day value, which is associated with the "m" and "M" format patterns.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string MonthDayPattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the format pattern for a year and month value, which is associated with the "y" and "Y" format patterns.</summary>
		/// <returns>The format pattern for a year and month value, which is associated with the "y" and "Y" format patterns.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string YearMonthPattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the format pattern for a long date and long time value, which is associated with the "F" format pattern.</summary>
		/// <returns>The format pattern for a long date and long time value, which is associated with the "F" format pattern.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public string FullDateTimePattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that formats values based on the current culture.</summary>
		/// <returns>A read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object based on the <see cref="T:System.Globalization.CultureInfo" /> object for the current thread.</returns>
		public static DateTimeFormatInfo CurrentInfo => (DateTimeFormatInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the default read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> that is culture-independent (invariant).</summary>
		/// <returns>The default read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> object that is culture-independent (invariant).</returns>
		public static DateTimeFormatInfo InvariantInfo => (DateTimeFormatInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the calendar to use for the current culture.</summary>
		/// <returns>The <see cref="T:System.Globalization.Calendar" /> indicating the calendar to use for the current culture. The default for <see cref="P:System.Globalization.DateTimeFormatInfo.InvariantInfo" /> is the <see cref="T:System.Globalization.GregorianCalendar" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is being set to null. </exception>
		/// <exception cref="T:System.ArgumentException">The property is being set to a <see cref="T:System.Globalization.Calendar" /> that is not valid for the current culture. </exception>
		/// <exception cref="T:System.InvalidOperationException">The property is being set and the <see cref="T:System.Globalization.DateTimeFormatInfo" /> is read-only. </exception>
		public Calendar Calendar
		{
			get
			{
				return (Calendar)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets the format pattern for a time value, which is based on the Internet Engineering Task Force (IETF) Request for Comments (RFC) 1123 specification and is associated with the "r" and "R" format patterns.</summary>
		/// <returns>The format pattern for a time value, which is based on the IETF RFC 1123 specification and is associated with the "r" and "R" format patterns.</returns>
		public string RFC1123Pattern => (string)/*Error near IL_0001: Stack underflow*/;

		internal string RoundtripPattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the format pattern for a sortable date and time value, which is associated with the "s" format pattern.</summary>
		/// <returns>The format pattern for a sortable date and time value, which is associated with the "s" format pattern.</returns>
		public string SortableDateTimePattern => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the format pattern for a universal sortable date and time value, which is associated with the "u" format pattern.</summary>
		/// <returns>The format pattern for a universal sortable date and time value, which is associated with the "u" format pattern.</returns>
		public string UniversalSortableDateTimePattern => (string)/*Error near IL_0001: Stack underflow*/;

		internal DateTimeFormatInfo(bool read_only)
		{
		}

		/// <summary>Initializes a new writable instance of the <see cref="T:System.Globalization.DateTimeFormatInfo" /> class that is culture-independent (invariant).</summary>
		public DateTimeFormatInfo()
		{
		}

		/// <summary>Returns the <see cref="T:System.Globalization.DateTimeFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</summary>
		/// <returns>A <see cref="T:System.Globalization.DateTimeFormatInfo" /> associated with the specified <see cref="T:System.IFormatProvider" />.</returns>
		/// <param name="provider">The <see cref="T:System.IFormatProvider" /> that gets the <see cref="T:System.Globalization.DateTimeFormatInfo" />.-or- null to get <see cref="P:System.Globalization.DateTimeFormatInfo.CurrentInfo" />. </param>
		public static DateTimeFormatInfo GetInstance(IFormatProvider provider)
		{
			return (DateTimeFormatInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> wrapper.</summary>
		/// <returns>A read-only <see cref="T:System.Globalization.DateTimeFormatInfo" /> wrapper around <paramref name="dtfi" />.</returns>
		/// <param name="dtfi">The <see cref="T:System.Globalization.DateTimeFormatInfo" /> to wrap. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="dtfi" /> is null. </exception>
		public static DateTimeFormatInfo ReadOnly(DateTimeFormatInfo dtfi)
		{
			return (DateTimeFormatInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		/// <returns>A new <see cref="T:System.Globalization.DateTimeFormatInfo" /> copied from the original <see cref="T:System.Globalization.DateTimeFormatInfo" />.</returns>
		public object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns an object of the specified type that provides a <see cref="T:System.DateTime" /> formatting service.</summary>
		/// <returns>The current <see cref="T:System.Globalization.DateTimeFormatInfo" />, if <paramref name="formatType" /> is the same as the type of the current <see cref="T:System.Globalization.DateTimeFormatInfo" />; otherwise, null.</returns>
		/// <param name="formatType">The <see cref="T:System.Type" /> of the required formatting service. </param>
		public object GetFormat(Type formatType)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the culture-specific abbreviated name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <returns>The culture-specific abbreviated name of the month represented by <paramref name="month" />.</returns>
		/// <param name="month">An integer from 1 through 13 representing the name of the month to retrieve. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="month" /> is less than 1 or greater than 13. </exception>
		public string GetAbbreviatedMonthName(int month)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the string containing the name of the specified era.</summary>
		/// <returns>A string containing the name of the era.</returns>
		/// <param name="era">The integer representing the era. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="era" /> does not represent a valid era in the calendar specified in the <see cref="P:System.Globalization.DateTimeFormatInfo.Calendar" /> property. </exception>
		public string GetEraName(int era)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the culture-specific full name of the specified month based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <returns>The culture-specific full name of the month represented by <paramref name="month" />.</returns>
		/// <param name="month">An integer from 1 through 13 representing the name of the month to retrieve. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="month" /> is less than 1 or greater than 13. </exception>
		public string GetMonthName(int month)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal string[] GetAllDateTimePatternsInternal()
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		private void FillAllDateTimePatterns()
		{
		}

		internal string[] GetAllRawDateTimePatterns(char format)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the culture-specific full name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <returns>The culture-specific full name of the day of the week represented by <paramref name="dayofweek" />.</returns>
		/// <param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value. </exception>
		public string GetDayName(DayOfWeek dayofweek)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the culture-specific abbreviated name of the specified day of the week based on the culture associated with the current <see cref="T:System.Globalization.DateTimeFormatInfo" /> object.</summary>
		/// <returns>The culture-specific abbreviated name of the day of the week represented by <paramref name="dayofweek" />.</returns>
		/// <param name="dayofweek">A <see cref="T:System.DayOfWeek" /> value. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="dayofweek" /> is not a valid <see cref="T:System.DayOfWeek" /> value. </exception>
		public string GetAbbreviatedDayName(DayOfWeek dayofweek)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private void FillInvariantPatterns()
		{
		}

		private string[] PopulateCombinedList(string[] dates, string[] times)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
