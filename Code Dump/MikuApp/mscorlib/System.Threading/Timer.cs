using System.Collections;
using System.Runtime.InteropServices;

namespace System.Threading
{
	/// <summary>Provides a mechanism for executing a method at specified intervals. This class cannot be inherited.</summary>
	/// <filterpriority>1</filterpriority>
	[ComVisible(true)]
	public sealed class Timer : MarshalByRefObject, IDisposable
	{
		private sealed class Scheduler
		{
			private static Scheduler instance;

			private SortedList list;

			public static Scheduler Instance => (Scheduler)/*Error near IL_0001: Stack underflow*/;

			private Scheduler()
			{
			}

			static Scheduler()
			{
			}

			public void Remove(Timer timer)
			{
			}

			public void Change(Timer timer, long new_next_run)
			{
			}

			private void Add(Timer timer)
			{
			}

			private int InternalRemove(Timer timer)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}

			private void SchedulerThread()
			{
			}

			private void ShrinkIfNeeded(ArrayList list, int initial)
			{
			}
		}

		private sealed class TimerComparer : IComparer
		{
			public int Compare(object x, object y)
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
		}

		private const long MaxValue = 4294967294L;

		private static Scheduler scheduler;

		private TimerCallback callback;

		private object state;

		private long due_time_ms;

		private long period_ms;

		private long next_run;

		private bool disposed;

		/// <summary>Initializes a new instance of the Timer class, using <see cref="T:System.TimeSpan" /> values to measure time intervals.</summary>
		/// <param name="callback">A <see cref="T:System.Threading.TimerCallback" /> delegate representing a method to be executed. </param>
		/// <param name="state">An object containing information to be used by the callback method, or null. </param>
		/// <param name="dueTime">The <see cref="T:System.TimeSpan" /> representing the amount of time to delay before the <paramref name="callback" /> parameter invokes its methods. Specify negative one (-1) milliseconds to prevent the timer from starting. Specify zero (0) to start the timer immediately. </param>
		/// <param name="period">The time interval between invocations of the methods referenced by <paramref name="callback" />. Specify negative one (-1) milliseconds to disable periodic signaling. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The number of milliseconds in the value of <paramref name="dueTime" /> or <paramref name="period" /> is negative and not equal to <see cref="F:System.Threading.Timeout.Infinite" />, or is greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="callback" /> parameter is null. </exception>
		public Timer(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period)
		{
		}

		private void Init(TimerCallback callback, object state, long dueTime, long period)
		{
		}

		/// <summary>Releases all resources used by the current instance of <see cref="T:System.Threading.Timer" />.</summary>
		/// <filterpriority>2</filterpriority>
		public void Dispose()
		{
		}

		private bool Change(long dueTime, long period, bool first)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
