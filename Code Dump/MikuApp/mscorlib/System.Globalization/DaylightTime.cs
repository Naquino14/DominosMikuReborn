using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Defines the period of daylight saving time.</summary>
	[Serializable]
	[ComVisible(true)]
	public class DaylightTime
	{
		private DateTime m_start;

		private DateTime m_end;

		private TimeSpan m_delta;

		/// <summary>Gets the <see cref="T:System.DateTime" /> that represents the date and time when the daylight saving period begins.</summary>
		/// <returns>The <see cref="T:System.DateTime" /> that represents the date and time when the daylight saving period begins. The value is in local time.</returns>
		public DateTime Start => (DateTime)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.DateTime" /> that represents the date and time when the daylight saving period ends.</summary>
		/// <returns>The <see cref="T:System.DateTime" /> that represents the date and time when the daylight saving period ends. The value is in local time.</returns>
		public DateTime End => (DateTime)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.TimeSpan" /> that represents the difference between the standard time and the daylight saving time.</summary>
		/// <returns>The <see cref="T:System.TimeSpan" /> that represents the difference between the standard time and the daylight saving time.</returns>
		public TimeSpan Delta => (TimeSpan)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.DaylightTime" /> class.</summary>
		/// <param name="start">The <see cref="T:System.DateTime" /> that represents the date and time when the daylight saving period begins. The value must be in local time. </param>
		/// <param name="end">The <see cref="T:System.DateTime" /> that represents the date and time when the daylight saving period ends. The value must be in local time. </param>
		/// <param name="delta">The <see cref="T:System.TimeSpan" /> that represents the difference between the standard time and the daylight saving time in ticks. </param>
		public DaylightTime(DateTime start, DateTime end, TimeSpan delta)
		{
		}
	}
}
