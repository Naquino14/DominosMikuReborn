using System.Collections;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	internal class CurrentSystemTimeZone : TimeZone, IDeserializationCallback
	{
		private string m_standardName;

		private string m_daylightName;

		private Hashtable m_CachedDaylightChanges;

		private long m_ticksOffset;

		[NonSerialized]
		private TimeSpan utcOffsetWithOutDLS;

		[NonSerialized]
		private TimeSpan utcOffsetWithDLS;

		private static int this_year;

		private static DaylightTime this_year_dlt;

		internal CurrentSystemTimeZone()
		{
		}

		internal CurrentSystemTimeZone(long lnow)
		{
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		[MethodImpl(4096)]
		private static extern bool GetTimeZoneData(int year, out long[] data, out string[] names);

		public override DaylightTime GetDaylightChanges(int year)
		{
			return (DaylightTime)/*Error near IL_0001: Stack underflow*/;
		}

		public override TimeSpan GetUtcOffset(DateTime time)
		{
			return (TimeSpan)/*Error near IL_0001: Stack underflow*/;
		}

		private void OnDeserialization(DaylightTime dlt)
		{
		}

		private DaylightTime GetDaylightTimeFromData(long[] data)
		{
			return (DaylightTime)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
