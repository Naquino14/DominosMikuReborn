using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown when the number of parameters for an invocation does not match the number expected. This class cannot be inherited.</summary>
	[Serializable]
	[ComVisible(true)]
	public sealed class TargetParameterCountException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetParameterCountException" /> class with an empty message string and the root cause of the exception.</summary>
		public TargetParameterCountException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetParameterCountException" /> class with its message string set to the given message and the root cause exception.</summary>
		/// <param name="message">A String describing the reason this exception was thrown. </param>
		public TargetParameterCountException(string message)
		{
		}

		internal TargetParameterCountException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
