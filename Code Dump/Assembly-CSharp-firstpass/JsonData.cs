using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace LitJson
{
	// Token: 0x0200000E RID: 14
	public class JsonData : ICollection, IJsonWrapper, IDictionary, IList, IEnumerable, IOrderedDictionary, IEquatable<JsonData>
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x000022A8 File Offset: 0x000004A8
		public JsonData()
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000022AC File Offset: 0x000004AC
		public JsonData(bool boolean)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000022B0 File Offset: 0x000004B0
		public JsonData(double number)
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000022B4 File Offset: 0x000004B4
		public JsonData(int number)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000022B8 File Offset: 0x000004B8
		public JsonData(long number)
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000022BC File Offset: 0x000004BC
		public JsonData(object obj)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000022C0 File Offset: 0x000004C0
		public JsonData(string str)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000022C4 File Offset: 0x000004C4
		int ICollection.Count
		{
			get
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000022C8 File Offset: 0x000004C8
		bool ICollection.IsSynchronized
		{
			get
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000022CC File Offset: 0x000004CC
		object ICollection.SyncRoot
		{
			get
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000022D0 File Offset: 0x000004D0
		bool IDictionary.IsFixedSize
		{
			get
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000022D4 File Offset: 0x000004D4
		bool IDictionary.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000022D8 File Offset: 0x000004D8
		ICollection IDictionary.Keys
		{
			get
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000022DC File Offset: 0x000004DC
		ICollection IDictionary.Values
		{
			get
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000022E0 File Offset: 0x000004E0
		bool IJsonWrapper.IsArray
		{
			get
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000DF RID: 223 RVA: 0x000022E4 File Offset: 0x000004E4
		bool IJsonWrapper.IsBoolean
		{
			get
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000022E8 File Offset: 0x000004E8
		bool IJsonWrapper.IsDouble
		{
			get
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000022EC File Offset: 0x000004EC
		bool IJsonWrapper.IsInt
		{
			get
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000022F0 File Offset: 0x000004F0
		bool IJsonWrapper.IsLong
		{
			get
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000022F4 File Offset: 0x000004F4
		bool IJsonWrapper.IsObject
		{
			get
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000022F8 File Offset: 0x000004F8
		bool IJsonWrapper.IsString
		{
			get
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000022FC File Offset: 0x000004FC
		bool IList.IsFixedSize
		{
			get
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002300 File Offset: 0x00000500
		bool IList.IsReadOnly
		{
			get
			{
			}
		}

		// Token: 0x17000019 RID: 25
		object IDictionary.this[object key]
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		object IOrderedDictionary.this[int idx]
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		object IList.this[int index]
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000231C File Offset: 0x0000051C
		void ICollection.CopyTo(Array array, int index)
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002320 File Offset: 0x00000520
		void IDictionary.Add(object key, object value)
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002324 File Offset: 0x00000524
		void IDictionary.Clear()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002328 File Offset: 0x00000528
		bool IDictionary.Contains(object key)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000232C File Offset: 0x0000052C
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002330 File Offset: 0x00000530
		void IDictionary.Remove(object key)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002334 File Offset: 0x00000534
		IEnumerator IEnumerable.GetEnumerator()
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002338 File Offset: 0x00000538
		bool IJsonWrapper.GetBoolean()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000233C File Offset: 0x0000053C
		double IJsonWrapper.GetDouble()
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002340 File Offset: 0x00000540
		int IJsonWrapper.GetInt()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002344 File Offset: 0x00000544
		long IJsonWrapper.GetLong()
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002348 File Offset: 0x00000548
		string IJsonWrapper.GetString()
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000234C File Offset: 0x0000054C
		void IJsonWrapper.SetBoolean(bool val)
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002350 File Offset: 0x00000550
		void IJsonWrapper.SetDouble(double val)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002354 File Offset: 0x00000554
		void IJsonWrapper.SetInt(int val)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002358 File Offset: 0x00000558
		void IJsonWrapper.SetLong(long val)
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000235C File Offset: 0x0000055C
		void IJsonWrapper.SetString(string val)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002360 File Offset: 0x00000560
		string IJsonWrapper.ToJson()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002364 File Offset: 0x00000564
		void IJsonWrapper.ToJson(JsonWriter writer)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002368 File Offset: 0x00000568
		int IList.Add(object value)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000236C File Offset: 0x0000056C
		void IList.Clear()
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002370 File Offset: 0x00000570
		bool IList.Contains(object value)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002374 File Offset: 0x00000574
		int IList.IndexOf(object value)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002378 File Offset: 0x00000578
		void IList.Insert(int index, object value)
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000237C File Offset: 0x0000057C
		void IList.Remove(object value)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002380 File Offset: 0x00000580
		void IList.RemoveAt(int index)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002384 File Offset: 0x00000584
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002388 File Offset: 0x00000588
		void IOrderedDictionary.Insert(int idx, object key, object value)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000238C File Offset: 0x0000058C
		void IOrderedDictionary.RemoveAt(int idx)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00002390 File Offset: 0x00000590
		public int Count
		{
			get
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002394 File Offset: 0x00000594
		public bool IsArray
		{
			get
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00002398 File Offset: 0x00000598
		public bool IsBoolean
		{
			get
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000239C File Offset: 0x0000059C
		public bool IsDouble
		{
			get
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000023A0 File Offset: 0x000005A0
		public bool IsInt
		{
			get
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000023A4 File Offset: 0x000005A4
		public bool IsLong
		{
			get
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000023A8 File Offset: 0x000005A8
		public bool IsObject
		{
			get
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000023AC File Offset: 0x000005AC
		public bool IsString
		{
			get
			{
			}
		}

		// Token: 0x17000024 RID: 36
		public JsonData this[string prop_name]
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		public JsonData this[int index]
		{
			get
			{
			}
			set
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000023C0 File Offset: 0x000005C0
		private ICollection EnsureCollection()
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000023C4 File Offset: 0x000005C4
		private IDictionary EnsureDictionary()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000023C8 File Offset: 0x000005C8
		private IList EnsureList()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000023CC File Offset: 0x000005CC
		private JsonData ToJsonData(object obj)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000023D0 File Offset: 0x000005D0
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000023D4 File Offset: 0x000005D4
		public int Add(object value)
		{
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000023D8 File Offset: 0x000005D8
		public void Clear()
		{
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000023DC File Offset: 0x000005DC
		public bool Equals(JsonData x)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000023E0 File Offset: 0x000005E0
		public JsonType GetJsonType()
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000023E4 File Offset: 0x000005E4
		public void SetJsonType(JsonType type)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000023E8 File Offset: 0x000005E8
		public string ToJson()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000023EC File Offset: 0x000005EC
		public void ToJson(JsonWriter writer)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000023F0 File Offset: 0x000005F0
		public override string ToString()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000023F4 File Offset: 0x000005F4
		public static implicit operator JsonData(bool data)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000023F8 File Offset: 0x000005F8
		public static implicit operator JsonData(double data)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000023FC File Offset: 0x000005FC
		public static implicit operator JsonData(int data)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002400 File Offset: 0x00000600
		public static implicit operator JsonData(long data)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002404 File Offset: 0x00000604
		public static implicit operator JsonData(string data)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002408 File Offset: 0x00000608
		public static explicit operator bool(JsonData data)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000240C File Offset: 0x0000060C
		public static explicit operator double(JsonData data)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002410 File Offset: 0x00000610
		public static explicit operator int(JsonData data)
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002414 File Offset: 0x00000614
		public static explicit operator long(JsonData data)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002418 File Offset: 0x00000618
		public static explicit operator string(JsonData data)
		{
		}

		// Token: 0x04000034 RID: 52
		private IList<JsonData> inst_array;

		// Token: 0x04000035 RID: 53
		private bool inst_boolean;

		// Token: 0x04000036 RID: 54
		private double inst_double;

		// Token: 0x04000037 RID: 55
		private int inst_int;

		// Token: 0x04000038 RID: 56
		private long inst_long;

		// Token: 0x04000039 RID: 57
		private IDictionary<string, JsonData> inst_object;

		// Token: 0x0400003A RID: 58
		private string inst_string;

		// Token: 0x0400003B RID: 59
		private string json;

		// Token: 0x0400003C RID: 60
		private JsonType type;

		// Token: 0x0400003D RID: 61
		private IList<KeyValuePair<string, JsonData>> object_list;
	}
}
