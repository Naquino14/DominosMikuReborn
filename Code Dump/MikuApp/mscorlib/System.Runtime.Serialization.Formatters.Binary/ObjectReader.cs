using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary
{
	internal class ObjectReader
	{
		private class ArrayNullFiller
		{
			public int NullCount;

			public ArrayNullFiller(int count)
			{
			}
		}

		private class TypeMetadata
		{
			public Type Type;

			public Type[] MemberTypes;

			public string[] MemberNames;

			public MemberInfo[] MemberInfos;

			public int FieldCount;

			public bool NeedsSerializationInfo;
		}

		private ISurrogateSelector _surrogateSelector;

		private StreamingContext _context;

		private SerializationBinder _binder;

		private TypeFilterLevel _filterLevel;

		private ObjectManager _manager;

		private Hashtable _registeredAssemblies;

		private Hashtable _typeMetadataCache;

		private object _lastObject;

		private long _lastObjectID;

		private long _rootObjectID;

		private byte[] arrayBuffer;

		private int ArrayBufferLength;

		public object CurrentObject => (object)/*Error near IL_0001: Stack underflow*/;

		public ObjectReader(BinaryFormatter formatter)
		{
		}

		public void ReadObjectGraph(BinaryReader reader, bool readHeaders, out object result, out Header[] headers)
		{
		}

		public void ReadObjectGraph(BinaryElement elem, BinaryReader reader, bool readHeaders, out object result, out Header[] headers)
		{
		}

		private bool ReadNextObject(BinaryElement element, BinaryReader reader)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public bool ReadNextObject(BinaryReader reader)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private void ReadObject(BinaryElement element, BinaryReader reader, out long objectId, out object value, out SerializationInfo info)
		{
		}

		private void ReadAssembly(BinaryReader reader)
		{
		}

		private void ReadObjectInstance(BinaryReader reader, bool isRuntimeObject, bool hasTypeInfo, out long objectId, out object value, out SerializationInfo info)
		{
		}

		private void ReadRefTypeObjectInstance(BinaryReader reader, out long objectId, out object value, out SerializationInfo info)
		{
		}

		private void ReadObjectContent(BinaryReader reader, TypeMetadata metadata, long objectId, out object objectInstance, out SerializationInfo info)
		{
		}

		private void RegisterObject(long objectId, object objectInstance, SerializationInfo info, long parentObjectId, MemberInfo parentObjectMemeber, int[] indices)
		{
		}

		private void ReadStringIntance(BinaryReader reader, out long objectId, out object value)
		{
		}

		private void ReadGenericArray(BinaryReader reader, out long objectId, out object val)
		{
		}

		private object ReadBoxedPrimitiveTypeValue(BinaryReader reader)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		private void ReadArrayOfPrimitiveType(BinaryReader reader, out long objectId, out object val)
		{
		}

		private void BlockRead(BinaryReader reader, Array array, int dataSize)
		{
		}

		private void ReadArrayOfObject(BinaryReader reader, out long objectId, out object array)
		{
		}

		private void ReadArrayOfString(BinaryReader reader, out long objectId, out object array)
		{
		}

		private void ReadSimpleArray(BinaryReader reader, Type elementType, out long objectId, out object val)
		{
		}

		private TypeMetadata ReadTypeMetadata(BinaryReader reader, bool isRuntimeObject, bool hasTypeInfo)
		{
			return (TypeMetadata)/*Error near IL_0001: Stack underflow*/;
		}

		private void ReadValue(BinaryReader reader, object parentObject, long parentObjectId, SerializationInfo info, Type valueType, string fieldName, MemberInfo memberInfo, int[] indices)
		{
		}

		private void SetObjectValue(object parentObject, string fieldName, MemberInfo memberInfo, SerializationInfo info, object value, Type valueType, int[] indices)
		{
		}

		private void RecordFixup(long parentObjectId, long childObjectId, object parentObject, SerializationInfo info, string fieldName, MemberInfo memberInfo, int[] indices)
		{
		}

		private Type GetDeserializationType(long assemblyId, string className)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		public Type ReadType(BinaryReader reader, TypeTag code)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		public static object ReadPrimitiveTypeValue(BinaryReader reader, Type type)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
