using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System
{
	/// <summary>Controls the system garbage collector, a service that automatically reclaims unused memory.</summary>
	/// <filterpriority>2</filterpriority>
	public static class GC
	{
		/// <summary>Gets the maximum number of generations that the system currently supports.</summary>
		/// <returns>A value that ranges from zero to the maximum number of supported generations.</returns>
		/// <filterpriority>1</filterpriority>
		public static int MaxGeneration
		{
			[MethodImpl(4096)]
			get;
		}

		[MethodImpl(4096)]
		private static extern void InternalCollect(int generation);

		/// <summary>Forces an immediate garbage collection of all generations. </summary>
		/// <filterpriority>1</filterpriority>
		public static void Collect()
		{
		}

		/// <summary>Requests that the system not call the finalizer for the specified object.</summary>
		/// <param name="obj">The object that a finalizer must not be called for. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="obj" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern void SuppressFinalize(object obj);
	}
}
