using System.Diagnostics;

namespace UnityEngine
{
	public class StackTraceUtility
	{
		private static string projectFolder;

		internal static void SetProjectFolder(string folder)
		{
		}

		public static string ExtractStackTrace()
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool IsSystemStacktraceType(object name)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static string ExtractStringFromException(object exception)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace)
		{
		}

		internal static string PostprocessStacktrace(string oldString, bool stripEngineInternalInformation)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		internal static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
