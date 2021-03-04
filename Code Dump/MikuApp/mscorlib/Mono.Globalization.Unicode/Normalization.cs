using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mono.Globalization.Unicode
{
	internal class Normalization
	{
		public const int NoNfd = 1;

		public const int NoNfkd = 2;

		public const int NoNfc = 4;

		public const int MaybeNfc = 8;

		public const int NoNfkc = 16;

		public const int MaybeNfkc = 32;

		public const int FullCompositionExclusion = 64;

		public const int IsUnsafe = 128;

		private const int HangulSBase = 44032;

		private const int HangulLBase = 4352;

		private const int HangulVBase = 4449;

		private const int HangulTBase = 4519;

		private const int HangulLCount = 19;

		private const int HangulVCount = 21;

		private const int HangulTCount = 28;

		private const int HangulNCount = 588;

		private const int HangulSCount = 11172;

		private unsafe static byte* props;

		private unsafe static int* mappedChars;

		private unsafe static short* charMapIndex;

		private unsafe static short* helperIndex;

		private unsafe static ushort* mapIdxToComposite;

		private unsafe static byte* combiningClass;

		private static object forLock;

		public static readonly bool isReady;

		static Normalization()
		{
		}

		private static uint PropValue(int cp)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		private static int CharMapIdx(int cp)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int GetNormalizedStringLength(int ch)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static byte GetCombiningClass(int c)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		private static int GetPrimaryCompositeFromMapIndex(int src)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int GetPrimaryCompositeHelperIndex(int cp)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int GetPrimaryCompositeCharIndex(object chars, int start)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static string Compose(string source, int checkType)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static StringBuilder Combine(string source, int start, int checkType)
		{
			return (StringBuilder)/*Error near IL_0001: Stack underflow*/;
		}

		private static void Combine(StringBuilder sb, int start, int checkType)
		{
		}

		private static int GetPrimaryCompositeMapIndex(object o, int cur, int bufferPos)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static string Decompose(string source, int checkType)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static void Decompose(string source, ref StringBuilder sb, int checkType)
		{
		}

		private static void ReorderCanonical(string src, ref StringBuilder sb, int start)
		{
		}

		private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, ref int start)
		{
		}

		public static NormalizationCheck QuickCheck(char c, int type)
		{
			return (NormalizationCheck)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool GetCanonicalHangul(int s, int[] buf, int bufIdx)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static void GetCanonical(int c, int[] buf, int bufIdx)
		{
		}

		public static bool IsNormalized(string source, int type)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static string Normalize(string source, int type)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		private static extern void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass);
	}
}
