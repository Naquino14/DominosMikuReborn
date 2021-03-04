using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System.Threading
{
	/// <summary>Provides atomic operations for variables that are shared by multiple threads. </summary>
	/// <filterpriority>2</filterpriority>
	public static class Interlocked
	{
		/// <summary>Compares two 32-bit signed integers for equality and, if they are equal, replaces one of the values.</summary>
		/// <returns>The original value in <paramref name="location1" />.</returns>
		/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced. </param>
		/// <param name="value">The value that replaces the destination value if the comparison results in equality. </param>
		/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />. </param>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int CompareExchange(ref int location1, int value, int comparand);

		/// <summary>Increments a specified variable and stores the result, as an atomic operation.</summary>
		/// <returns>The incremented value.</returns>
		/// <param name="location">The variable whose value is to be incremented. </param>
		/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location" /> is a null pointer. </exception>
		/// <filterpriority>1</filterpriority>
		[MethodImpl(4096)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public static extern int Increment(ref int location);
	}
}
