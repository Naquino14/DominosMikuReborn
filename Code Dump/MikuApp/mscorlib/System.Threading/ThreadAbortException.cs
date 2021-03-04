using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>The exception that is thrown when a call is made to the <see cref="M:System.Threading.Thread.Abort(System.Object)" /> method. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public sealed class ThreadAbortException : SystemException
	{
		private ThreadAbortException()
		{
		}

		private ThreadAbortException(SerializationInfo info, StreamingContext sc)
		{
		}
	}
}
