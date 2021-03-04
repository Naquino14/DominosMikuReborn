using System.Runtime.ConstrainedExecution;

namespace System.Security
{
	/// <summary>Represents text that should be kept confidential. The text is encrypted for privacy when being used, and deleted from computer memory when no longer needed. This class cannot be inherited.</summary>
	[MonoTODO("work in progress - encryption is missing")]
	public sealed class SecureString : CriticalFinalizerObject, IDisposable
	{
		private const int BlockSize = 16;

		private const int MaxSize = 65536;

		private int length;

		private bool disposed;

		private bool read_only;

		private byte[] data;

		/// <summary>Gets the number of characters in the current secure string.</summary>
		/// <returns>The number of <see cref="T:System.Char" /> objects in this secure string.</returns>
		/// <exception cref="T:System.ObjectDisposedException">This secure string has already been disposed.</exception>
		public int Length => (int)/*Error near IL_0001: Stack underflow*/;

		static SecureString()
		{
		}

		/// <summary>Releases all resources used by the current <see cref="T:System.Security.SecureString" /> object.</summary>
		public void Dispose()
		{
		}

		private void Encrypt()
		{
		}

		private void Decrypt()
		{
		}

		internal byte[] GetBuffer()
		{
			return (byte[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
