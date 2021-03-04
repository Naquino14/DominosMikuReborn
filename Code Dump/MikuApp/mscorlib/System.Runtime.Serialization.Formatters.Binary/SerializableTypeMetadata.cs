using System.IO;

namespace System.Runtime.Serialization.Formatters.Binary
{
	internal class SerializableTypeMetadata : TypeMetadata
	{
		private Type[] types;

		private string[] names;

		public override bool RequiresTypes => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public SerializableTypeMetadata(Type itype, SerializationInfo info)
		{
		}

		public override bool IsCompatible(TypeMetadata other)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override void WriteAssemblies(ObjectWriter ow, BinaryWriter writer)
		{
		}

		public override void WriteTypeData(ObjectWriter ow, BinaryWriter writer, bool writeTypes)
		{
		}

		public override void WriteObjectData(ObjectWriter ow, BinaryWriter writer, object data)
		{
		}
	}
}
