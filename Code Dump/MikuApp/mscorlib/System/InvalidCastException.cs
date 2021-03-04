using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown for invalid casting or explicit conversion.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class InvalidCastException : SystemException
	{
		private const int Result = -2147467262;

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidCastException" /> class.</summary>
		public InvalidCastException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidCastException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		public InvalidCastException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.InvalidCastException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		protected InvalidCastException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
