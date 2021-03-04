namespace System.Threading
{
	/// <summary>Represents a thread synchronization event.</summary>
	/// <filterpriority>2</filterpriority>
	public class EventWaitHandle : WaitHandle
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.EventWaitHandle" /> class, specifying whether the wait handle is initially signaled, and whether it resets automatically or manually.</summary>
		/// <param name="initialState">true to set the initial state to signaled; false to set it to nonsignaled.</param>
		/// <param name="mode">One of the <see cref="T:System.Threading.EventResetMode" /> values that determines whether the event resets automatically or manually.</param>
		public EventWaitHandle(bool initialState, EventResetMode mode)
		{
		}

		private bool IsManualReset(EventResetMode mode)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Sets the state of the event to signaled, allowing one or more waiting threads to proceed.</summary>
		/// <returns>true if the operation succeeds; otherwise, false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:System.Threading.EventWaitHandle.Close" /> method was previously called on this <see cref="T:System.Threading.EventWaitHandle" />.</exception>
		/// <filterpriority>2</filterpriority>
		public bool Set()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
