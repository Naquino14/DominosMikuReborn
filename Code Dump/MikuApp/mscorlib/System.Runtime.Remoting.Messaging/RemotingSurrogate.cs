using System.Runtime.Serialization;

namespace System.Runtime.Remoting.Messaging
{
	internal class RemotingSurrogate : ISerializationSurrogate
	{
		public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc)
		{
		}

		public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
