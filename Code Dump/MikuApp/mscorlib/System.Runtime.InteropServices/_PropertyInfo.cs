using System.Globalization;
using System.Reflection;

namespace System.Runtime.InteropServices
{
	/// <summary>Exposes the public members of the <see cref="T:System.Reflection.PropertyInfo" /> class to unmanaged code.</summary>
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[TypeLibImportClass(typeof(PropertyInfo))]
	[Guid("F59ED4E4-E68F-3218-BD77-061AA82824BF")]
	[ComVisible(true)]
	[CLSCompliant(false)]
	public interface _PropertyInfo
	{
		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.Attributes" /> property.</summary>
		/// <returns>The attributes of this property.</returns>
		PropertyAttributes Attributes
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.CanRead" /> property.</summary>
		/// <returns>true if this property can be read; otherwise, false.</returns>
		bool CanRead
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.CanWrite" /> property.</summary>
		/// <returns>true if this property can be written to; otherwise, false.</returns>
		bool CanWrite
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.MemberType" /> property.</summary>
		/// <returns>One of the <see cref="T:System.Reflection.MemberTypes" /> values indicating that this member is a property.</returns>
		MemberTypes MemberType
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="P:System.Reflection.PropertyInfo.PropertyType" /> property.</summary>
		/// <returns>The type of this property.</returns>
		Type PropertyType
		{
			get;
		}

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetGetMethod(System.Boolean)" /> method.</summary>
		/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing the get accessor for this property, if the <paramref name="nonPublic" /> parameter is true. Or null if <paramref name="nonPublic" /> is false and the get accessor is non-public, or if <paramref name="nonPublic" /> is true but no get accessors exist.</returns>
		/// <param name="nonPublic">true to return a non-public get accessor; otherwise, false.</param>
		MethodInfo GetGetMethod(bool nonPublic);

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetIndexParameters" /> method.</summary>
		/// <returns>An array of type <see cref="T:System.Reflection.ParameterInfo" /> containing the parameters for the indexes.</returns>
		ParameterInfo[] GetIndexParameters();

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetSetMethod(System.Boolean)" /> method.</summary>
		/// <returns>Value Condition A <see cref="T:System.Reflection.MethodInfo" /> object representing the Set method for this property. The set accessor is public.-or- The <paramref name="nonPublic" /> parameter is true and the set accessor is non-public. nullThe <paramref name="nonPublic" /> parameter is true, but the property is read-only.-or- The <paramref name="nonPublic" /> parameter is false and the set accessor is non-public.-or- There is no set accessor. </returns>
		/// <param name="nonPublic">true to return a non-public accessor; otherwise, false.</param>
		MethodInfo GetSetMethod(bool nonPublic);

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetValue(System.Object,System.Object[])" /> method.</summary>
		/// <returns>The property value for the <paramref name="obj" /> parameter.</returns>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		object GetValue(object obj, object[] index);

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.GetValue(System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> method.</summary>
		/// <returns>The property value for the <paramref name="obj" /> parameter.</returns>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from BindingFlags: InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member will be invoked, the Static flag of BindingFlags must be set. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		/// <param name="culture">The CultureInfo object that represents the culture for which the resource will be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param>
		object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.PropertyInfo.SetValue(System.Object,System.Object,System.Object[])" /> method.</summary>
		/// <param name="obj">The object whose property value will be set. </param>
		/// <param name="value">The new value for this property. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		void SetValue(object obj, object value, object[] index);

		/// <summary>Provides COM objects with version-independent access to the <see cref="M:System.Reflection.FieldInfo.SetValue(System.Object,System.Object,System.Reflection.BindingFlags,System.Reflection.Binder,System.Globalization.CultureInfo)" /> method.</summary>
		/// <param name="obj">The object whose property value will be returned. </param>
		/// <param name="value">The new value for this property. </param>
		/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />: InvokeMethod, CreateInstance, Static, GetField, SetField, GetProperty, or SetProperty. A suitable invocation attribute must be specified. If a static member will be invoked, the Static flag of BindingFlags must be set. </param>
		/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is null, the default binder is used. </param>
		/// <param name="index">Optional index values for indexed properties. This value should be null for non-indexed properties. </param>
		/// <param name="culture">The <see cref="T:System.Globalization.CultureInfo" /> object that represents the culture for which the resource will be localized. Note that if the resource is not localized for this culture, the CultureInfo.Parent method will be called successively in search of a match. If this value is null, the CultureInfo is obtained from the CultureInfo.CurrentUICulture property. </param>
		void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);
	}
}
