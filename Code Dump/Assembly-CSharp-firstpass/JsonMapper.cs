using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LitJson
{
	// Token: 0x02000014 RID: 20
	public class JsonMapper
	{
		// Token: 0x06000149 RID: 329 RVA: 0x0000248C File Offset: 0x0000068C
		private static void AddArrayMetadata(Type type)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002490 File Offset: 0x00000690
		private static void AddObjectMetadata(Type type)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002494 File Offset: 0x00000694
		private static void AddTypeProperties(Type type)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002498 File Offset: 0x00000698
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000249C File Offset: 0x0000069C
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000024A0 File Offset: 0x000006A0
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000024A4 File Offset: 0x000006A4
		private static void RegisterBaseExporters()
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000024A8 File Offset: 0x000006A8
		private static void RegisterBaseImporters()
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000024AC File Offset: 0x000006AC
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000024B0 File Offset: 0x000006B0
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000024B4 File Offset: 0x000006B4
		public static string ToJson(object obj)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000024B8 File Offset: 0x000006B8
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000024BC File Offset: 0x000006BC
		public static JsonData ToObject(JsonReader reader)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000024C0 File Offset: 0x000006C0
		public static JsonData ToObject(TextReader reader)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000024C4 File Offset: 0x000006C4
		public static JsonData ToObject(string json)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000024C8 File Offset: 0x000006C8
		public static T ToObject<T>(JsonReader reader)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000024CC File Offset: 0x000006CC
		public static T ToObject<T>(TextReader reader)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000024D0 File Offset: 0x000006D0
		public static T ToObject<T>(string json)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000024D4 File Offset: 0x000006D4
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000024D8 File Offset: 0x000006D8
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000024DC File Offset: 0x000006DC
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000024E0 File Offset: 0x000006E0
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000024E4 File Offset: 0x000006E4
		public static void UnregisterExporters()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000024E8 File Offset: 0x000006E8
		public static void UnregisterImporters()
		{
		}

		// Token: 0x04000048 RID: 72
		private static int max_nesting_depth;

		// Token: 0x04000049 RID: 73
		private static IFormatProvider datetime_format;

		// Token: 0x0400004A RID: 74
		private static IDictionary<Type, ExporterFunc> base_exporters_table;

		// Token: 0x0400004B RID: 75
		private static IDictionary<Type, ExporterFunc> custom_exporters_table;

		// Token: 0x0400004C RID: 76
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		// Token: 0x0400004D RID: 77
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		// Token: 0x0400004E RID: 78
		private static IDictionary<Type, ArrayMetadata> array_metadata;

		// Token: 0x0400004F RID: 79
		private static readonly object array_metadata_lock;

		// Token: 0x04000050 RID: 80
		private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		// Token: 0x04000051 RID: 81
		private static readonly object conv_ops_lock;

		// Token: 0x04000052 RID: 82
		private static IDictionary<Type, ObjectMetadata> object_metadata;

		// Token: 0x04000053 RID: 83
		private static readonly object object_metadata_lock;

		// Token: 0x04000054 RID: 84
		private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

		// Token: 0x04000055 RID: 85
		private static readonly object type_properties_lock;

		// Token: 0x04000056 RID: 86
		private static JsonWriter static_writer;

		// Token: 0x04000057 RID: 87
		private static readonly object static_writer_lock;
	}
}
