using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngineInternal;

namespace UnityEngine
{
	[StructLayout(0)]
	public class Object
	{
		private ReferenceData m_UnityRuntimeReferenceData;

		public string name
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public HideFlags hideFlags
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public override bool Equals(object o)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public override int GetHashCode()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern bool CompareBaseObjectsInternal([Writable] Object lhs, [Writable] Object rhs);

		[NotRenamed]
		public int GetInstanceID()
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Object Internal_CloneSingle(Object data);

		private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot)
		{
			return (Object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern Object INTERNAL_CALL_Internal_InstantiateSingle(Object data, ref Vector3 pos, ref Quaternion rot);

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			return (Object)/*Error near IL_0001: Stack underflow*/;
		}

		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		public static Object Instantiate(Object original)
		{
			return (Object)/*Error near IL_0001: Stack underflow*/;
		}

		private static void CheckNullArgument(object arg, string message)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void Destroy(Object obj, float t);

		public static void Destroy(Object obj)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void DestroyImmediate(Object obj, bool allowDestroyingAssets);

		public static void DestroyImmediate(Object obj)
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		public static extern Object[] FindObjectsOfType(Type type);

		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		public static Object FindObjectOfType(Type type)
		{
			return (Object)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern void DontDestroyOnLoad(Object target);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public static extern Object[] FindSceneObjectsOfType(Type type);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public override extern string ToString();

		public static implicit operator bool(Object exists)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool operator ==(Object x, Object y)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}

		public static bool operator !=(Object x, Object y)
		{
			return (byte)/*Error near IL_0001: Stack underflow*/ != 0;
		}
	}
}
