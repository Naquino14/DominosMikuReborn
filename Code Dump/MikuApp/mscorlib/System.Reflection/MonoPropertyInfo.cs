using System.Runtime.CompilerServices;

namespace System.Reflection
{
	internal struct MonoPropertyInfo
	{
		public Type parent;

		public string name;

		public MethodInfo get_method;

		public MethodInfo set_method;

		public PropertyAttributes attrs;

		[MethodImpl(4096)]
		internal static extern void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info);
	}
}
