using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	[StructLayout(0)]
	public sealed class AnimationCurve
	{
		internal IntPtr m_Ptr;

		public Keyframe[] keys
		{
			get
			{
				return (Keyframe[])/*Error near IL_0001: Stack underflow*/;
			}
			set
			{
			}
		}

		public Keyframe this[int index] => (Keyframe)/*Error near IL_0001: Stack underflow*/;

		public int length
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
		}

		public WrapMode preWrapMode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public WrapMode postWrapMode
		{
			[MethodImpl(4096)]
			[WrapperlessIcall]
			get;
			[MethodImpl(4096)]
			[WrapperlessIcall]
			set;
		}

		public AnimationCurve(params Keyframe[] keys)
		{
		}

		public AnimationCurve()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Cleanup();

		~AnimationCurve()
		{
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern float Evaluate(float time);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern int AddKey(float time, float value);

		public int AddKey(Keyframe key)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		private int AddKey_Internal(Keyframe key)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int INTERNAL_CALL_AddKey_Internal(AnimationCurve self, ref Keyframe key);

		public int MoveKey(int index, Keyframe key)
		{
			return (int)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private static extern int INTERNAL_CALL_MoveKey(AnimationCurve self, int index, ref Keyframe key);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void RemoveKey(int index);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void SetKeys(Keyframe[] keys);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern Keyframe GetKey_Internal(int index);

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern Keyframe[] GetKeys();

		[MethodImpl(4096)]
		[WrapperlessIcall]
		public extern void SmoothTangents(int index, float weight);

		public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			return (AnimationCurve)/*Error near IL_0001: Stack underflow*/;
		}

		public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
		{
			return (AnimationCurve)/*Error near IL_0001: Stack underflow*/;
		}

		[MethodImpl(4096)]
		[WrapperlessIcall]
		private extern void Init(Keyframe[] keys);
	}
}
