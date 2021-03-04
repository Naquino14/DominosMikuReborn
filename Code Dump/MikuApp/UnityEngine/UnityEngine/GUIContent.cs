using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIContent
	{
		[SerializeField]
		private string m_Text;

		[SerializeField]
		private Texture m_Image;

		[SerializeField]
		private string m_Tooltip;

		public static GUIContent none;

		private static GUIContent s_Text;

		private static GUIContent s_Image;

		private static GUIContent s_TextImage;

		public string text
		{
			get
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Texture image => (Texture)/*Error near IL_0001: Stack underflow*/;

		internal int hash => (int)/*Error near IL_0001: Stack underflow*/;

		public GUIContent()
		{
		}

		public GUIContent(string text)
		{
		}

		public GUIContent(Texture image)
		{
		}

		public GUIContent(GUIContent src)
		{
		}

		internal static GUIContent Temp(string t)
		{
			return (GUIContent)/*Error near IL_0001: Stack underflow*/;
		}

		internal static GUIContent Temp(Texture i)
		{
			return (GUIContent)/*Error near IL_0001: Stack underflow*/;
		}

		internal static GUIContent Temp(string t, Texture i)
		{
			return (GUIContent)/*Error near IL_0001: Stack underflow*/;
		}

		internal static GUIContent[] Temp(string[] texts)
		{
			return (GUIContent[])/*Error near IL_0001: Stack underflow*/;
		}

		internal static GUIContent[] Temp(Texture[] images)
		{
			return (GUIContent[])/*Error near IL_0001: Stack underflow*/;
		}
	}
}
