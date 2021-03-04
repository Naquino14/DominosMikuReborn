namespace Mono.Security
{
	internal class Uri
	{
		private struct UriScheme
		{
			public string scheme;

			public string delimiter;

			public int defaultPort;

			public UriScheme(string s, string d, int p)
			{
			}
		}

		private bool isUnixFilePath;

		private string source;

		private string scheme;

		private string host;

		private int port;

		private string path;

		private string query;

		private string fragment;

		private string userinfo;

		private bool isUnc;

		private bool isOpaquePart;

		private string[] segments;

		private bool userEscaped;

		private string cachedAbsoluteUri;

		private string cachedToString;

		private string cachedLocalPath;

		private int cachedHashCode;

		private bool reduce;

		private static readonly string hexUpperChars;

		public static readonly string SchemeDelimiter;

		public static readonly string UriSchemeFile;

		public static readonly string UriSchemeFtp;

		public static readonly string UriSchemeGopher;

		public static readonly string UriSchemeHttp;

		public static readonly string UriSchemeHttps;

		public static readonly string UriSchemeMailto;

		public static readonly string UriSchemeNews;

		public static readonly string UriSchemeNntp;

		private static UriScheme[] schemes;

		public string AbsolutePath => (string)/*Error near IL_0001: Stack underflow*/;

		public bool IsFile => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsUnc => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public string LocalPath => (string)/*Error near IL_0001: Stack underflow*/;

		public Uri(string uriString)
		{
		}

		public Uri(string uriString, bool dontEscape)
		{
		}

		public override bool Equals(object comparant)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public string GetLeftPart(UriPartial part)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static int FromHex(char digit)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static string HexEscape(char character)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static char HexUnescape(string pattern, ref int index)
		{
			return (char)/*Error near IL_0001: Stack underflow*/;
		}

		public static bool IsHexDigit(char digit)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool IsHexEncoding(string pattern, int index)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		protected static string EscapeString(string str)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		protected void Parse()
		{
		}

		protected string Unescape(string str)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal string Unescape(string str, bool excludeSharp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private void ParseAsWindowsUNC(string uriString)
		{
		}

		private void ParseAsWindowsAbsoluteFilePath(string uriString)
		{
		}

		private void ParseAsUnixAbsoluteFilePath(string uriString)
		{
		}

		private void Parse(string uriString)
		{
		}

		private static string Reduce(string path)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string GetSchemeDelimiter(string scheme)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static int GetDefaultPort(string scheme)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private string GetOpaqueWiseSchemeDelimiter()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool IsPredefinedScheme(string scheme)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
