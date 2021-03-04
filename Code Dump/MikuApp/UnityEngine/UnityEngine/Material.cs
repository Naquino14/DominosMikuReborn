using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public class Material : Object
	{
		public Shader shader
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

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

		public Texture mainTexture
		{
			get
			{
				return (Texture)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector2 mainTextureOffset
		{
			get
			{
				return (Vector2)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Vector2 mainTextureScale
		{
			set
			{
			}
		}

		public Material(Shader shader)
		{
		}

		public Material(Material source)
		{
		}

		public void SetColor(string propertyName, Color color)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_SetColor(Material self, string propertyName, ref Color color);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern Color GetColor(string propertyName);

		public void SetVector(string propertyName, Vector4 vector)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SetTexture(string propertyName, Texture texture);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern Texture GetTexture(string propertyName);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_GetTextureOffset(Material mat, string name, out Vector2 output);

		public void SetTextureOffset(string propertyName, Vector2 offset)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_SetTextureOffset(Material self, string propertyName, ref Vector2 offset);

		public Vector2 GetTextureOffset(string propertyName)
		{
			return (Vector2)/*Error near IL_0001: Stack underflow*/;
		}

		public void SetTextureScale(string propertyName, Vector2 scale)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void INTERNAL_CALL_SetTextureScale(Material self, string propertyName, ref Vector2 scale);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern bool SetPass(int pass);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_CreateWithShader([Writable] Material mono, Shader shader);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_CreateWithMaterial([Writable] Material mono, Material source);
	}
}
