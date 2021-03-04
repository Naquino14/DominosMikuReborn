using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Light : Behaviour
	{
		public Color color
		{
			get
			{
				return (Color)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_get_color(out Color value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void INTERNAL_set_color(ref Color value);
	}
}
