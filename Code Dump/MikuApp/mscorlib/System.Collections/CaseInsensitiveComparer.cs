using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Collections
{
	/// <summary>Compares two objects for equivalence, ignoring the case of strings.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public class CaseInsensitiveComparer : IComparer
	{
		private static CaseInsensitiveComparer defaultComparer;

		private static CaseInsensitiveComparer defaultInvariantComparer;

		private CultureInfo culture;

		/// <summary>Gets an instance of <see cref="T:System.Collections.CaseInsensitiveComparer" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread and that is always available.</summary>
		/// <returns>An instance of <see cref="T:System.Collections.CaseInsensitiveComparer" /> that is associated with the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static CaseInsensitiveComparer Default => (CaseInsensitiveComparer)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.CaseInsensitiveComparer" /> class using the <see cref="P:System.Threading.Thread.CurrentCulture" /> of the current thread.</summary>
		public CaseInsensitiveComparer()
		{
		}

		private CaseInsensitiveComparer(bool invariant)
		{
		}

		/// <summary>Performs a case-insensitive comparison of two objects of the same type and returns a value indicating whether one is less than, equal to, or greater than the other.</summary>
		/// <returns>Value Condition Less than zero <paramref name="a" /> is less than <paramref name="b" />, with casing ignored. Zero <paramref name="a" /> equals <paramref name="b" />, with casing ignored. Greater than zero <paramref name="a" /> is greater than <paramref name="b" />, with casing ignored. </returns>
		/// <param name="a">The first object to compare. </param>
		/// <param name="b">The second object to compare. </param>
		/// <exception cref="T:System.ArgumentException">Neither <paramref name="a" /> nor <paramref name="b" /> implements the <see cref="T:System.IComparable" /> interface.-or- <paramref name="a" /> and <paramref name="b" /> are of different types. </exception>
		/// <filterpriority>2</filterpriority>
		public int Compare(object a, object b)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
