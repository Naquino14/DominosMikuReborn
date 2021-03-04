using System.Globalization;
using System.Runtime.Serialization;

namespace System.Reflection
{
	[Serializable]
	internal class MonoProperty : PropertyInfo, ISerializable
	{
		internal IntPtr klass;

		internal IntPtr prop;

		private MonoPropertyInfo info;

		private PInfo cached;

		private GetterAdapter cached_getter;

		public override PropertyAttributes Attributes => (PropertyAttributes)/*Error near IL_0001: Stack underflow*/;

		public override bool CanRead => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public override bool CanWrite => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public override Type PropertyType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override Type ReflectedType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override Type DeclaringType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override string Name => (string)/*Error near IL_0001: Stack underflow*/;

		private void CachePropertyInfo(PInfo flags)
		{
		}

		public override MethodInfo GetGetMethod(bool nonPublic)
		{
			return (MethodInfo)/*Error near IL_0001: Stack underflow*/;
		}

		public override ParameterInfo[] GetIndexParameters()
		{
			return (ParameterInfo[])/*Error near IL_0001: Stack underflow*/;
		}

		public override MethodInfo GetSetMethod(bool nonPublic)
		{
			return (MethodInfo)/*Error near IL_0001: Stack underflow*/;
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

		public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
