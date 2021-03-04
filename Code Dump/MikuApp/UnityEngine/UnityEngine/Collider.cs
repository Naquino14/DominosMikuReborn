using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class Collider : Component
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

		public Rigidbody attachedRigidbody
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public bool isTrigger
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Bounds bounds => (Bounds)/*Error near IL_0001: Stack underflow*/;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_bounds(out Bounds value);
	}
}
