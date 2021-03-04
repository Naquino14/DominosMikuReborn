using System.IO;
using System.Reflection;

namespace System.Runtime.Serialization.Formatters.Binary
{
	internal class MemberTypeMetadata : ClrTypeMetadata
	{
		private MemberInfo[] members;

		public MemberTypeMetadata(Type type, StreamingContext context)
		{
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
