using System.IO;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	internal sealed class UnityLogWriter : TextWriter
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void WriteStringToUnityLog(string s);

		public static void Init()
		{
		}

		public override void Write(char value)
		{
		}

		public override void Write(string s)
		{
		}
	}
}
