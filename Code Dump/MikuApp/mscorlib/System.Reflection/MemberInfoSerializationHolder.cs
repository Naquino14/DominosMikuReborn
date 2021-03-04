using System.Runtime.Serialization;

namespace System.Reflection
{
	[Serializable]
	internal class MemberInfoSerializationHolder : IObjectReference, ISerializable
	{
		private const BindingFlags DefaultBinding = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		private readonly string _memberName;

		private readonly string _memberSignature;

		private readonly MemberTypes _memberType;

		private readonly Type _reflectedType;

		private readonly Type[] _genericArguments;

		private MemberInfoSerializationHolder(SerializationInfo info, StreamingContext ctx)
		{
		}

		public static void Serialize(SerializationInfo info, string name, Type klass, string signature, MemberTypes type)
		{
		}

		public static void Serialize(SerializationInfo info, string name, Type klass, string signature, MemberTypes type, Type[] genericArguments)
		{
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public object GetRealObject(StreamingContext context)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
