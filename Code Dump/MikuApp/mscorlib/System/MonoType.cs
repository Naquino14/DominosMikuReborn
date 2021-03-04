using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	internal class MonoType : Type, ISerializable
	{
		[NonSerialized]
		private MonoTypeInfo type_info;

		public override Type UnderlyingSystemType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override Assembly Assembly
		{
			[MethodImpl(4096)]
			get;
		}

		public override string AssemblyQualifiedName => (string)/*Error near IL_0001: Stack underflow*/;

		public override Type BaseType
		{
			[MethodImpl(4096)]
			get;
		}

		public override string FullName => (string)/*Error near IL_0001: Stack underflow*/;

		public override Guid GUID => (Guid)/*Error near IL_0001: Stack underflow*/;

		public override MemberTypes MemberType => (MemberTypes)/*Error near IL_0001: Stack underflow*/;

		public override string Name
		{
			[MethodImpl(4096)]
			get;
		}

		public override string Namespace
		{
			[MethodImpl(4096)]
			get;
		}

		public override Module Module
		{
			[MethodImpl(4096)]
			get;
		}

		public override Type DeclaringType
		{
			[MethodImpl(4096)]
			get;
		}

		public override Type ReflectedType => (Type)/*Error near IL_0001: Stack underflow*/;

		public override RuntimeTypeHandle TypeHandle => (RuntimeTypeHandle)/*Error near IL_0001: Stack underflow*/;

		[MethodImpl(4096)]
		private static extern TypeAttributes get_attributes(Type type);

		internal ConstructorInfo GetDefaultConstructor()
		{
			return (ConstructorInfo)/*Error near IL_0001: Stack underflow*/;
		}

		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return (TypeAttributes)/*Error near IL_0001: Stack underflow*/;
		}

		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return (ConstructorInfo)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		internal extern ConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, Type reflected_type);

		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return (ConstructorInfo[])/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private extern EventInfo InternalGetEvent(string name, BindingFlags bindingAttr);

		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return (EventInfo)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		public override extern FieldInfo GetField(string name, BindingFlags bindingAttr);

		[MethodImpl(4096)]
		internal extern FieldInfo[] GetFields_internal(BindingFlags bindingAttr, Type reflected_type);

		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return (FieldInfo[])/*Error near IL_0001: Stack underflow*/;
		}

		public override Type GetInterface(string name, bool ignoreCase)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		public override extern Type[] GetInterfaces();

		[MethodImpl(4096)]
		internal extern MethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, Type reflected_type);

		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return (MethodInfo[])/*Error near IL_0001: Stack underflow*/;
		}

		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
		{
			return (MethodInfo)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		internal extern PropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, Type reflected_type);

		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return (PropertyInfo[])/*Error near IL_0001: Stack underflow*/;
		}

		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
		{
			return (PropertyInfo)/*Error near IL_0001: Stack underflow*/;
		}

		protected override bool HasElementTypeImpl()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected override bool IsArrayImpl()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		protected override extern bool IsByRefImpl();

		[MethodImpl(4096)]
		protected override extern bool IsPointerImpl();

		[MethodImpl(4096)]
		protected override extern bool IsPrimitiveImpl();

		public override bool IsSubclassOf(Type type)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		public override extern Type GetElementType();

		[MethodImpl(4096)]
		private extern string getFullName(bool full_name, bool assembly_qualified);

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
		public override extern int GetArrayRank();

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private MethodBase CheckMethodSecurity(MethodBase mb)
		{
			return (MethodBase)/*Error near IL_0001: Stack underflow*/;
		}

		private void ReorderParamArrayArguments(ref object[] args, MethodBase method)
		{
		}
	}
}
