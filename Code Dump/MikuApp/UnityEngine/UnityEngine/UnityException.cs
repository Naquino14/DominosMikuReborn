using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	[Serializable]
	public class UnityException : SystemException
	{
		private const int Result = -2147467261;

		private string unityStackTrace;

		public UnityException()
		{
		}

		public UnityException(string message)
		{
		}

		public UnityException(string message, Exception innerException)
		{
		}

		protected UnityException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
