using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class TextAsset : Object
	{
		public string text
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public byte[] bytes
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
