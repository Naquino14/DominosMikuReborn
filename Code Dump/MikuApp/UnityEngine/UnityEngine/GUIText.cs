using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class GUIText : GUIElement
	{
		public string text
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public Material material
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}
	}
}
