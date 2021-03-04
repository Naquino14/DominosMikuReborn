using System.Threading;

namespace System.IO
{
	internal class FileStreamAsyncResult : IAsyncResult
	{
		private object state;

		private bool completed;

		private bool done;

		private Exception exc;

		private ManualResetEvent wh;

		private AsyncCallback cb;

		private bool completedSynch;

		public byte[] Buffer;

		public int Offset;

		public int Count;

		public int OriginalCount;

		public int BytesRead;

		private AsyncCallback realcb;

		public WaitHandle AsyncWaitHandle => (WaitHandle)/*Error near IL_0001: Stack underflow*/;

		public FileStreamAsyncResult(AsyncCallback cb, object state)
		{
		}

		private static void CBWrapper(IAsyncResult ares)
		{
		}
	}
}
