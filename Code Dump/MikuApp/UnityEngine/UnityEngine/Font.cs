using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class Font : Object
	{
		public delegate void FontTextureRebuildCallback();

		public Material material
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public string[] fontNames
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public CharacterInfo[] characterInfo
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public FontTextureRebuildCallback textureRebuildCallback
		{
			get
			{
				return (FontTextureRebuildCallback)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		private event FontTextureRebuildCallback m_FontTextureRebuildCallback
		{
			[MethodImpl(32)]
			add
			{
			}
			[MethodImpl(32)]
			remove
			{
			}
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool HasCharacter(char c);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void RequestCharactersInTexture(string characters, int size, FontStyle style);

		public void RequestCharactersInTexture(string characters, int size)
		{
		}

		public void RequestCharactersInTexture(string characters)
		{
		}

		private void InvokeFontTextureRebuildCallback_Internal()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool GetCharacterInfo(char ch, out CharacterInfo info, int size, FontStyle style);

		public bool GetCharacterInfo(char ch, out CharacterInfo info, int size)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool GetCharacterInfo(char ch, out CharacterInfo info)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
