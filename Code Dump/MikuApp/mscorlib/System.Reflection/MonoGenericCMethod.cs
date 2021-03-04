using System.Runtime.CompilerServices;

namespace System.Reflection
{
	[Serializable]
	internal class MonoGenericCMethod : MonoCMethod
	{
		public override Type ReflectedType
		{
			[MethodImpl(4096)]
			get;
		}

		internal MonoGenericCMethod()
		{
		}
	}
}
