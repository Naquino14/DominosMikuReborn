using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary
{
	internal class ObjectWriter
	{
		private class MetadataReference
		{
			public TypeMetadata Metadata;

			public long ObjectID;

			public MetadataReference(TypeMetadata metadata, long id)
			{
			}
		}

		private ObjectIDGenerator _idGenerator;

		private Hashtable _cachedMetadata;

		private Queue _pendingObjects;

		private Hashtable _assemblyCache;

		private static Hashtable _cachedTypes;

		internal static Assembly CorlibAssembly;

		internal static string CorlibAssemblyName;

		private ISurrogateSelector _surrogateSelector;

		private StreamingContext _context;

		private FormatterAssemblyStyle _assemblyFormat;

		private FormatterTypeStyle _typeFormat;

		private byte[] arrayBuffer;

		private int ArrayBufferLength;

		private SerializationObjectManager _manager;

		public ObjectWriter(ISurrogateSelector surrogateSelector, StreamingContext context, FormatterAssemblyStyle assemblyFormat, FormatterTypeStyle typeFormat)
		{
		}

		public void WriteObjectGraph(BinaryWriter writer, object obj, Header[] headers)
		{
		}

		public void QueueObject(object obj)
		{
		}

		public void WriteQueuedObjects(BinaryWriter writer)
		{
		}

		public void WriteObjectInstance(BinaryWriter writer, object obj, bool isValueObject)
		{
		}

		public static void WriteSerializationEnd(BinaryWriter writer)
		{
		}

		private void WriteObject(BinaryWriter writer, long id, object obj)
		{
		}

		private void GetObjectData(object obj, out TypeMetadata metadata, out object data)
		{
		}

		private TypeMetadata CreateMemberTypeMetadata(Type type)
		{
			return (TypeMetadata)/*Error near IL_0001: Stack underflow*/;
		}

		private void WriteArray(BinaryWriter writer, long id, Array array)
		{
		}

		private void WriteGenericArray(BinaryWriter writer, long id, Array array)
		{
		}

		private void WriteObjectArray(BinaryWriter writer, long id, Array array)
		{
		}

		private void WriteStringArray(BinaryWriter writer, long id, Array array)
		{
		}

		private void WritePrimitiveTypeArray(BinaryWriter writer, long id, Array array)
		{
		}

		private void BlockWrite(BinaryWriter writer, Array array, int dataSize)
		{
		}

		private void WriteSingleDimensionArrayElements(BinaryWriter writer, Array array, Type elementType)
		{
		}

		private void WriteNullFiller(BinaryWriter writer, int numNulls)
		{
		}

		private void WriteObjectReference(BinaryWriter writer, long id)
		{
		}

		public void WriteValue(BinaryWriter writer, Type valueType, object val)
		{
		}

		private void WriteString(BinaryWriter writer, long id, string str)
		{
		}

		public int WriteAssembly(BinaryWriter writer, Assembly assembly)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public int WriteAssemblyName(BinaryWriter writer, string assembly)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public int GetAssemblyId(Assembly assembly)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public int GetAssemblyNameId(string assembly)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int RegisterAssembly(string assembly, out bool firstTime)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		public static void WritePrimitiveValue(BinaryWriter writer, object value)
		{
		}

		public static void WriteTypeCode(BinaryWriter writer, Type type)
		{
		}

		public static TypeTag GetTypeTag(Type type)
		{
			return (TypeTag)/*Error near IL_0001: Stack underflow*/;
		}

		public void WriteTypeSpec(BinaryWriter writer, Type type)
		{
		}
	}
}
