using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>The base exception type for all COM interop exceptions and structured exception handling (SEH) exceptions.</summary>
	[Serializable]
	[ComVisible(true)]
	public class ExternalException : SystemException
	{
		/// <summary>Initializes a new instance of the ExternalException class with default properties.</summary>
		public ExternalException()
		{
		}

		/// <summary>Initializes a new instance of the ExternalException class with a specified error message.</summary>
		/// <param name="message">The error message that specifies the reason for the exception. </param>
		public ExternalException(string message)
		{
		}

		/// <summary>Initializes a new instance of the ExternalException class from serialization data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		protected ExternalException(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Initializes a new instance of the ExternalException class with a specified error message and the HRESULT of the error.</summary>
		/// <param name="message">The error message that specifies the reason for the exception. </param>
		/// <param name="errorCode">The HRESULT of the error. </param>
		public ExternalException(string message, int errorCode)
		{
		}
	}
}
