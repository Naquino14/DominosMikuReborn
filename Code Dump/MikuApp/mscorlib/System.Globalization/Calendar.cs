using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Represents time in divisions, such as weeks, months, and years.</summary>
	[Serializable]
	[ComVisible(true)]
	public abstract class Calendar : ICloneable
	{
		/// <summary>Represents the current era of the current calendar. </summary>
		public const int CurrentEra = 0;

		[NonSerialized]
		private bool m_isReadOnly;

		[NonSerialized]
		internal int twoDigitYearMax;

		[NonSerialized]
		private int M_MaxYearValue;

		[NonSerialized]
		internal string[] M_AbbrEraNames;

		[NonSerialized]
		internal string[] M_EraNames;

		internal int m_currentEraValue;

		/// <summary>When overridden in a derived class, gets the list of eras in the current calendar.</summary>
		/// <returns>An array of integers that represents the eras in the current calendar.</returns>
		public abstract int[] Eras
		{
			get;
		}

		internal string[] EraNames => (string[])/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.Calendar" /> class.</summary>
		protected Calendar()
		{
		}

		/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Globalization.Calendar" /> object.</summary>
		/// <returns>A new instance of <see cref="T:System.Object" /> that is the memberwise clone of the current <see cref="T:System.Globalization.Calendar" /> object.</returns>
		[ComVisible(false)]
		public virtual object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		internal void CheckReadOnly()
		{
		}

		/// <summary>When overridden in a derived class, returns the day of the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>A positive integer that represents the day of the month in the <paramref name="time" /> parameter.</returns>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		public abstract int GetDayOfMonth(DateTime time);

		/// <summary>When overridden in a derived class, returns the day of the week in the specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>A <see cref="T:System.DayOfWeek" /> value that represents the day of the week in the <paramref name="time" /> parameter.</returns>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		public abstract DayOfWeek GetDayOfWeek(DateTime time);

		/// <summary>When overridden in a derived class, returns the era in the specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>An integer that represents the era in <paramref name="time" />.</returns>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		public abstract int GetEra(DateTime time);

		/// <summary>When overridden in a derived class, returns the month in the specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>A positive integer that represents the month in <paramref name="time" />.</returns>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		public abstract int GetMonth(DateTime time);

		/// <summary>When overridden in a derived class, returns the year in the specified <see cref="T:System.DateTime" />.</summary>
		/// <returns>An integer that represents the year in <paramref name="time" />.</returns>
		/// <param name="time">The <see cref="T:System.DateTime" /> to read. </param>
		public abstract int GetYear(DateTime time);
	}
}
