using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Provides information about a specific culture (called a "locale" for unmanaged code development). The information includes the names for the culture, the writing system, the calendar used, and formatting for dates and sort strings.</summary>
	[Serializable]
	[ComVisible(true)]
	public class CultureInfo : ICloneable, IFormatProvider
	{
		private const int NumOptionalCalendars = 5;

		private const int GregorianTypeMask = 16777215;

		private const int CalendarTypeBits = 24;

		private const int InvariantCultureId = 127;

		private static volatile CultureInfo invariant_culture_info;

		private static object shared_table_lock;

		internal static int BootstrapCultureID;

		private bool m_isReadOnly;

		private int cultureID;

		[NonSerialized]
		private int parent_lcid;

		[NonSerialized]
		private int specific_lcid;

		[NonSerialized]
		private int datetime_index;

		[NonSerialized]
		private int number_index;

		private bool m_useUserOverride;

		[NonSerialized]
		private volatile NumberFormatInfo numInfo;

		private volatile DateTimeFormatInfo dateTimeInfo;

		private volatile TextInfo textInfo;

		private string m_name;

		[NonSerialized]
		private string displayname;

		[NonSerialized]
		private string englishname;

		[NonSerialized]
		private string nativename;

		[NonSerialized]
		private string iso3lang;

		[NonSerialized]
		private string iso2lang;

		[NonSerialized]
		private string icu_name;

		[NonSerialized]
		private string win3lang;

		[NonSerialized]
		private string territory;

		private volatile CompareInfo compareInfo;

		[NonSerialized]
		private unsafe readonly int* calendar_data;

		[NonSerialized]
		private unsafe readonly void* textinfo_data;

		[NonSerialized]
		private Calendar[] optional_calendars;

		[NonSerialized]
		private CultureInfo parent_culture;

		private int m_dataItem;

		private Calendar calendar;

		[NonSerialized]
		private bool constructed;

		[NonSerialized]
		internal byte[] cached_serialized_form;

		private static readonly string MSG_READONLY;

		private static Hashtable shared_by_number;

		private static Hashtable shared_by_name;

		/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that is culture-independent (invariant).</summary>
		/// <returns>The <see cref="T:System.Globalization.CultureInfo" /> that is culture-independent (invariant).</returns>
		public static CultureInfo InvariantCulture => (CultureInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that represents the culture used by the current thread.</summary>
		/// <returns>The <see cref="T:System.Globalization.CultureInfo" /> that represents the culture used by the current thread.</returns>
		public static CultureInfo CurrentCulture => (CultureInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that represents the current culture used by the Resource Manager to look up culture-specific resources at run time.</summary>
		/// <returns>The <see cref="T:System.Globalization.CultureInfo" /> that represents the current culture used by the Resource Manager to look up culture-specific resources at run time.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static CultureInfo CurrentUICulture => (CultureInfo)/*Error near IL_0001: Stack underflow*/;

		internal string Territory => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the culture identifier for the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>The culture identifier for the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		public virtual int LCID => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the culture name in the format "&lt;languagecode2&gt;-&lt;country/regioncode2&gt;".</summary>
		/// <returns>The culture name in the format "&lt;languagecode2&gt;-&lt;country/regioncode2&gt;", where &lt;languagecode2&gt; is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166.</returns>
		public virtual string Name => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the culture name, consisting of the language, the country/region, and the optional script, that the culture is set to display.</summary>
		/// <returns>The culture name. consisting of the full name of the language, the full name of the country/region, and the optional script. The format is discussed in the description of the <see cref="T:System.Globalization.CultureInfo" /> class.</returns>
		public virtual string NativeName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the default calendar used by the culture.</summary>
		/// <returns>A <see cref="T:System.Globalization.Calendar" /> that represents the default calendar used by the culture.</returns>
		public virtual Calendar Calendar => (Calendar)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the list of calendars that can be used by the culture.</summary>
		/// <returns>An array of type <see cref="T:System.Globalization.Calendar" /> that represents the calendars that can be used by the culture represented by the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		public virtual Calendar[] OptionalCalendars => (Calendar[])/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that represents the parent culture of the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>The <see cref="T:System.Globalization.CultureInfo" /> that represents the parent culture of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public virtual CultureInfo Parent => (CultureInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Globalization.TextInfo" /> that defines the writing system associated with the culture.</summary>
		/// <returns>The <see cref="T:System.Globalization.TextInfo" /> that defines the writing system associated with the culture.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public virtual TextInfo TextInfo => (TextInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the ISO 639-2 three-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>The ISO 639-2 three-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		public virtual string ThreeLetterISOLanguageName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the three-letter code for the language as defined in the Windows API.</summary>
		/// <returns>The three-letter code for the language as defined in the Windows API.</returns>
		public virtual string ThreeLetterWindowsLanguageName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the ISO 639-1 two-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>The ISO 639-1 two-letter code for the language of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		public virtual string TwoLetterISOLanguageName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.CultureInfo" /> uses the user-selected culture settings.</summary>
		/// <returns>true if the current <see cref="T:System.Globalization.CultureInfo" /> uses the user-selected culture settings; otherwise, false.</returns>
		public bool UseUserOverride => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		internal string IcuName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Globalization.CompareInfo" /> that defines how to compare strings for the culture.</summary>
		/// <returns>The <see cref="T:System.Globalization.CompareInfo" /> that defines how to compare strings for the culture.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public virtual CompareInfo CompareInfo => (CompareInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.CultureInfo" /> represents a neutral culture.</summary>
		/// <returns>true if the current <see cref="T:System.Globalization.CultureInfo" /> represents a neutral culture; otherwise, false.</returns>
		public virtual bool IsNeutralCulture => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets or sets a <see cref="T:System.Globalization.NumberFormatInfo" /> that defines the culturally appropriate format of displaying numbers, currency, and percentage.</summary>
		/// <returns>A <see cref="T:System.Globalization.NumberFormatInfo" /> that defines the culturally appropriate format of displaying numbers, currency, and percentage.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is set to null. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Globalization.CultureInfo" /> is for a neutral culture. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Globalization.CultureInfo.NumberFormat" /> property or any of the <see cref="T:System.Globalization.NumberFormatInfo" /> properties is set, and the <see cref="T:System.Globalization.CultureInfo" /> is read-only. </exception>
		public virtual NumberFormatInfo NumberFormat
		{
			get
			{
				return (NumberFormatInfo)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a <see cref="T:System.Globalization.DateTimeFormatInfo" /> that defines the culturally appropriate format of displaying dates and times.</summary>
		/// <returns>A <see cref="T:System.Globalization.DateTimeFormatInfo" /> that defines the culturally appropriate format of displaying dates and times.</returns>
		/// <exception cref="T:System.ArgumentNullException">The property is set to null. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Globalization.CultureInfo" /> is for a neutral culture. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Globalization.CultureInfo.DateTimeFormat" /> property or any of the <see cref="T:System.Globalization.DateTimeFormatInfo" /> properties is set, and the <see cref="T:System.Globalization.CultureInfo" /> is read-only. </exception>
		public virtual DateTimeFormatInfo DateTimeFormat
		{
			get
			{
				return (DateTimeFormatInfo)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets the culture name in the format "&lt;languagefull&gt; (&lt;country/regionfull&gt;)" in the language of the localized version of .NET Framework.</summary>
		/// <returns>The culture name in the format "&lt;languagefull&gt; (&lt;country/regionfull&gt;)" in the language of the localized version of .NET Framework, where &lt;languagefull&gt; is the full name of the language and &lt;country/regionfull&gt; is the full name of the country/region.</returns>
		public virtual string DisplayName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the culture name in the format "&lt;languagefull&gt; (&lt;country/regionfull&gt;)" in English.</summary>
		/// <returns>The culture name in the format "&lt;languagefull&gt; (&lt;country/regionfull&gt;)" in English, where &lt;languagefull&gt; is the full name of the language and &lt;country/regionfull&gt; is the full name of the country/region.</returns>
		public virtual string EnglishName => (string)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the <see cref="T:System.Globalization.CultureInfo" /> that represents the culture installed with the operating system.</summary>
		/// <returns>The <see cref="T:System.Globalization.CultureInfo" /> that represents the culture installed with the operating system.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static CultureInfo InstalledUICulture => (CultureInfo)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the current <see cref="T:System.Globalization.CultureInfo" /> is read-only.</summary>
		/// <returns>true if the current <see cref="T:System.Globalization.CultureInfo" /> is read-only; otherwise, false. The default is false.</returns>
		public bool IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by the culture identifier.</summary>
		/// <param name="culture">A predefined <see cref="T:System.Globalization.CultureInfo" /> identifier, <see cref="P:System.Globalization.CultureInfo.LCID" /> property of an existing <see cref="T:System.Globalization.CultureInfo" /> object, or Windows-only culture identifier. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="culture" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="culture" /> is not a valid culture identifier. -or-In .NET Compact Framework applications, <paramref name="culture" /> is not supported by the operating system of the device. </exception>
		public CultureInfo(int culture)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by the culture identifier and on the Boolean that specifies whether to use the user-selected culture settings from the system.</summary>
		/// <param name="culture">A predefined <see cref="T:System.Globalization.CultureInfo" /> identifier, <see cref="P:System.Globalization.CultureInfo.LCID" /> property of an existing <see cref="T:System.Globalization.CultureInfo" /> object, or Windows-only culture identifier. </param>
		/// <param name="useUserOverride">A Boolean that denotes whether to use the user-selected culture settings (true) or the default culture settings (false). </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="culture" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="culture" /> is not a valid culture identifier.-or-In .NET Compact Framework applications, <paramref name="culture" /> is not supported by the operating system of the device.  </exception>
		public CultureInfo(int culture, bool useUserOverride)
		{
		}

		private CultureInfo(int culture, bool useUserOverride, bool read_only)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by name.</summary>
		/// <param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name, <see cref="P:System.Globalization.CultureInfo.Name" /> of an existing <see cref="T:System.Globalization.CultureInfo" />, or Windows-only culture name. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is not a valid culture name. -or-In .NET Compact Framework applications, <paramref name="culture" /> is not supported by the operating system of the device.</exception>
		public CultureInfo(string name)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.CultureInfo" /> class based on the culture specified by name and on the Boolean that specifies whether to use the user-selected culture settings from the system.</summary>
		/// <param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name, <see cref="P:System.Globalization.CultureInfo.Name" /> of an existing <see cref="T:System.Globalization.CultureInfo" />, or Windows-only culture name. </param>
		/// <param name="useUserOverride">A Boolean that denotes whether to use the user-selected culture settings (true) or the default culture settings (false). </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is not a valid culture name. -or-In .NET Compact Framework applications, <paramref name="culture" /> is not supported by the operating system of the device.</exception>
		public CultureInfo(string name, bool useUserOverride)
		{
		}

		private CultureInfo(string name, bool useUserOverride, bool read_only)
		{
		}

		private CultureInfo()
		{
		}

		static CultureInfo()
		{
		}

		/// <summary>Creates a <see cref="T:System.Globalization.CultureInfo" /> object that represents the specific culture that is associated with the specified name.</summary>
		/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> object that represents:The invariant culture, if <paramref name="name" /> is an empty string ("").-or- The specific culture associated with <paramref name="name" />, if <paramref name="name" /> is a neutral culture.-or- The culture specified by <paramref name="name" />, if <paramref name="name" /> is already a specific culture.</returns>
		/// <param name="name">A predefined <see cref="T:System.Globalization.CultureInfo" /> name or the name of an existing <see cref="T:System.Globalization.CultureInfo" /> object. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> is not a valid culture name.-or- The culture specified by <paramref name="name" /> does not have a specific culture associated with it. </exception>
		/// <exception cref="T:System.NullReferenceException">
		///   <paramref name="name" /> is null. </exception>
		public static CultureInfo CreateSpecificCulture(string name)
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		internal static CultureInfo ConstructCurrentCulture()
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		internal static CultureInfo ConstructCurrentUICulture()
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Refreshes cached culture-related information.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public void ClearCachedData()
		{
		}

		/// <summary>Creates a copy of the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>A copy of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		public virtual object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Determines whether the specified object is the same culture as the current <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>true if <paramref name="value" /> is the same culture as the current <see cref="T:System.Globalization.CultureInfo" />; otherwise, false.</returns>
		/// <param name="value">The object to compare with the current <see cref="T:System.Globalization.CultureInfo" />. </param>
		public override bool Equals(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Gets the list of supported cultures filtered by the specified <see cref="T:System.Globalization.CultureTypes" /> parameter.</summary>
		/// <returns>An array of type <see cref="T:System.Globalization.CultureInfo" /> that contains the cultures specified by the <paramref name="types" /> parameter. The array of cultures is unsorted.</returns>
		/// <param name="types">A bitwise combination of <see cref="T:System.Globalization.CultureTypes" /> values that filter the cultures to retrieve. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="types" /> specifies an invalid combination of <see cref="T:System.Globalization.CultureTypes" /> values.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static CultureInfo[] GetCultures(CultureTypes types)
		{
			return (CultureInfo[])/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Globalization.CultureInfo" />, suitable for hashing algorithms and data structures, such as a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a read-only wrapper around the specified <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> wrapper around <paramref name="ci" />.</returns>
		/// <param name="ci">The <see cref="T:System.Globalization.CultureInfo" /> to wrap. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="ci" /> is null. </exception>
		public static CultureInfo ReadOnly(CultureInfo ci)
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns a string containing the name of the current <see cref="T:System.Globalization.CultureInfo" /> in the format "&lt;languagecode2&gt;-&lt;country/regioncode2&gt;".</summary>
		/// <returns>A string containing the name of the current <see cref="T:System.Globalization.CultureInfo" />.</returns>
		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static bool IsIDNeutralCulture(int lcid)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		internal void CheckNeutral()
		{
		}

		/// <summary>Gets an object that defines how to format the specified type.</summary>
		/// <returns>The value of the <see cref="P:System.Globalization.CultureInfo.NumberFormat" /> property, which is a <see cref="T:System.Globalization.NumberFormatInfo" /> containing the default number format information for the current <see cref="T:System.Globalization.CultureInfo" />, if <paramref name="formatType" /> is the <see cref="T:System.Type" /> object for the <see cref="T:System.Globalization.NumberFormatInfo" /> class.-or- The value of the <see cref="P:System.Globalization.CultureInfo.DateTimeFormat" /> property, which is a <see cref="T:System.Globalization.DateTimeFormatInfo" /> containing the default date and time format information for the current <see cref="T:System.Globalization.CultureInfo" />, if <paramref name="formatType" /> is the <see cref="T:System.Type" /> object for the <see cref="T:System.Globalization.DateTimeFormatInfo" /> class.-or- null, if <paramref name="formatType" /> is any other object.</returns>
		/// <param name="formatType">The <see cref="T:System.Type" /> for which to get a formatting object. This method only supports the <see cref="T:System.Globalization.NumberFormatInfo" /> and <see cref="T:System.Globalization.DateTimeFormatInfo" /> types. </param>
		public virtual object GetFormat(Type formatType)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		private void Construct()
		{
		}

		private bool ConstructInternalLocaleFromName(string locale)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private bool ConstructInternalLocaleFromLcid(int lcid)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool ConstructInternalLocaleFromSpecificName(CultureInfo ci, string name)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static bool ConstructInternalLocaleFromCurrentLocale(CultureInfo ci)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		private extern bool construct_internal_locale_from_lcid(int lcid);

		[MethodImpl(4096)]
		private extern bool construct_internal_locale_from_name(string name);

		[MethodImpl(4096)]
		private static extern bool construct_internal_locale_from_specific_name(CultureInfo ci, string name);

		[MethodImpl(4096)]
		private static extern bool construct_internal_locale_from_current_locale(CultureInfo ci);

		[MethodImpl(4096)]
		private static extern CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed);

		[MethodImpl(4096)]
		private extern void construct_datetime_format();

		[MethodImpl(4096)]
		private extern void construct_number_format();

		[MethodImpl(4096)]
		private static extern bool internal_is_lcid_neutral(int lcid, out bool is_neutral);

		private void ConstructInvariant(bool read_only)
		{
		}

		private TextInfo CreateTextInfo(bool readOnly)
		{
			return (TextInfo)/*Error near IL_0001: Stack underflow*/;
		}

		private static void insert_into_shared_tables(CultureInfo c)
		{
		}

		/// <summary>Retrieves a cached, read-only instance of a culture using the specified culture identifier.</summary>
		/// <returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns>
		/// <param name="culture">A culture identifier.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="culture" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="culture" /> specifies a culture that is not supported.</exception>
		public static CultureInfo GetCultureInfo(int culture)
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves a cached, read-only instance of a culture using the specified culture name. </summary>
		/// <returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns>
		/// <param name="name">The name of a culture.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> specifies a culture that is not supported.</exception>
		public static CultureInfo GetCultureInfo(string name)
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Retrieves a cached, read-only instance of a culture. Parameters specify a culture that is initialized with the <see cref="T:System.Globalization.TextInfo" /> and <see cref="T:System.Globalization.CompareInfo" /> objects specified by another culture.</summary>
		/// <returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns>
		/// <param name="name">The name of a culture.</param>
		/// <param name="altName">The name of a culture that supplies the <see cref="T:System.Globalization.TextInfo" /> and <see cref="T:System.Globalization.CompareInfo" /> objects used to initialize <paramref name="name" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> or <paramref name="altName" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> or <paramref name="altName" /> specifies a culture that is not supported.</exception>
		[MonoTODO("Currently it ignores the altName parameter")]
		public static CultureInfo GetCultureInfo(string name, string altName)
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Deprecated. Retrieves a read-only <see cref="T:System.Globalization.CultureInfo" /> object having linguistic characteristics that are identified by the specified RFC 4646 language tag. </summary>
		/// <returns>A read-only <see cref="T:System.Globalization.CultureInfo" /> object.</returns>
		/// <param name="name">The name of a language as specified by the RFC 4646 standard.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="name" /> is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="name" /> does not correspond to a supported culture.</exception>
		public static CultureInfo GetCultureInfoByIetfLanguageTag(string name)
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		internal static CultureInfo CreateCulture(string name, bool reference)
		{
			return (CultureInfo)/*Error near IL_0001: Stack underflow*/;
		}

		internal void ConstructCalendars()
		{
		}
	}
}
