using System.Globalization;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Represents a time zone.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public abstract class TimeZone
	{
		private static TimeZone currentTimeZone;

		/// <summary>Gets the time zone of the current computer.</summary>
		/// <returns>A <see cref="T:System.TimeZone" /> object that represents the current local time zone.</returns>
		/// <filterpriority>1</filterpriority>
		public static TimeZone CurrentTimeZone => (TimeZone)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.TimeZone" /> class.</summary>
		protected TimeZone()
		{
		}

		/// <summary>Returns the daylight saving time period for a particular year.</summary>
		/// <returns>A <see cref="T:System.Globalization.DaylightTime" /> object that contains the start and end date for daylight saving time in <paramref name="year" />.</returns>
		/// <param name="year">The year that the daylight saving time period applies to. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="year" /> is less than 1 or greater than 9999. </exception>
		/// <filterpriority>2</filterpriority>
		public abstract DaylightTime GetDaylightChanges(int year);

		/// <summary>Returns the Coordinated Universal Time (UTC) offset for the specified local time.</summary>
		/// <returns>The Coordinated Universal Time (UTC) offset from <paramref name="Time" />.</returns>
		/// <param name="time">A date and time value.</param>
		/// <filterpriority>2</filterpriority>
		public abstract TimeSpan GetUtcOffset(DateTime time);

		/// <summary>Returns a value indicating whether the specified date and time is within a daylight saving time period.</summary>
		/// <returns>true if <paramref name="time" /> is in a daylight saving time period; otherwise, false.</returns>
		/// <param name="time">A date and time. </param>
		/// <filterpriority>2</filterpriority>
		public virtual bool IsDaylightSavingTime(DateTime time)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns a value indicating whether the specified date and time is within the specified daylight saving time period.</summary>
		/// <returns>true if <paramref name="time" /> is in <paramref name="daylightTimes" />; otherwise, false.</returns>
		/// <param name="time">A date and time. </param>
		/// <param name="daylightTimes">A daylight saving time period. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="daylightTimes" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static bool IsDaylightSavingTime(DateTime time, DaylightTime daylightTimes)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns the local time that corresponds to a specified date and time value.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object whose value is the local time that corresponds to <paramref name="time" />.</returns>
		/// <param name="time">A Coordinated Universal Time (UTC) time. </param>
		/// <filterpriority>2</filterpriority>
		public virtual DateTime ToLocalTime(DateTime time)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the Coordinated Universal Time (UTC) that corresponds to a specified time.</summary>
		/// <returns>A <see cref="T:System.DateTime" /> object whose value is the Coordinated Universal Time (UTC) that corresponds to <paramref name="time" />.</returns>
		/// <param name="time">A date and time. </param>
		/// <filterpriority>2</filterpriority>
		public virtual DateTime ToUniversalTime(DateTime time)
		{
			return (DateTime)/*Error near IL_0001: Stack underflow*/;
		}

		internal TimeSpan GetLocalTimeDiff(DateTime time)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		internal TimeSpan GetLocalTimeDiff(DateTime time, TimeSpan utc_offset)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
