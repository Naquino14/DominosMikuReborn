using System.Runtime.CompilerServices;

namespace System.Reflection
{
	internal struct MonoMethodInfo
	{
		private Type parent;

		private Type ret;

		internal MethodAttributes attrs;

		internal MethodImplAttributes iattrs;

		private CallingConventions callconv;

		[MethodImpl(4096)]
		private static extern void get_method_info(IntPtr handle, out MonoMethodInfo info);

		internal static MonoMethodInfo GetMethodInfo(IntPtr handle)
		{
			return (MonoMethodInfo)/*Error near IL_0001: Stack underflow*/;
		}

		internal static Type GetDeclaringType(IntPtr handle)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		internal static Type GetReturnType(IntPtr handle)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		internal static MethodAttributes GetAttributes(IntPtr handle)
		{
			return (MethodAttributes)/*Error near IL_0001: Stack underflow*/;
		}

		internal static CallingConventions GetCallingConvention(IntPtr handle)
		{
			return (CallingConventions)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member);

		internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member)
		{
			return (ParameterInfo[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
