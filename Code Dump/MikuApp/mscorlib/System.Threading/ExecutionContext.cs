using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Manages the execution context for the current thread. This class cannot be inherited.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	public sealed class ExecutionContext : ISerializable
	{
		private bool _suppressFlow;

		private bool _capture;

		internal ExecutionContext()
		{
		}

		[MonoTODO]
		internal ExecutionContext(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Sets the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate an instance of the current execution context.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to be populated with serialization information. </param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure representing the destination context of the serialization. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		/// <filterpriority>2</filterpriority>
		[MonoTODO]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
