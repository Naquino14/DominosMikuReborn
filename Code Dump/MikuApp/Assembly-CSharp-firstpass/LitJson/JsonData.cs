using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace LitJson
{
	public class JsonData : ICollection, IJsonWrapper, IDictionary, IList, IEnumerable, IOrderedDictionary, IEquatable<JsonData>
	{
		private IList<JsonData> inst_array;

		private bool inst_boolean;

		private double inst_double;

		private int inst_int;

		private long inst_long;

		private IDictionary<string, JsonData> inst_object;

		private string inst_string;

		private string json;

		private JsonType type;

		private IList<KeyValuePair<string, JsonData>> object_list;

		int ICollection.Count => (int)/*Error near IL_0001: Stack underflow*/;

		bool ICollection.IsSynchronized => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		object ICollection.SyncRoot => (object)/*Error near IL_0001: Stack underflow*/;

		bool IDictionary.IsFixedSize => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IDictionary.IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		ICollection IDictionary.Keys => (ICollection)/*Error near IL_0001: Stack underflow*/;

		ICollection IDictionary.Values => (ICollection)/*Error near IL_0001: Stack underflow*/;

		bool IJsonWrapper.IsArray => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IJsonWrapper.IsBoolean => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IJsonWrapper.IsDouble => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IJsonWrapper.IsInt => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IJsonWrapper.IsLong => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IJsonWrapper.IsObject => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IJsonWrapper.IsString => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IList.IsFixedSize => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		bool IList.IsReadOnly => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		object IDictionary.this[object key]
		{
			get
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		object IOrderedDictionary.this[int idx]
		{
			get
			{
				return (object)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

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

		public int Count => (int)/*Error near IL_0001: Stack underflow*/;

		public bool IsArray => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsBoolean => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsDouble => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsInt => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsLong => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsObject => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public bool IsString => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public JsonData this[string prop_name]
		{
			get
			{
				return (JsonData)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public JsonData this[int index]
		{
			get
			{
				return (JsonData)/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public JsonData()
		{
		}

		public JsonData(bool boolean)
		{
		}

		public JsonData(double number)
		{
		}

		public JsonData(int number)
		{
		}

		public JsonData(long number)
		{
		}

		public JsonData(object obj)
		{
		}

		public JsonData(string str)
		{
		}

		void ICollection.CopyTo(Array array, int index)
		{
		}

		void IDictionary.Add(object key, object value)
		{
		}

		void IDictionary.Clear()
		{
		}

		bool IDictionary.Contains(object key)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return (IDictionaryEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		void IDictionary.Remove(object key)
		{
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		bool IJsonWrapper.GetBoolean()
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		double IJsonWrapper.GetDouble()
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		int IJsonWrapper.GetInt()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		long IJsonWrapper.GetLong()
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		string IJsonWrapper.GetString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		void IJsonWrapper.SetBoolean(bool val)
		{
		}

		void IJsonWrapper.SetDouble(double val)
		{
		}

		void IJsonWrapper.SetInt(int val)
		{
		}

		void IJsonWrapper.SetLong(long val)
		{
		}

		void IJsonWrapper.SetString(string val)
		{
		}

		string IJsonWrapper.ToJson()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		void IJsonWrapper.ToJson(JsonWriter writer)
		{
		}

		int IList.Add(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		void IList.Clear()
		{
		}

		bool IList.Contains(object value)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		int IList.IndexOf(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		void IList.Insert(int index, object value)
		{
		}

		void IList.Remove(object value)
		{
		}

		void IList.RemoveAt(int index)
		{
		}

		IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
		{
			return (IDictionaryEnumerator)/*Error near IL_0001: Stack underflow*/;
		}

		void IOrderedDictionary.Insert(int idx, object key, object value)
		{
		}

		void IOrderedDictionary.RemoveAt(int idx)
		{
		}

		private ICollection EnsureCollection()
		{
			return (ICollection)/*Error near IL_0001: Stack underflow*/;
		}

		private IDictionary EnsureDictionary()
		{
			return (IDictionary)/*Error near IL_0001: Stack underflow*/;
		}

		private IList EnsureList()
		{
			return (IList)/*Error near IL_0001: Stack underflow*/;
		}

		private JsonData ToJsonData(object obj)
		{
			return (JsonData)/*Error near IL_0001: Stack underflow*/;
		}

		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		public int Add(object value)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public void Clear()
		{
		}

		public bool Equals(JsonData x)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public JsonType GetJsonType()
		{
			return (JsonType)/*Error near IL_0001: Stack underflow*/;
		}

		public void SetJsonType(JsonType type)
		{
		}

		public string ToJson()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public void ToJson(JsonWriter writer)
		{
		}

		public override string ToString()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static implicit operator JsonData(bool data)
		{
			return (JsonData)/*Error near IL_0001: Stack underflow*/;
		}

		public static implicit operator JsonData(double data)
		{
			return (JsonData)/*Error near IL_0001: Stack underflow*/;
		}

		public static implicit operator JsonData(int data)
		{
			return (JsonData)/*Error near IL_0001: Stack underflow*/;
		}

		public static implicit operator JsonData(long data)
		{
			return (JsonData)/*Error near IL_0001: Stack underflow*/;
		}

		public static implicit operator JsonData(string data)
		{
			return (JsonData)/*Error near IL_0001: Stack underflow*/;
		}

		public static explicit operator bool(JsonData data)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static explicit operator double(JsonData data)
		{
			return (double)/*Error near IL_0001: Stack underflow*/;
		}

		public static explicit operator int(JsonData data)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static explicit operator long(JsonData data)
		{
			return (long)/*Error near IL_0001: Stack underflow*/;
		}

		public static explicit operator string(JsonData data)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
