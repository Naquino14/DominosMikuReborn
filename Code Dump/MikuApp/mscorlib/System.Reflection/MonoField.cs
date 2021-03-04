using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	[Serializable]
	internal class MonoField : FieldInfo, ISerializable
	{
		internal IntPtr klass;

		internal RuntimeFieldHandle fhandle;

		private string name;

		private Type type;

		private FieldAttributes attrs;

		public override FieldAttributes Attributes => (FieldAttributes)/*Error near IL_0001: Stack underflow*/;

		public override RuntimeFieldHandle FieldHandle => (RuntimeFieldHandle)/*Error near IL_0001: Stack underflow*/;

		public override Type FieldType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override Type ReflectedType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override Type DeclaringType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override string Name => (string)/*Error near IL_0001: Stack underflow*/;

		[MethodImpl(4096)]
		private extern Type GetParentType(bool declaring);

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

		[MethodImpl(4096)]
		private extern object GetValueInternal(object obj);

		public override object GetValue(object obj)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern void SetValueInternal(FieldInfo fi, object obj, object value);

		public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
		}

		internal MonoField Clone(string newName)
		{
			return (MonoField)/*Error near IL_0001: Stack underflow*/;
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private void CheckGeneric()
		{
		}
	}
}
