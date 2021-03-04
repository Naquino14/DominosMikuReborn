using System.Collections;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters.Binary
{
	internal class MessageFormatter
	{
		public static void WriteMethodCall(BinaryWriter writer, object obj, Header[] headers, ISurrogateSelector surrogateSelector, StreamingContext context, FormatterAssemblyStyle assemblyFormat, FormatterTypeStyle typeFormat)
		{
		}

		public static void WriteMethodResponse(BinaryWriter writer, object obj, Header[] headers, ISurrogateSelector surrogateSelector, StreamingContext context, FormatterAssemblyStyle assemblyFormat, FormatterTypeStyle typeFormat)
		{
		}

		public static object ReadMethodCall(BinaryElement elem, BinaryReader reader, bool hasHeaders, HeaderHandler headerHandler, BinaryFormatter formatter)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public static object ReadMethodResponse(BinaryReader reader, bool hasHeaders, HeaderHandler headerHandler, IMethodCallMessage methodCallMessage, BinaryFormatter formatter)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		public static object ReadMethodResponse(BinaryElement elem, BinaryReader reader, bool hasHeaders, HeaderHandler headerHandler, IMethodCallMessage methodCallMessage, BinaryFormatter formatter)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool AllTypesArePrimitive(object[] objects)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool IsMethodPrimitive(Type type)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		private static object[] GetExtraProperties(IDictionary properties, string[] internalKeys)
		{
			return (object[])/*Error near IL_0001: Stack underflow*/;
		}

		private static bool IsInternalKey(string key, string[] internalKeys)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
