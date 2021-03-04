using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown when binding to a member results in more than one member matching the binding criteria. This class cannot be inherited.</summary>
	[Serializable]
	[ComVisible(true)]
	public sealed class AmbiguousMatchException : SystemException
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AmbiguousMatchException" /> class with an empty message string and the root cause exception set to null.</summary>
		public AmbiguousMatchException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AmbiguousMatchException" /> class with its message string set to the given message and the root cause exception set to null.</summary>
		/// <param name="message">A string indicating the reason this exception was thrown. </param>
		public AmbiguousMatchException(string message)
		{
		}

		internal AmbiguousMatchException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
