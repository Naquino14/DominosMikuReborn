using System;
using System.Collections.Generic;
using System.Security;

namespace UnityEngine
{
	internal class GUIStateObjects
	{
		private static Dictionary<int, object> s_StateCache;

		[SecuritySafeCritical]
		internal static object GetStateObject(Type t, int controlID)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}

		internal static object QueryStateObject(Type t, int controlID)
		{
			return (object)/*Error near IL_0001: Stack underflow*/;
		}
	}
}
