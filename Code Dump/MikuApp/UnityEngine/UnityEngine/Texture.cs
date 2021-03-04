using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class Texture : Object
	{
		public virtual int width
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public virtual int height
		{
			get
			{
				return (int)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public FilterMode filterMode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public TextureWrapMode wrapMode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int Internal_GetWidth(Texture mono);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int Internal_GetHeight(Texture mono);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern int GetNativeTextureID();
	}
}
