using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>Implements a set of methods for culture-sensitive string comparisons.</summary>
	[Serializable]
	public class CompareInfo : IDeserializationCallback
	{
		private const CompareOptions ValidCompareOptions_NoStringSort = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.Ordinal | CompareOptions.OrdinalIgnoreCase;

		private const CompareOptions ValidCompareOptions = CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreSymbols | CompareOptions.IgnoreKanaType | CompareOptions.IgnoreWidth | CompareOptions.StringSort | CompareOptions.Ordinal | CompareOptions.OrdinalIgnoreCase;

		private static readonly bool useManagedCollation;

		private int culture;

		[NonSerialized]
		private string icu_name;

		private int win32LCID;

		private string m_name;

		private static Hashtable collators;

		[NonSerialized]
		private static object monitor;

		/// <summary>Gets the properly formed culture identifier for the current <see cref="T:System.Globalization.CompareInfo" />.</summary>
		/// <returns>The properly formed culture identifier for the current <see cref="T:System.Globalization.CompareInfo" />.</returns>
		public int LCID => (int)/*Error near IL_0001: Stack underflow*/;

		private CompareInfo()
		{
		}

		internal CompareInfo(CultureInfo ci)
		{
		}

		/// <summary>Runs when the entire object graph has been deserialized.</summary>
		/// <param name="sender">The object that initiated the callback. </param>
		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		[MethodImpl(4096)]
		private extern void construct_compareinfo(string locale);

		[MethodImpl(4096)]
		private extern void free_internal_collator();

		[MethodImpl(4096)]
		private extern void assign_sortkey(object key, string source, CompareOptions options);

		[MethodImpl(4096)]
		private extern int internal_index(string source, int sindex, int count, string value, CompareOptions options, bool first);

		/// <summary>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.</summary>
		~CompareInfo()
		{
		}

		private int string_invariant_compare_char(char c1, char c2, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int internal_compare_micro(string str1, int offset1, int len1, string str2, int offset2, int len2, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two strings. </summary>
		/// <returns>Value Condition zero The two strings are equal. less than zero <paramref name="string1" /> is less than <paramref name="string2" />. greater than zero <paramref name="string1" /> is greater than <paramref name="string2" />. </returns>
		/// <param name="string1">The first string to compare. </param>
		/// <param name="string2">The second string to compare. </param>
		public virtual int Compare(string string1, string string2)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares two strings using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <returns>Value Condition zero The two strings are equal. less than zero <paramref name="string1" /> is less than <paramref name="string2" />. greater than zero <paramref name="string1" /> is greater than <paramref name="string2" />. </returns>
		/// <param name="string1">The first string to compare. </param>
		/// <param name="string2">The second string to compare. </param>
		/// <param name="options">The <see cref="T:System.Globalization.CompareOptions" /> value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		public virtual int Compare(string string1, string string2, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares a section of one string with a section of another string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <returns>Value Condition zero The two strings are equal. less than zero The specified section of <paramref name="string1" /> is less than the specified section of <paramref name="string2" />. greater than zero The specified section of <paramref name="string1" /> is greater than the specified section of <paramref name="string2" />. </returns>
		/// <param name="string1">The first string to compare. </param>
		/// <param name="offset1">The zero-based index of the character in <paramref name="string1" /> at which to start comparing. </param>
		/// <param name="length1">The number of consecutive characters in <paramref name="string1" /> to compare. </param>
		/// <param name="string2">The second string to compare. </param>
		/// <param name="offset2">The zero-based index of the character in <paramref name="string2" /> at which to start comparing. </param>
		/// <param name="length2">The number of consecutive characters in <paramref name="string2" /> to compare. </param>
		/// <param name="options">The <see cref="T:System.Globalization.CompareOptions" /> value that defines how <paramref name="string1" /> and <paramref name="string2" /> should be compared. <paramref name="options" /> is either the value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset1" /> or <paramref name="length1" /> or <paramref name="offset2" /> or <paramref name="length2" /> is less than zero.-or- <paramref name="offset1" /> is greater than or equal to the number of characters in <paramref name="string1" />.-or- <paramref name="offset2" /> is greater than or equal to the number of characters in <paramref name="string2" />.-or- <paramref name="length1" /> is greater than the number of characters from <paramref name="offset1" /> to the end of <paramref name="string1" />.-or- <paramref name="length2" /> is greater than the number of characters from <paramref name="offset2" /> to the end of <paramref name="string2" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" /> object.</summary>
		/// <returns>true if the specified object is equal to the current <see cref="T:System.Globalization.CompareInfo" />; otherwise, false.</returns>
		/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.CompareInfo" />. </param>
		public override bool Equals(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.CompareInfo" /> for hashing algorithms and data structures, such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Globalization.CompareInfo" />.</returns>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Gets a <see cref="T:System.Globalization.SortKey" /> object for the specified string using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <returns>The <see cref="T:System.Globalization.SortKey" /> object that contains the sort key for the specified string.</returns>
		/// <param name="source">The string for which a <see cref="T:System.Globalization.SortKey" /> object is obtained. </param>
		/// <param name="options">The <see cref="T:System.Globalization.CompareOptions" /> value that define how the sort key is calculated. <paramref name="options" /> is a bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />, and <see cref="F:System.Globalization.CompareOptions.StringSort" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public virtual SortKey GetSortKey(string source, CompareOptions options)
		{
			return (SortKey)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements.</summary>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />, if found; otherwise, -1.</returns>
		/// <param name="source">The string to search. </param>
		/// <param name="value">The string to locate within <paramref name="source" />. </param>
		/// <param name="startIndex">The zero-based starting index of the search. </param>
		/// <param name="count">The number of elements in the section to search. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
		public virtual int IndexOf(string source, string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Searches for the specified substring and returns the zero-based index of the first occurrence within the section of the source string that starts at the specified index and contains the specified number of elements using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the section of <paramref name="source" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified by <paramref name="count" />, using the specified <see cref="T:System.Globalization.CompareOptions" /> value, if found; otherwise, -1.</returns>
		/// <param name="source">The string to search. </param>
		/// <param name="value">The string to locate within <paramref name="source" />. </param>
		/// <param name="startIndex">The zero-based starting index of the search. </param>
		/// <param name="count">The number of elements in the section to search. </param>
		/// <param name="options">The <see cref="T:System.Globalization.CompareOptions" /> value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the specified source string starts with the specified prefix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <returns>true if the length of <paramref name="prefix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> starts with <paramref name="prefix" />; otherwise, false.</returns>
		/// <param name="source">The string to search in. </param>
		/// <param name="prefix">The string to compare with the beginning of <paramref name="source" />. </param>
		/// <param name="options">The <see cref="T:System.Globalization.CompareOptions" /> value that defines how <paramref name="source" /> and <paramref name="prefix" /> should be compared. <paramref name="options" /> is either the value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.-or- <paramref name="prefix" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		public virtual bool IsPrefix(string source, string prefix, CompareOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines whether the specified source string ends with the specified suffix using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <returns>true if the length of <paramref name="suffix" /> is less than or equal to the length of <paramref name="source" /> and <paramref name="source" /> ends with <paramref name="suffix" />; otherwise, false.</returns>
		/// <param name="source">The string to search in. </param>
		/// <param name="suffix">The string to compare with the end of <paramref name="source" />. </param>
		/// <param name="options">The <see cref="T:System.Globalization.CompareOptions" /> value that defines how <paramref name="source" /> and <paramref name="suffix" /> should be compared. <paramref name="options" /> is either the value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.-or- <paramref name="suffix" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		public virtual bool IsSuffix(string source, string suffix, CompareOptions options)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index.</summary>
		/// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and ends at <paramref name="startIndex" />, if found; otherwise, -1.</returns>
		/// <param name="source">The string to search. </param>
		/// <param name="value">The string to locate within <paramref name="source" />. </param>
		/// <param name="startIndex">The zero-based starting index of the backward search. </param>
		/// <param name="count">The number of elements in the section to search. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
		public virtual int LastIndexOf(string source, string value, int startIndex, int count)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Searches for the specified substring and returns the zero-based index of the last occurrence within the section of the source string that contains the specified number of elements and ends at the specified index using the specified <see cref="T:System.Globalization.CompareOptions" /> value.</summary>
		/// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the section of <paramref name="source" /> that contains the number of elements specified by <paramref name="count" /> and ends at <paramref name="startIndex" /> using the specified <see cref="T:System.Globalization.CompareOptions" /> value, if found; otherwise, -1.</returns>
		/// <param name="source">The string to search. </param>
		/// <param name="value">The string to locate within <paramref name="source" />. </param>
		/// <param name="startIndex">The zero-based starting index of the backward search. </param>
		/// <param name="count">The number of elements in the section to search. </param>
		/// <param name="options">The <see cref="T:System.Globalization.CompareOptions" /> value that defines how <paramref name="source" /> and <paramref name="value" /> should be compared. <paramref name="options" /> is either the value <see cref="F:System.Globalization.CompareOptions.Ordinal" /> used by itself, or the bitwise combination of one or more of the following values: <see cref="F:System.Globalization.CompareOptions.IgnoreCase" />, <see cref="F:System.Globalization.CompareOptions.IgnoreSymbols" />, <see cref="F:System.Globalization.CompareOptions.IgnoreNonSpace" />, <see cref="F:System.Globalization.CompareOptions.IgnoreWidth" />, and <see cref="F:System.Globalization.CompareOptions.IgnoreKanaType" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="source" /> is null.-or- <paramref name="value" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="source" />.-or- <paramref name="count" /> is less than zero.-or- <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="source" />. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="options" /> contains an invalid <see cref="T:System.Globalization.CompareOptions" /> value. </exception>
		public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Globalization.CompareInfo" />.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Globalization.CompareInfo" />.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
