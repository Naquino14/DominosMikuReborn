using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Collections.ObjectModel
{
	/// <summary>Provides the base class for a generic read-only collection. </summary>
	/// <typeparam name="T">The type of elements in the collection.</typeparam>
	[Serializable]
	[ComVisible(false)]
	public class ReadOnlyCollection<T> : ICollection<T>, IEnumerable<T>, IList<T>, ICollection, IEnumerable, IList
	{
		private IList<T> list;

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <returns>The element at the specified index.</returns>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		T IList<T>.this[int index]
		{
			get
			{
				return (T)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only; otherwise, false.  In the default implementation of <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, this property always returns true.</returns>
		bool ICollection<T>.IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).</summary>
		/// <returns>true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, false.  In the default implementation of <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, this property always returns false.</returns>
		bool ICollection.IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.  In the default implementation of <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, this property always returns the current instance.</returns>
		object ICollection.SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> has a fixed size.</summary>
		/// <returns>true if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, false.  In the default implementation of <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, this property always returns true.</returns>
		bool IList.IsFixedSize => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.IList" /> is read-only.</summary>
		/// <returns>true if the <see cref="T:System.Collections.IList" /> is read-only; otherwise, false.  In the default implementation of <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, this property always returns true.</returns>
		bool IList.IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <returns>The element at the specified index.</returns>
		/// <param name="index">The zero-based index of the element to get.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.IList" />. </exception>
		/// <exception cref="T:System.NotSupportedException">Always thrown if the property is set.</exception>
		object IList.this[int index]
		{
			get
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> instance.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> instance.</returns>
		public int Count => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets the element at the specified index.</summary>
		/// <returns>The element at the specified index.</returns>
		/// <param name="index">The zero-based index of the element to get.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.-or-<paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ObjectModel.ReadOnlyCollection`1.Count" />. </exception>
		public T this[int index] => (T)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> class that is a read-only wrapper around the specified list.</summary>
		/// <param name="list">The list to wrap.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="list" /> is null.</exception>
		public ReadOnlyCollection(IList<T> list)
		{
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1" />.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void ICollection<T>.Add(T item)
		{
		}

		/// <summary>Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1" />.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void ICollection<T>.Clear()
		{
		}

		/// <summary>Inserts an item to the <see cref="T:System.Collections.Generic.IList`1" /> at the specified index.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The object to insert into the <see cref="T:System.Collections.Generic.IList`1" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList<T>.Insert(int index, T item)
		{
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1" />.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>true if <paramref name="value" /> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.</returns>
		/// <param name="value">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		bool ICollection<T>.Remove(T item)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Removes the <see cref="T:System.Collections.Generic.IList`1" /> item at the specified index.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList<T>.RemoveAt(int index)
		{
		}

		/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or-<paramref name="array" /> does not have zero-based indexing.-or-The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.-or-The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
		void ICollection.CopyTo(Array array, int index)
		{
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Adds an item to the <see cref="T:System.Collections.IList" />.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <returns>The position into which the new element was inserted.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to add to the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		int IList.Add(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes all items from the <see cref="T:System.Collections.IList" />.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Clear()
		{
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.IList" /> contains a specific value.</summary>
		/// <returns>true if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, false.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not of the type specified for the generic type parameter <paramref name="T" />.</exception>
		bool IList.Contains(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.</summary>
		/// <returns>The index of <paramref name="value" /> if found in the list; otherwise, -1.</returns>
		/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="value" /> is not of the type specified for the generic type parameter <paramref name="T" />.</exception>
		int IList.IndexOf(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Inserts an item to the <see cref="T:System.Collections.IList" /> at the specified index.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The <see cref="T:System.Object" /> to insert into the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Insert(int index, object value)
		{
		}

		/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="value">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.Remove(object value)
		{
		}

		/// <summary>Removes the <see cref="T:System.Collections.IList" /> item at the specified index.  This implementation always throws <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <exception cref="T:System.NotSupportedException">Always thrown.</exception>
		void IList.RemoveAt(int index)
		{
		}

		/// <summary>Determines whether an element is in the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</summary>
		/// <returns>true if <paramref name="value" /> is found in the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />; otherwise, false.</returns>
		/// <param name="value">The object to locate in the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />. The value can be null for reference types.</param>
		public bool Contains(T value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Copies the entire <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero.</exception>
		/// <exception cref="T:System.ArgumentException">The number of elements in the source <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
		public void CopyTo(T[] array, int index)
		{
		}

		/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerator`1" /> for the <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</returns>
		public IEnumerator<T> GetEnumerator()
		{
			return (IEnumerator<T>)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Searches for the specified object and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />.</summary>
		/// <returns>The zero-based index of the first occurrence of <paramref name="item" /> within the entire <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" />, if found; otherwise, -1.</returns>
		/// <param name="value">The object to locate in the <see cref="T:System.Collections.Generic.List`1" />. The value can be null for reference types.</param>
		public int IndexOf(T value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}