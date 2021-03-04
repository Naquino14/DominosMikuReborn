using System.Runtime.CompilerServices;

namespace System.Reflection
{
	[Serializable]
	internal class MonoGenericMethod : MonoMethod
	{
		public override Type ReflectedType
		{
			[MethodImpl(4096)]
			get;
		}

		internal MonoGenericMethod()
		{
		}
	}
}
