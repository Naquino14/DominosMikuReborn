using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class BoxCollider : Collider
	{
		public Vector3 center
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 size
		{
			get
			{
				return (Vector3)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector3 extents => (Vector3)/*Error near IL_0001: Stack underflow*/;

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_center(out Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_center(ref Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_size(out Vector3 value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_size(ref Vector3 value);
	}
}
