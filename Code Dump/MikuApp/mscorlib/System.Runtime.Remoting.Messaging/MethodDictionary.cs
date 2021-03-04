using System.Collections;

namespace System.Runtime.Remoting.Messaging
{
	[Serializable]
	internal class MethodDictionary : ICollection, IDictionary, IEnumerable
	{
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private MethodDictionary _methodDictionary;

			private IDictionaryEnumerator _hashtableEnum;

			private int _posMethod;

			public object Current => (object)/*Error near IL_0001: Stack underflow*/;

			public DictionaryEntry Entry => (DictionaryEntry)/*Error near IL_0001: Stack underflow*/;

			public object Key => (object)/*Error near IL_0001: Stack underflow*/;

			public object Value => (object)/*Error near IL_0001: Stack underflow*/;

			public DictionaryEnumerator(MethodDictionary methodDictionary)
			{
			}

			public bool MoveNext()
			{
				return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
			}

			public void Reset()
			{
			}
		}

		private IDictionary _internalProperties;

		protected IMethodMessage _message;

		private string[] _methodKeys;

		private bool _ownProperties;

		internal bool HasInternalProperties => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		internal IDictionary InternalProperties => (IDictionary)/*Error near IL_0001: Stack underflow*/;

		public string[] MethodKeys
		{
			set
			{
			}
		}

		public bool IsFixedSize => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public object this[object key]
		{
			get
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public ICollection Keys => (ICollection)/*Error near IL_0001: Stack underflow*/;

		public ICollection Values => (ICollection)/*Error near IL_0001: Stack underflow*/;

		public int Count => (int)/*Error near IL_0001: Stack underflow*/;

		public bool IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public object SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		public MethodDictionary(IMethodMessage message)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		protected virtual IDictionary AllocInternalProperties()
		{
			return (IDictionary)/*Error near IL_0001: Stack underflow*/;
		}

		public IDictionary GetInternalProperties()
		{
			return (IDictionary)/*Error near IL_0001: Stack underflow*/;
		}

		private bool IsOverridenKey(string key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		protected virtual object GetMethodProperty(string key)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		protected virtual void SetMethodProperty(string key, object value)
		{
		}

		public void Add(object key, object value)
		{
		}

		public void Clear()
		{
		}

		public bool Contains(object key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public void Remove(object key)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public IDictionaryEnumerator GetEnumerator()
		{
			return (IDictionaryEnumerator)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
