using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Manipulates arrays of primitive types.</summary>
	/// <filterpriority>2</filterpriority>
	[ComVisible(true)]
	public static class Buffer
	{
		/// <summary>Returns the number of bytes in the specified array.</summary>
		/// <returns>The number of bytes in the array.</returns>
		/// <param name="array">An array. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is not a primitive. </exception>
		/// <filterpriority>1</filterpriority>
		public static int ByteLength(Array array)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies a specified number of bytes from a source array starting at a particular offset to a destination array starting at a particular offset.</summary>
		/// <param name="src">The source buffer. </param>
		/// <param name="srcOffset">The zero-based byte offset into <paramref name="src" />. </param>
		/// <param name="dst">The destination buffer. </param>
		/// <param name="dstOffset">The zero-based byte offset into <paramref name="dst" />. </param>
		/// <param name="count">The number of bytes to copy. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="src" /> or <paramref name="dst" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="src" /> or <paramref name="dst" /> is not an array of primitives.-or- The length of <paramref name="src" /> is less than <paramref name="srcOffset" /> plus <paramref name="count" />.-or- The length of <paramref name="dst" /> is less than <paramref name="dstOffset" /> plus <paramref name="count" />. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="srcOffset" />, <paramref name="dstOffset" />, or <paramref name="count" /> is less than 0. </exception>
		/// <filterpriority>1</filterpriority>
		public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
		{
		}

		[MethodImpl(4096)]
		private static extern int ByteLengthInternal(Array array);

		[MethodImpl(4096)]
		internal static extern bool BlockCopyInternal(Array src, int src_offset, Array dest, int dest_offset, int count);
	}
}
