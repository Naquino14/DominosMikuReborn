using System.Runtime.CompilerServices;

namespace System.Threading
{
	/// <summary>A synchronization primitive that can also be used for interprocess synchronization. </summary>
	/// <filterpriority>1</filterpriority>
	public sealed class Mutex : WaitHandle
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Mutex" /> class with a Boolean value that indicates whether the calling thread should have initial ownership of the mutex.</summary>
		/// <param name="initiallyOwned">true to give the calling thread initial ownership of the mutex; otherwise, false. </param>
		public Mutex(bool initiallyOwned)
		{
		}

		[MethodImpl(4096)]
		private static extern IntPtr CreateMutex_internal(bool initiallyOwned, string name, out bool created);

		[MethodImpl(4096)]
		private static extern bool ReleaseMutex_internal(IntPtr handle);

		/// <summary>Releases the <see cref="T:System.Threading.Mutex" /> once.</summary>
		/// <exception cref="T:System.ApplicationException">The calling thread does not own the mutex. </exception>
		/// <filterpriority>1</filterpriority>
		public void ReleaseMutex()
		{
		}
	}
}
