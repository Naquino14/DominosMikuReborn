using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when there is an invalid attempt to access a private or protected field inside a class.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class FieldAccessException : MemberAccessException
	{
		private const int Result = -2146233081;

		/// <summary>Initializes a new instance of the <see cref="T:System.FieldAccessException" /> class.</summary>
		public FieldAccessException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.FieldAccessException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		public FieldAccessException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.FieldAccessException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		protected FieldAccessException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
