using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	internal class MonoCustomAttrs
	{
		private class AttributeInfo
		{
			private AttributeUsageAttribute _usage;

			private int _inheritanceLevel;

			public AttributeUsageAttribute Usage => (AttributeUsageAttribute)/*Error near IL_0001: Stack underflow*/;

			public int InheritanceLevel => (int)/*Error near IL_0001: Stack underflow*/;

			public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel)
			{
			}
		}

		private static Assembly corlib;

		private static readonly Type AttributeUsageType;

		private static readonly AttributeUsageAttribute DefaultAttributeUsage;

		private static bool IsUserCattrProvider(object obj)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		internal static extern object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs);

		internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		internal static Attribute GetCustomAttribute(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			return (Attribute)/*Error near IL_0001: Stack underflow*/;
		}

		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		internal static extern bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType);

		private static PropertyInfo GetBasePropertyDefinition(PropertyInfo property)
		{
			return (PropertyInfo)/*Error near IL_0001: Stack underflow*/;
		}

		private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj)
		{
			return (ICustomAttributeProvider)/*Error near IL_0001: Stack underflow*/;
		}

		private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType)
		{
			return (AttributeUsageAttribute)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
