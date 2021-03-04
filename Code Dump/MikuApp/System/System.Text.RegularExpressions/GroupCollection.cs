using System.Collections;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents a collection of captured groups in a single match. </summary>
	[Serializable]
	public class GroupCollection : ICollection, IEnumerable
	{
		private Group[] list;

		private int gap;

		/// <summary>Returns the number of groups in the collection.</summary>
		/// <returns>The number of groups in the collection.</returns>
		public int Count => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether access to the GroupCollection is synchronized (thread-safe).</summary>
		/// <returns>true if access is synchronized; otherwise false.</returns>
		public bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Enables access to a member of the collection by integer index.</summary>
		/// <returns>The member of the collection specified by <paramref name="groupnum" />.</returns>
		/// <param name="groupnum">The zero-based index of the collection member to be retrieved. </param>
		public Group this[int i] => (Group)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets an object that can be used to synchronize access to the GroupCollection.</summary>
		/// <returns>A copy of the <see cref="T:System.Text.RegularExpressions.Match" /> object to synchronize.</returns>
		public object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		internal GroupCollection(int n, int gap)
		{
		}

		internal void SetValue(Group g, int i)
		{
		}

		/// <summary>Copies all the elements of the collection to the given array beginning at the given index.</summary>
		/// <param name="array">The array the collection is to be copied into. </param>
		/// <param name="arrayIndex">The position in the destination array where the copying is to begin. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///   <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />.-or-<paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.GroupCollection.Count" /> is outside the bounds of <paramref name="array" />.</exception>
		public void CopyTo(Array array, int index)
		{
		}

		/// <summary>Returns an enumerator that can iterate through the collection.</summary>
		/// <returns>An object that contains all <see cref="T:System.Text.RegularExpressions.Group" /> objects in the <see cref="T:System.Text.RegularExpressions.GroupCollection" />.</returns>
		public IEnumerator GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
