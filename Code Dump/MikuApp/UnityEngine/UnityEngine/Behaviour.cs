using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class Behaviour : Component
	{
		public bool enabled
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}
	}
}
