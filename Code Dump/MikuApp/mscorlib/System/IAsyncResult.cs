using System.Runtime.InteropServices;
using System.Threading;

namespace System
{
	/// <summary>Represents the status of an asynchronous operation. </summary>
	/// <filterpriority>2</filterpriority>
	[ComVisible(true)]
	public interface IAsyncResult
	{
		/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.</summary>
		/// <returns>A <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.</returns>
		/// <filterpriority>2</filterpriority>
		WaitHandle AsyncWaitHandle
		{
			get;
		}
	}
}
