namespace System.Collections
{
	/// <summary>Represents a simple last-in-first-out (LIFO) non-generic collection of objects.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	public class Stack : ICollection, IEnumerable, ICloneable
	{
		private class Enumerator : IEnumerator, ICloneable
		{
			private const int EOF = -1;

			private const int BOF = -2;

			private Stack stack;

			private int modCount;

			private int current;

			public virtual object Current => (object)/*Error near IL_0001: Stack underflow*/;

			internal Enumerator(Stack s)
			{
			}

			public object Clone()
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}

			public virtual bool MoveNext()
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public virtual void Reset()
			{
			}
		}

		private const int default_capacity = 16;

		private object[] contents;

		private int current;

		private int count;

		private int capacity;

		private int modCount;

		/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Stack" />.</summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.Stack" />.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual int Count => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Stack" /> is synchronized (thread safe).</summary>
		/// <returns>true, if access to the <see cref="T:System.Collections.Stack" /> is synchronized (thread safe); otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Stack" />.</summary>
		/// <returns>An <see cref="T:System.Object" /> that can be used to synchronize access to the <see cref="T:System.Collections.Stack" />.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Stack" /> class that is empty and has the default initial capacity.</summary>
		public Stack()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Stack" /> class that contains elements copied from the specified collection and has the same initial capacity as the number of elements copied.</summary>
		/// <param name="col">The <see cref="T:System.Collections.ICollection" /> to copy elements from. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="col" /> is null. </exception>
		public Stack(ICollection col)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Stack" /> class that is empty and has the specified initial capacity or the default initial capacity, whichever is greater.</summary>
		/// <param name="initialCapacity">The initial number of elements that the <see cref="T:System.Collections.Stack" /> can contain. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="initialCapacity" /> is less than zero. </exception>
		public Stack(int initialCapacity)
		{
		}

		private void Resize(int ncapacity)
		{
		}

		/// <summary>Removes all objects from the <see cref="T:System.Collections.Stack" />.</summary>
		/// <filterpriority>2</filterpriority>
		public virtual void Clear()
		{
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.Stack" />.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Collections.Stack" />.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the <see cref="T:System.Collections.Stack" /> to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.Stack" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="index" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Stack" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Stack" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		/// <filterpriority>2</filterpriority>
		public virtual void CopyTo(Array array, int index)
		{
		}

		/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Stack" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.Stack" />.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual IEnumerator GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the object at the top of the <see cref="T:System.Collections.Stack" /> without removing it.</summary>
		/// <returns>The <see cref="T:System.Object" /> at the top of the <see cref="T:System.Collections.Stack" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Stack" /> is empty. </exception>
		/// <filterpriority>2</filterpriority>
		public virtual object Peek()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes and returns the object at the top of the <see cref="T:System.Collections.Stack" />.</summary>
		/// <returns>The <see cref="T:System.Object" /> removed from the top of the <see cref="T:System.Collections.Stack" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Collections.Stack" /> is empty. </exception>
		/// <filterpriority>2</filterpriority>
		public virtual object Pop()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Inserts an object at the top of the <see cref="T:System.Collections.Stack" />.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to push onto the <see cref="T:System.Collections.Stack" />. The value can be null. </param>
		/// <filterpriority>2</filterpriority>
		public virtual void Push(object obj)
		{
		}
	}
}
