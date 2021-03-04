using System;
using System.Runtime.CompilerServices;
using UnityEngineInternal;

namespace UnityEngine
{
	public sealed class AssetBundle : Object
	{
		public Object mainAsset
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public Object Load(string name)
		{
			return (Object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[WrapperlessIcall]
		public extern Object Load(string name, Type type);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void Unload(bool unloadAllLoadedObjects);
	}
}
