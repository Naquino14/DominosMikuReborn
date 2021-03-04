using System.Collections;
using System.Collections.Generic;

namespace LitJson
{
	internal class OrderedDictionaryEnumerator : IEnumerator, IDictionaryEnumerator
	{
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

		public object Current => (object)/*Error near IL_0001: Stack underflow*/;

		public DictionaryEntry Entry => (DictionaryEntry)/*Error near IL_0001: Stack underflow*/;

		public object Key => (object)/*Error near IL_0001: Stack underflow*/;

		public object Value => (object)/*Error near IL_0001: Stack underflow*/;

		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
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
}
