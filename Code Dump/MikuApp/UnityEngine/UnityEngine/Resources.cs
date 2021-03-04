using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	public sealed class Resources
	{
		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern Object[] FindObjectsOfTypeAll(Type type);

		public static Object Load(string path)
		{
			return (Object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		public static extern Object Load(string path, Type systemTypeInstance);
	}
}
