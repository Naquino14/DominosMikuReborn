using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when the format of an argument does not meet the parameter specifications of the invoked method.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class FormatException : SystemException
	{
		private const int Result = -2146233033;

		/// <summary>Initializes a new instance of the <see cref="T:System.FormatException" /> class.</summary>
		public FormatException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.FormatException" /> class with a specified error message.</summary>
		/// <param name="message">The message that describes the error. </param>
		public FormatException(string message)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.FormatException" /> class with serialized data.</summary>
		/// <param name="info">The object that holds the serialized object data. </param>
		/// <param name="context">The contextual information about the source or destination. </param>
		protected FormatException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
