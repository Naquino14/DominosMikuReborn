using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an arithmetic, casting, or conversion operation in a checked context results in an overflow.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class OverflowException : ArithmeticException
	{
		private const int Result = -2146233066;

		/// <summary>Initializes a new instance of the <see cref="T:System.OverflowException" /> class.</summary>
		public OverflowException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OverflowException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		public OverflowException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.OverflowException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		protected OverflowException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
