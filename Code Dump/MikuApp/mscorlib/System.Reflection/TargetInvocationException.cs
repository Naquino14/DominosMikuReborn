using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>The exception that is thrown by methods invoked through reflection. This class cannot be inherited.</summary>
	[Serializable]
	[ComVisible(true)]
	public sealed class TargetInvocationException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.TargetInvocationException" /> class with a reference to the inner exception that is the cause of this exception.</summary>
		/// <param name="inner">The exception that is the cause of the current exception. If the <paramref name="inner" /> parameter is not null, the current exception is raised in a catch block that handles the inner exception. </param>
		public TargetInvocationException(Exception inner)
		{
		}

		internal TargetInvocationException(SerializationInfo info, StreamingContext sc)
		{
		}
	}
}
