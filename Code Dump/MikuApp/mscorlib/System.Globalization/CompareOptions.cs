using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Defines the string comparison options to use with <see cref="T:System.Globalization.CompareInfo" />.</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum CompareOptions
	{
		/// <summary>Indicates the default option settings for string comparisons.</summary>
		None = 0x0,
		/// <summary>Indicates that the string comparison must ignore case.</summary>
		IgnoreCase = 0x1,
		/// <summary>Indicates that the string comparison must ignore nonspacing combining characters, such as diacritics. The Unicode Standard defines combining characters as characters that are combined with base characters to produce a new character. Nonspacing combining characters do not occupy a spacing position by themselves when rendered. For more information on nonspacing combining characters, see The Unicode Standard at the Unicode home page.</summary>
		IgnoreNonSpace = 0x2,
		/// <summary>Indicates that the string comparison must ignore symbols, such as white-space characters, punctuation, currency symbols, the percent sign, mathematical symbols, the ampersand, and so on.</summary>
		IgnoreSymbols = 0x4,
		/// <summary>Indicates that the string comparison must ignore the Kana type. Kana type refers to Japanese hiragana and katakana characters, which represent phonetic sounds in the Japanese language. Hiragana is used for native Japanese expressions and words, while katakana is used for words borrowed from other languages, such as "computer" or "Internet". A phonetic sound can be expressed in both hiragana and katakana. If this value is selected, the hiragana character for one sound is considered equal to the katakana character for the same sound.</summary>
		IgnoreKanaType = 0x8,
		/// <summary>Indicates that the string comparison must ignore the character width. For example, Japanese katakana characters can be written as full-width or half-width. If this value is selected, the katakana characters written as full-width are considered equal to the same characters written as half-width.</summary>
		IgnoreWidth = 0x10,
		/// <summary>Indicates that the string comparison must use the string sort algorithm. In a string sort, the hyphen and the apostrophe, as well as other nonalphanumeric symbols, come before alphanumeric characters.</summary>
		StringSort = 0x20000000,
		/// <summary>Indicates that the string comparison must use the Unicode values of each character, leading to a fast comparison but one that is culture-insensitive. A string starting with "U+xxxx" comes before a string starting with "U+yyyy", if xxxx is less than yyyy. This value cannot be combined with other <see cref="T:System.Globalization.CompareOptions" /> values and must be used alone.</summary>
		Ordinal = 0x40000000,
		/// <summary>String comparison must ignore case, then perform an ordinal comparison. This technique is equivalent to converting the string to uppercase using the invariant culture and then performing an ordinal comparison on the result.</summary>
		OrdinalIgnoreCase = 0x10000000
	}
}
