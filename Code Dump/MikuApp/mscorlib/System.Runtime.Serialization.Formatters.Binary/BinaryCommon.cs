namespace System.Runtime.Serialization.Formatters.Binary
{
	internal class BinaryCommon
	{
		public static byte[] BinaryHeader;

		private static Type[] _typeCodesToType;

		private static byte[] _typeCodeMap;

		public static bool UseReflectionSerialization;

		static BinaryCommon()
		{
		}

		public static bool IsPrimitive(Type type)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static byte GetTypeCode(Type type)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/;
		}

		public static Type GetTypeFromCode(int code)
		{
			return (Type)/*Error near IL_0001: Stack underflow*/;
		}

		public static void CheckSerializable(Type type, ISurrogateSelector selector, StreamingContext context)
		{
		}

		public static void SwapBytes(byte[] byteArray, int size, int dataSize)
		{
		}
	}
}
