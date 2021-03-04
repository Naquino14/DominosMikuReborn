using System.Runtime.Serialization;

namespace System.Reflection
{
	[Serializable]
	internal sealed class MonoEvent : EventInfo, ISerializable
	{
		private IntPtr klass;

		private IntPtr handle;

		public override EventAttributes Attributes => (EventAttributes)/*Error near IL_0001: Stack underflow*/;

		public override Type DeclaringType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override Type ReflectedType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override string Name => (string)/*Error near IL_0001: Stack underflow*/;

		public override MethodInfo GetAddMethod(bool nonPublic)
		{
			return (MethodInfo)/*Error near IL_0001: Stack underflow*/;
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
