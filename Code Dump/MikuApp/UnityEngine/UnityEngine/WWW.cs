using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace UnityEngine
{
	public sealed class WWW : IDisposable
	{
		internal IntPtr m_Ptr;

		public Dictionary<string, string> responseHeaders => (Dictionary<string, string>)/*Error near IL_0001: Stack underflow*/;

		private string responseHeadersString
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public string text => (string)/*Error near IL_0001: Stack underflow*/;

		internal static Encoding DefaultEncoding => (Encoding)/*Error near IL_0001: Stack underflow*/;

		public byte[] bytes
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public string error
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Texture2D texture => (Texture2D)/*Error near IL_0001: Stack underflow*/;

		public bool isDone
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public float progress
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public AssetBundle assetBundle
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public WWW(string url)
		{
		}

		public WWW(string url, WWWForm form)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal extern WWW(string url, int version, uint crc);

		private static string[] FlattenedHeadersFrom(Hashtable headers)
		{
			return (string[])/*Error near IL_0001: Stack underflow*/;
		}

		internal static Dictionary<string, string> ParseHTTPHeaderString(string input)
		{
			return (Dictionary<string, string>)/*Error near IL_0001: Stack underflow*/;
		}

		public void Dispose()
		{
		}

		~WWW()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void DestroyWWW(bool cancel);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void InitWWW(string url, byte[] postData, string[] iHeaders);

		public static string EscapeURL(string s)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string EscapeURL(string s, Encoding e)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private Encoding GetTextEncoder()
		{
			return (Encoding)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern Texture2D GetTexture(bool markNonReadable);

		public static WWW LoadFromCacheOrDownload(string url, int version)
		{
			return (WWW)/*Error near IL_0001: Stack underflow*/;
		}

		public static WWW LoadFromCacheOrDownload(string url, int version, uint crc)
		{
			return (WWW)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
