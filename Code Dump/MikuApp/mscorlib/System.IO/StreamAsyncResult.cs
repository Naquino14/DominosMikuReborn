using System.Threading;

namespace System.IO
{
	internal class StreamAsyncResult : IAsyncResult
	{
		private object state;

		private bool completed;

		private bool done;

		private Exception exc;

		private int nbytes;

		private ManualResetEvent wh;

		public WaitHandle AsyncWaitHandle => (WaitHandle)/*Error near IL_0001: Stack underflow*/;

		public Exception Exception => (Exception)/*Error near IL_0001: Stack underflow*/;

		public int NBytes => (int)/*Error near IL_0001: Stack underflow*/;

		public bool Done
		{
			get
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
			set
			{
			}
		}

		public StreamAsyncResult(object state)
		{
		}

		public void SetComplete(Exception e)
		{
		}

		public void SetComplete(Exception e, int nbytes)
		{
		}
	}
}
