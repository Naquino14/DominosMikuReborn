using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The exception thrown when an invalid COM object is used.</summary>
	[Serializable]
	[ComVisible(true)]
	public class InvalidComObjectException : SystemException
	{
		private const int ErrorCode = -2146233049;

		/// <summary>Initializes an instance of the InvalidComObjectException with default properties.</summary>
		public InvalidComObjectException()
		{
		}

		/// <summary>Initializes an instance of the InvalidComObjectException with a message.</summary>
		/// <param name="message">The message that indicates the reason for the exception. </param>
		public InvalidComObjectException(string message)
		{
		}

		/// <summary>Initializes a new instance of the COMException class from serialization data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		protected InvalidComObjectException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
