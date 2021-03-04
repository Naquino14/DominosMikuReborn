using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace System
{
	internal sealed class NumberFormatter
	{
		private class CustomInfo
		{
			public bool UseGroup;

			public int DecimalDigits;

			public int DecimalPointPos;

			public int DecimalTailSharpDigits;

			public int IntegerDigits;

			public int IntegerHeadSharpDigits;

			public int IntegerHeadPos;

			public bool UseExponent;

			public int ExponentDigits;

			public int ExponentTailSharpDigits;

			public bool ExponentNegativeSignOnly;

			public int DividePlaces;

			public int Percents;

			public int Permilles;

			public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length)
			{
			}

			public static CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi)
			{
				return (CustomInfo)/*Error near IL_0001: Stack underflow*/;
			}

			public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp)
			{
				return (string)/*Error near IL_0001: Stack underflow*/;
			}
		}

		private const int DefaultExpPrecision = 6;

		private const int HundredMillion = 100000000;

		private const long SeventeenDigitsThreshold = 10000000000000000L;

		private const ulong ULongDivHundredMillion = 184467440737uL;

		private const ulong ULongModHundredMillion = 9551616uL;

		private const int DoubleBitsExponentShift = 52;

		private const int DoubleBitsExponentMask = 2047;

		private const long DoubleBitsMantissaMask = 4503599627370495L;

		private const int DecimalBitsScaleMask = 2031616;

		private const int SingleDefPrecision = 7;

		private const int DoubleDefPrecision = 15;

		private const int Int8DefPrecision = 3;

		private const int UInt8DefPrecision = 3;

		private const int Int16DefPrecision = 5;

		private const int UInt16DefPrecision = 5;

		private const int Int32DefPrecision = 10;

		private const int UInt32DefPrecision = 10;

		private const int Int64DefPrecision = 19;

		private const int UInt64DefPrecision = 20;

		private const int DecimalDefPrecision = 100;

		private const int TenPowersListLength = 19;

		private const double MinRoundtripVal = -1.79769313486231E+308;

		private const double MaxRoundtripVal = 1.79769313486231E+308;

		private unsafe static readonly ulong* MantissaBitsTable;

		private unsafe static readonly int* TensExponentTable;

		private unsafe static readonly char* DigitLowerTable;

		private unsafe static readonly char* DigitUpperTable;

		private unsafe static readonly long* TenPowersList;

		private unsafe static readonly int* DecHexDigits;

		private Thread _thread;

		private NumberFormatInfo _nfi;

		private bool _NaN;

		private bool _infinity;

		private bool _isCustomFormat;

		private bool _specifierIsUpper;

		private bool _positive;

		private char _specifier;

		private int _precision;

		private int _defPrecision;

		private int _digitsLen;

		private int _offset;

		private int _decPointPos;

		private uint _val1;

		private uint _val2;

		private uint _val3;

		private uint _val4;

		private char[] _cbuf;

		private int _ind;

		[ThreadStatic]
		private static NumberFormatter threadNumberFormatter;

		public CultureInfo CurrentCulture
		{
			set
			{
			}
		}

		private int IntegerDigits => (int)/*Error near IL_0001: Stack underflow*/;

		private int DecimalDigits => (int)/*Error near IL_0001: Stack underflow*/;

		private bool IsFloatingSource => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		private bool IsZero => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		private bool IsZeroInteger => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public NumberFormatter(Thread current)
		{
		}

		static NumberFormatter()
		{
		}

		[MethodImpl(4096)]
		private unsafe static extern void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits);

		private static long GetTenPowerOf(int i)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		private void InitDecHexDigits(uint value)
		{
		}

		private void InitDecHexDigits(ulong value)
		{
		}

		private void InitDecHexDigits(uint hi, ulong lo)
		{
		}

		private static uint FastToDecHex(int val)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		private static uint ToDecHex(int val)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		private static int FastDecHexLen(int val)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int DecHexLen(uint val)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int DecHexLen()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int ScaleOrder(long hi)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int InitialFloatingPrecision()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int ParsePrecision(string format)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private void Init(string format)
		{
		}

		private void InitHex(ulong value)
		{
		}

		private void Init(string format, int value, int defPrecision)
		{
		}

		private void Init(string format, uint value, int defPrecision)
		{
		}

		private void Init(string format, long value)
		{
		}

		private void Init(string format, ulong value)
		{
		}

		private void Init(string format, double value, int defPrecision)
		{
		}

		private void Init(string format, decimal value)
		{
		}

		private void ResetCharBuf(int size)
		{
		}

		private void Resize(int len)
		{
		}

		private void Append(char c)
		{
		}

		private void Append(char c, int cnt)
		{
		}

		private void Append(string s)
		{
		}

		private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp)
		{
			return (NumberFormatInfo)/*Error near IL_0001: Stack underflow*/;
		}

		private void RoundPos(int pos)
		{
		}

		private bool RoundDecimal(int decimals)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool RoundBits(int shift)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private void RemoveTrailingZeros()
		{
		}

		private void AddOneToDecHex()
		{
		}

		private static uint AddOneToDecHex(uint val)
		{
			return (uint)/*Error near IL_0001: Stack underflow*/;
		}

		private int CountTrailingZeros()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static int CountTrailingZeros(uint val)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static NumberFormatter GetInstance()
		{
			return (NumberFormatter)/*Error near IL_0001: Stack underflow*/;
		}

		private void Release()
		{
		}

		internal static void SetThreadCurrentCulture(CultureInfo culture)
		{
		}

		public static string NumberToString(string format, sbyte value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, byte value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, ushort value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, short value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, uint value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, int value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, ulong value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, long value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, float value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, double value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(string format, decimal value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(uint value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(int value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(ulong value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(long value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(float value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static string NumberToString(double value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string FastIntegerToString(int value, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string IntegerToString(string format, IFormatProvider fp)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string NumberToString(string format, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public string FormatCurrency(int precision, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string FormatDecimal(int precision, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string FormatHexadecimal(int precision)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public string FormatFixedPoint(int precision, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string FormatRoundtrip(double origval, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string FormatRoundtrip(float origval, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string FormatGeneral(int precision, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public string FormatNumber(int precision, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public string FormatPercent(int precision, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public string FormatExponential(int precision, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public string FormatCustom(string format, NumberFormatInfo nfi)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty)
		{
		}

		private static bool IsZeroOnly(StringBuilder sb)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static void AppendNonNegativeNumber(StringBuilder sb, int v)
		{
		}

		private void AppendIntegerString(int minLength, StringBuilder sb)
		{
		}

		private void AppendIntegerString(int minLength)
		{
		}

		private void AppendDecimalString(int precision, StringBuilder sb)
		{
		}

		private void AppendDecimalString(int precision)
		{
		}

		private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator)
		{
		}

		private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits)
		{
		}

		private void AppendOneDigit(int start)
		{
		}

		private void FastAppendDigits(int val, bool force)
		{
		}

		private void AppendDigits(int start, int end)
		{
		}

		private void AppendDigits(int start, int end, StringBuilder sb)
		{
		}

		private void Multiply10(int count)
		{
		}

		private void Divide10(int count)
		{
		}

		private NumberFormatter GetClone()
		{
			return (NumberFormatter)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
