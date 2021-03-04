using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace UnityEngine
{
	public sealed class Application
	{
		public delegate void LogCallback(string condition, string stackTrace, LogType type);

		private static volatile LogCallback s_LogCallback;

		public static int loadedLevel
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static string loadedLevelName
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool isLoadingLevel
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static int levelCount
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static int streamedBytes
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool isPlaying
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool isEditor
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool isWebPlayer
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static RuntimePlatform platform
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool runInBackground
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		[Obsolete("use Application.isEditor instead")]
		public static bool isPlayer => (byte)/*Error near IL_0001: Stack underflow*/ != 0;

		public static string dataPath
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static string streamingAssetsPath
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		[SecurityCritical]
		public static string persistentDataPath
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static string temporaryCachePath
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static string srcValue
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static string absoluteURL
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		[Obsolete("Please use absoluteURL instead")]
		public static string absoluteUrl => (string)/*Error near IL_0001: Stack underflow*/;

		public static string unityVersion
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool webSecurityEnabled
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static string webSecurityHostUrl
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static int targetFrameRate
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static SystemLanguage systemLanguage
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static ThreadPriority backgroundLoadingPriority
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public static NetworkReachability internetReachability
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool genuine
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public static bool genuineCheckAvailable
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void Quit();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void CancelQuit();

		public static void LoadLevel(int index)
		{
		}

		public static void LoadLevel(string name)
		{
		}

		public static AsyncOperation LoadLevelAsync(int index)
		{
			return (AsyncOperation)/*Error near IL_0001: Stack underflow*/;
		}

		public static AsyncOperation LoadLevelAsync(string levelName)
		{
			return (AsyncOperation)/*Error near IL_0001: Stack underflow*/;
		}

		public static AsyncOperation LoadLevelAdditiveAsync(int index)
		{
			return (AsyncOperation)/*Error near IL_0001: Stack underflow*/;
		}

		public static AsyncOperation LoadLevelAdditiveAsync(string levelName)
		{
			return (AsyncOperation)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern AsyncOperation LoadLevelAsync(string monoLevelName, int index, bool additive, bool mustCompleteNextFrame);

		public static void LoadLevelAdditive(int index)
		{
		}

		public static void LoadLevelAdditive(string name)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern float GetStreamProgressForLevelByName(string levelName);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern float GetStreamProgressForLevel(int levelIndex);

		public static float GetStreamProgressForLevel(string levelName)
		{
			return (float)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool CanStreamedLevelBeLoadedByName(string levelName);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool CanStreamedLevelBeLoaded(int levelIndex);

		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void CaptureScreenshot(string filename, int superSize);

		public static void CaptureScreenshot(string filename)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool HasProLicense();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern bool HasAdvancedLicense();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		[Obsolete("Use Object.DontDestroyOnLoad instead")]
		public static extern void DontDestroyOnLoad(Object mono);

		private static string ObjectToJSString(object o)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static void ExternalCall(string functionName, params object[] args)
		{
		}

		private static string BuildInvocationForArguments(string functionName, params object[] args)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		public static void ExternalEval(string script)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void Internal_ExternalCall(string script);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern int GetBuildUnityVersion();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern int GetNumericUnityVersion(string version);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void OpenURL(string url);

		[MethodImpl(4096)]
		[Obsolete("For internal use only")]
		[WrapperlessIcall]
		public static extern void CommitSuicide(int mode);

		public static void RegisterLogCallback(LogCallback handler)
		{
		}

		public static void RegisterLogCallbackThreaded(LogCallback handler)
		{
		}

		private static void CallLogCallback(string logString, string stackTrace, LogType type)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern void SetLogCallbackDefined(bool defined, bool threaded);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern AsyncOperation RequestUserAuthorization(UserAuthorization mode);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool HasUserAuthorization(UserAuthorization mode);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		internal static extern void ReplyToUserAuthorizationRequest(bool reply, bool remember);

		internal static void ReplyToUserAuthorizationRequest(bool reply)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int GetUserAuthorizationRequestMode_Internal();

		internal static UserAuthorization GetUserAuthorizationRequestMode()
		{
			return (UserAuthorization)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
