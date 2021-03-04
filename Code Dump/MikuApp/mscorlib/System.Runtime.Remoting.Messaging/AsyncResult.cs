using System.Runtime.InteropServices;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Encapsulates the results of an asynchronous operation on a delegate.</summary>
	[ComVisible(true)]
	public class AsyncResult : IAsyncResult, IMessageSink
	{
		private object async_state;

		private WaitHandle handle;

		private object async_delegate;

		private IntPtr data;

		private object object_data;

		private bool sync_completed;

		private bool completed;

		private bool endinvoke_called;

		private object async_callback;

		private ExecutionContext current;

		private ExecutionContext original;

		private MonoMethodMessage call_message;

		private IMessageCtrl message_ctrl;

		private IMessage reply_message;

		/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</summary>
		/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that encapsulates Win32 synchronization handles, and allows the implementation of various synchronization schemes.</returns>
		public virtual WaitHandle AsyncWaitHandle => (WaitHandle)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the delegate object on which the asynchronous call was invoked.</summary>
		/// <returns>The delegate object on which the asynchronous call was invoked.</returns>
		public virtual object AsyncDelegate => (object)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Implements the <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface.</summary>
		/// <returns>No value is returned.</returns>
		/// <param name="msg">The request <see cref="T:System.Runtime.Remoting.Messaging.IMessage" /> interface. </param>
		/// <param name="replySink">The response <see cref="T:System.Runtime.Remoting.Messaging.IMessageSink" /> interface. </param>
		public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			return (IMessageCtrl)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Sets an <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call, which provides a way to control asynchronous messages after they have been dispatched.</summary>
		/// <param name="mc">The <see cref="T:System.Runtime.Remoting.Messaging.IMessageCtrl" /> for the current remote method call. </param>
		public virtual void SetMessageCtrl(IMessageCtrl mc)
		{
		}

		/// <summary>Synchronously processes a response message returned by a method call on a remote object.</summary>
		/// <returns>Returns null.</returns>
		/// <param name="msg">A response message to a method call on a remote object.</param>
		public virtual IMessage SyncProcessMessage(IMessage msg)
		{
			return (IMessage)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
