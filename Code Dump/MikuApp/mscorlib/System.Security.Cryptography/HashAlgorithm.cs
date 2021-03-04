using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Represents the base class from which all implementations of cryptographic hash algorithms must derive.</summary>
	[ComVisible(true)]
	public abstract class HashAlgorithm : IDisposable, ICryptoTransform
	{
		/// <summary>Represents the value of the computed hash code.</summary>
		protected internal byte[] HashValue;

		/// <summary>Represents the size, in bits, of the computed hash code.</summary>
		protected int HashSizeValue;

		/// <summary>Represents the state of the hash computation.</summary>
		protected int State;

		private bool disposed;

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> and optionally releases the managed resources.</summary>
		void IDisposable.Dispose()
		{
		}

		/// <summary>Computes the hash value for the specified byte array.</summary>
		/// <returns>The computed hash code.</returns>
		/// <param name="buffer">The input to compute the hash code for. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
		public byte[] ComputeHash(byte[] buffer)
		{
			return (byte[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Computes the hash value for the specified region of the specified byte array.</summary>
		/// <returns>The computed hash code.</returns>
		/// <param name="buffer">The input to compute the hash code for. </param>
		/// <param name="offset">The offset into the byte array from which to begin using data. </param>
		/// <param name="count">The number of bytes in the array to use as data. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="count" /> is an invalid value.-or-<paramref name="buffer" /> length is invalid.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="buffer" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> is out of range. This parameter requires a non-negative number.</exception>
		/// <exception cref="T:System.ObjectDisposedException">The object has already been disposed.</exception>
		public byte[] ComputeHash(byte[] buffer, int offset, int count)
		{
			return (byte[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>When overridden in a derived class, routes data written to the object into the hash algorithm for computing the hash.</summary>
		/// <param name="array">The input to compute the hash code for. </param>
		/// <param name="ibStart">The offset into the byte array from which to begin using data. </param>
		/// <param name="cbSize">The number of bytes in the byte array to use as data. </param>
		protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

		/// <summary>When overridden in a derived class, finalizes the hash computation after the last data is processed by the cryptographic stream object.</summary>
		/// <returns>The computed hash code.</returns>
		protected abstract byte[] HashFinal();

		/// <summary>Initializes an implementation of the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> class.</summary>
		public abstract void Initialize();

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.HashAlgorithm" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
