using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Reflection
{
	[Serializable]
	internal class MonoMethod : MethodInfo, ISerializable
	{
		internal IntPtr mhandle;

		private string name;

		private Type reftype;

		public override Type ReturnType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override RuntimeMethodHandle MethodHandle => (RuntimeMethodHandle)/*Error near IL_0001: Stack underflow*/;

		public override MethodAttributes Attributes => (MethodAttributes)/*Error near IL_0001: Stack underflow*/;

		public override CallingConventions CallingConvention => (CallingConventions)/*Error near IL_0001: Stack underflow*/;

		public override Type ReflectedType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override Type DeclaringType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override string Name => (string)/*Error near IL_0001: Stack underflow*/;

		internal MonoMethod()
		{
		}

		[MethodImpl(4096)]
		internal static extern string get_name(MethodBase method);

		[MethodImpl(4096)]
		internal static extern MonoMethod get_base_definition(MonoMethod method);

		public override MethodInfo GetBaseDefinition()
		{
			return (MethodInfo)/*Error near IL_0001: Stack underflow*/;
		}

		public override ParameterInfo[] GetParameters()
		{
			return (ParameterInfo[])/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		internal extern object InternalInvoke(object obj, object[] parameters, out Exception exc);

		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
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

		private static bool ShouldPrintFullName(Type type)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
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
