using System.Collections;
using System.Reflection;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the set of captures made by a single capturing group.</summary>
	[Serializable]
	[DefaultMember("Item")]
	public class CaptureCollection : ICollection, IEnumerable
	{
		private Capture[] list;

		/// <summary>Gets the number of substrings captured by the group.</summary>
		/// <returns>The number of items in the <see cref="T:System.Text.RegularExpressions.CaptureCollection" />.</returns>
		public int Count => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether access to the collection is synchronized (thread-safe).</summary>
		/// <returns>false in all cases.</returns>
		public bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
		/// <returns>An object that can be used to synchronize access to the collection.</returns>
		public object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		internal CaptureCollection(int n)
		{
		}

		internal void SetValue(Capture cap, int i)
		{
		}

		/// <summary>Copies all the elements of the collection to the given array beginning at the given index.</summary>
		/// <param name="array">The array the collection is to be copied into. </param>
		/// <param name="arrayIndex">The position in the destination array where copying is to begin. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array " />is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />. -or-<paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.CaptureCollection.Count" /> is outside the bounds of <paramref name="array" />. </exception>
		public void CopyTo(Array array, int index)
		{
		}

		/// <summary>Provides an enumerator that iterates through the collection.</summary>
		/// <returns>An object that contains all <see cref="T:System.Text.RegularExpressions.Capture" /> objects within the <see cref="T:System.Text.RegularExpressions.CaptureCollection" />.</returns>
		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
