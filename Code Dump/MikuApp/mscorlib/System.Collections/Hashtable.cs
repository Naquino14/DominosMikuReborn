using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

namespace System.Collections
{
	/// <summary>Represents a collection of key/value pairs that are organized based on the hash code of the key.</summary>
	/// <filterpriority>1</filterpriority>
	[Serializable]
	public class Hashtable : ICollection, IDictionary, IEnumerable, ICloneable, IDeserializationCallback, ISerializable
	{
		[Serializable]
		private sealed class Enumerator : IDictionaryEnumerator, IEnumerator
		{
			private Hashtable host;

			private int stamp;

			private int pos;

			private int size;

			private EnumeratorMode mode;

			private object currentKey;

			private object currentValue;

			private static readonly string xstr;

			public DictionaryEntry Entry => (DictionaryEntry)/*Error near IL_0001: Stack underflow*/;

			public object Key => (object)/*Error near IL_0001: Stack underflow*/;

			public object Value => (object)/*Error near IL_0001: Stack underflow*/;

			public object Current => (object)/*Error near IL_0001: Stack underflow*/;

			public Enumerator(Hashtable host, EnumeratorMode mode)
			{
			}

			private void FailFast()
			{
			}

			public void Reset()
			{
			}

			public bool MoveNext()
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}
		}

		private enum EnumeratorMode
		{
			KEY_MODE,
			VALUE_MODE,
			ENTRY_MODE
		}

		[Serializable]
		private class HashKeys : ICollection, IEnumerable
		{
			private Hashtable host;

			public virtual int Count => (int)/*Error near IL_0001: Stack underflow*/;

			public virtual bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public virtual object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

			public HashKeys(Hashtable host)
			{
			}

			public virtual void CopyTo(Array array, int arrayIndex)
			{
			}

			public virtual IEnumerator GetEnumerator()
			{
				return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
			}
		}

		[Serializable]
		private class HashValues : ICollection, IEnumerable
		{
			private Hashtable host;

			public virtual int Count => (int)/*Error near IL_0001: Stack underflow*/;

			public virtual bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public virtual object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

			public HashValues(Hashtable host)
			{
			}

			public virtual void CopyTo(Array array, int arrayIndex)
			{
			}

			public virtual IEnumerator GetEnumerator()
			{
				return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
			}
		}

		[Serializable]
		internal class KeyMarker
		{
			public static readonly KeyMarker Removed;
		}

		[Serializable]
		internal struct Slot
		{
			internal object key;

			internal object value;
		}

		[Serializable]
		private class SyncHashtable : Hashtable, IEnumerable
		{
			private Hashtable host;

			public override int Count => (int)/*Error near IL_0001: Stack underflow*/;

			public override bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public override object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

			public override bool IsFixedSize => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public override bool IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

			public override ICollection Keys => (ICollection)/*Error near IL_0001: Stack underflow*/;

			public override ICollection Values => (ICollection)/*Error near IL_0001: Stack underflow*/;

			public override object this[object key]
			{
				get
				{
					return (object)/*Error near IL_0001: Stack underflow*/;
				}
				set
				{
				}
			}

			public SyncHashtable(Hashtable host)
			{
			}

			internal SyncHashtable(SerializationInfo info, StreamingContext context)
			{
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
			}

			public override void GetObjectData(SerializationInfo info, StreamingContext context)
			{
			}

			public override void CopyTo(Array array, int arrayIndex)
			{
			}

			public override void Add(object key, object value)
			{
			}

			public override void Clear()
			{
			}

			public override bool Contains(object key)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public override IDictionaryEnumerator GetEnumerator()
			{
				return (IDictionaryEnumerator)/*Error near IL_0001: Stack underflow*/;
			}

			public override void Remove(object key)
			{
			}

			public override bool ContainsKey(object key)
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public override object Clone()
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}
		}

		private const int CHAIN_MARKER = int.MinValue;

		private int inUse;

		private int modificationCount;

		private float loadFactor;

		private Slot[] table;

		private int[] hashes;

		private int threshold;

		private HashKeys hashKeys;

		private HashValues hashValues;

		private IHashCodeProvider hcpRef;

		private IComparer comparerRef;

		private SerializationInfo serializationInfo;

		private IEqualityComparer equalityComparer;

		private static readonly int[] primeTbl;

		/// <summary>Gets or sets the <see cref="T:System.Collections.IComparer" /> to use for the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>The <see cref="T:System.Collections.IComparer" /> to use for the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <exception cref="T:System.ArgumentException">The property is set to a value, but the hash table was created using an <see cref="T:System.Collections.IEqualityComparer" />. </exception>
		[Obsolete("Please use EqualityComparer property.")]
		protected IComparer comparer
		{
			set
			{
			}
		}

		/// <summary>Gets or sets the object that can dispense hash codes.</summary>
		/// <returns>The object that can dispense hash codes.</returns>
		/// <exception cref="T:System.ArgumentException">The property is set to a value, but the hash table was created using an <see cref="T:System.Collections.IEqualityComparer" />. </exception>
		[Obsolete("Please use EqualityComparer property.")]
		protected IHashCodeProvider hcp
		{
			set
			{
			}
		}

		/// <summary>Gets the number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>The number of key/value pairs contained in the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual int Count => (int)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe).</summary>
		/// <returns>true if access to the <see cref="T:System.Collections.Hashtable" /> is synchronized (thread safe); otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> has a fixed size.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Hashtable" /> has a fixed size; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual bool IsFixedSize => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.Hashtable" /> is read-only.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Hashtable" /> is read-only; otherwise, false. The default is false.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual bool IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the keys in the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual ICollection Keys => (ICollection)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets an <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An <see cref="T:System.Collections.ICollection" /> containing the values in the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual ICollection Values => (ICollection)/*Error near IL_0001: Stack underflow*/;

		/// <summary>Gets or sets the value associated with the specified key.</summary>
		/// <returns>The value associated with the specified key. If the specified key is not found, attempting to get it returns null, and attempting to set it creates a new element using the specified key.</returns>
		/// <param name="key">The key whose value to get or set. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">The property is set and the <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The property is set, <paramref name="key" /> does not exist in the collection, and the <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception>
		/// <filterpriority>2</filterpriority>
		public virtual object this[object key]
		{
			get
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity, load factor, hash code provider, and comparer.</summary>
		public Hashtable()
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, load factor, hash code provider, and comparer.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param>
		/// <param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />. </param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero.-or- <paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
		[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead")]
		public Hashtable(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity and load factor, and the default hash code provider and comparer.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero.-or- <paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="capacity" /> is causing an overflow.</exception>
		public Hashtable(int capacity, float loadFactor)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, and the default load factor, hash code provider, and comparer.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero. </exception>
		public Hashtable(int capacity)
		{
		}

		internal Hashtable(Hashtable source)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity and load factor, and the specified hash code provider and comparer.</summary>
		/// <param name="hcp">The <see cref="T:System.Collections.IHashCodeProvider" /> object that supplies the hash codes for all keys in the <see cref="T:System.Collections.Hashtable" /> object.-or- null to use the default hash code provider, which is each key's implementation of <see cref="M:System.Object.GetHashCode" />.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> object to use to determine whether two keys are equal.-or- null to use the default comparer, which is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />.</param>
		[Obsolete("Please use Hashtable(IEqualityComparer) instead")]
		public Hashtable(IHashCodeProvider hcp, IComparer comparer)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class that is serializable using the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> and <see cref="T:System.Runtime.Serialization.StreamingContext" /> objects.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" /> object.</param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		protected Hashtable(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the default initial capacity and load factor, and the specified <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" /> object.-or- null to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		public Hashtable(IEqualityComparer equalityComparer)
		{
		}

		/// <summary>Initializes a new, empty instance of the <see cref="T:System.Collections.Hashtable" /> class using the specified initial capacity, load factor, and <see cref="T:System.Collections.IEqualityComparer" /> object.</summary>
		/// <param name="capacity">The approximate number of elements that the <see cref="T:System.Collections.Hashtable" /> object can initially contain. </param>
		/// <param name="loadFactor">A number in the range from 0.1 through 1.0 that is multiplied by the default value which provides the best performance. The result is the maximum ratio of elements to buckets.</param>
		/// <param name="equalityComparer">The <see cref="T:System.Collections.IEqualityComparer" /> object that defines the hash code provider and the comparer to use with the <see cref="T:System.Collections.Hashtable" />.-or- null to use the default hash code provider and the default comparer. The default hash code provider is each key's implementation of <see cref="M:System.Object.GetHashCode" /> and the default comparer is each key's implementation of <see cref="M:System.Object.Equals(System.Object)" />. </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="capacity" /> is less than zero.-or- <paramref name="loadFactor" /> is less than 0.1.-or- <paramref name="loadFactor" /> is greater than 1.0. </exception>
		public Hashtable(int capacity, float loadFactor, IEqualityComparer equalityComparer)
		{
		}

		/// <summary>Returns an enumerator that iterates through a collection.</summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Copies the <see cref="T:System.Collections.Hashtable" /> elements to a one-dimensional <see cref="T:System.Array" /> instance at the specified index.</summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the <see cref="T:System.Collections.DictionaryEntry" /> objects copied from <see cref="T:System.Collections.Hashtable" />. The <see cref="T:System.Array" /> must have zero-based indexing. </param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="array" /> is null. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="arrayIndex" /> is less than zero. </exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="array" /> is multidimensional.-or- The number of elements in the source <see cref="T:System.Collections.Hashtable" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />. </exception>
		/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.Hashtable" /> cannot be cast automatically to the type of the destination <paramref name="array" />. </exception>
		/// <filterpriority>2</filterpriority>
		public virtual void CopyTo(Array array, int arrayIndex)
		{
		}

		/// <summary>Adds an element with the specified key and value into the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="key">The key of the element to add. </param>
		/// <param name="value">The value of the element to add. The value can be null. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		/// <exception cref="T:System.ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Hashtable" />. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual void Add(object key, object value)
		{
		}

		/// <summary>Removes all elements from the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only. </exception>
		/// <filterpriority>1</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		public virtual void Clear()
		{
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, false.</returns>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual bool Contains(object key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Returns an <see cref="T:System.Collections.IDictionaryEnumerator" /> that iterates through the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> for the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <filterpriority>2</filterpriority>
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return (IDictionaryEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Removes the element with the specified key from the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="key">The key of the element to remove. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.Hashtable" /> is read-only.-or- The <see cref="T:System.Collections.Hashtable" /> has a fixed size. </exception>
		/// <filterpriority>1</filterpriority>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public virtual void Remove(object key)
		{
		}

		/// <summary>Determines whether the <see cref="T:System.Collections.Hashtable" /> contains a specific key.</summary>
		/// <returns>true if the <see cref="T:System.Collections.Hashtable" /> contains an element with the specified key; otherwise, false.</returns>
		/// <param name="key">The key to locate in the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="key" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public virtual bool ContainsKey(object key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>A shallow copy of the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <filterpriority>1</filterpriority>
		public virtual object Clone()
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and returns the data needed to serialize the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <param name="info">A <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object containing the information required to serialize the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <param name="context">A <see cref="T:System.Runtime.Serialization.StreamingContext" /> object containing the source and destination of the serialized stream associated with the <see cref="T:System.Collections.Hashtable" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="info" /> is null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The collection was modified.</exception>
		/// <filterpriority>2</filterpriority>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Implements the <see cref="T:System.Runtime.Serialization.ISerializable" /> interface and raises the deserialization event when the deserialization is complete.</summary>
		/// <param name="sender">The source of the deserialization event. </param>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object associated with the current <see cref="T:System.Collections.Hashtable" /> is invalid. </exception>
		/// <filterpriority>2</filterpriority>
		[MonoTODO("Serialize equalityComparer")]
		public virtual void OnDeserialization(object sender)
		{
		}

		/// <summary>Returns a synchronized (thread safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>A synchronized (thread safe) wrapper for the <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <param name="table">The <see cref="T:System.Collections.Hashtable" /> to synchronize. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="table" /> is null. </exception>
		/// <filterpriority>1</filterpriority>
		public static Hashtable Synchronized(Hashtable table)
		{
			return (Hashtable)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Returns the hash code for the specified key.</summary>
		/// <returns>The hash code for <paramref name="key" />.</returns>
		/// <param name="key">The <see cref="T:System.Object" /> for which a hash code is to be returned. </param>
		/// <exception cref="T:System.NullReferenceException">
		///   <paramref name="key" /> is null. </exception>
		protected virtual int GetHash(object key)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		/// <summary>Compares a specific <see cref="T:System.Object" /> with a specific key in the <see cref="T:System.Collections.Hashtable" />.</summary>
		/// <returns>true if <paramref name="item" /> and <paramref name="key" /> are equal; otherwise, false.</returns>
		/// <param name="item">The <see cref="T:System.Object" /> to compare with <paramref name="key" />. </param>
		/// <param name="key">The key in the <see cref="T:System.Collections.Hashtable" /> to compare with <paramref name="item" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="item" /> is null.-or- <paramref name="key" /> is null. </exception>
		protected virtual bool KeyEquals(object item, object key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private void AdjustThreshold()
		{
		}

		private void SetTable(Slot[] table, int[] hashes)
		{
		}

		private int Find(object key)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private void Rehash()
		{
		}

		private void PutImpl(object key, object value, bool overwrite)
		{
		}

		private void CopyToArray(Array arr, int i, EnumeratorMode mode)
		{
		}

		internal static bool TestPrime(int x)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		internal static int CalcPrime(int x)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		internal static int ToPrime(int x)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
