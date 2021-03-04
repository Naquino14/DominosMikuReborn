using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when an attempt to access a class member fails.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class MemberAccessException : SystemException
	{
		private const int Result = -2146233062;

		/// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class.</summary>
		public MemberAccessException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		public MemberAccessException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.MemberAccessException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		protected MemberAccessException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
