using System.Runtime.CompilerServices;

namespace UnityEngine
{
	public sealed class PlayerPrefs
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool TrySetInt(string key, int value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool TrySetFloat(string key, float value);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool TrySetSetString(string key, string value);

		public static void SetInt(string key, int value)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern int GetInt(string key, int defaultValue);

		public static void SetFloat(string key, float value)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern float GetFloat(string key, float defaultValue);

		public static void SetString(string key, string value)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern string GetString(string key, string defaultValue);

		public static string GetString(string key)
		{
			return (string)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern bool HasKey(string key);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void DeleteKey(string key);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void Save();
	}
}
