using System;
using System.Collections;
using System.Collections.Specialized;

namespace LitJson
{
	// Token: 0x0200000D RID: 13
	public interface IJsonWrapper : ICollection, IDictionary, IList, IEnumerable, IOrderedDictionary
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000BB RID: 187
		bool IsArray { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000BC RID: 188
		bool IsBoolean { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000BD RID: 189
		bool IsDouble { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000BE RID: 190
		bool IsInt { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000BF RID: 191
		bool IsLong { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000C0 RID: 192
		bool IsObject { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000C1 RID: 193
		bool IsString { get; }

		// Token: 0x060000C2 RID: 194
		bool GetBoolean();

		// Token: 0x060000C3 RID: 195
		double GetDouble();

		// Token: 0x060000C4 RID: 196
		int GetInt();

		// Token: 0x060000C5 RID: 197
		JsonType GetJsonType();

		// Token: 0x060000C6 RID: 198
		long GetLong();

		// Token: 0x060000C7 RID: 199
		string GetString();

		// Token: 0x060000C8 RID: 200
		void SetBoolean(bool val);

		// Token: 0x060000C9 RID: 201
		void SetDouble(double val);

		// Token: 0x060000CA RID: 202
		void SetInt(int val);

		// Token: 0x060000CB RID: 203
		void SetJsonType(JsonType type);

		// Token: 0x060000CC RID: 204
		void SetLong(long val);

		// Token: 0x060000CD RID: 205
		void SetString(string val);

		// Token: 0x060000CE RID: 206
		string ToJson();

		// Token: 0x060000CF RID: 207
		void ToJson(JsonWriter writer);
	}
}
